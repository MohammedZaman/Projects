/*	File			TCP_Server_Form.cs
	Purpose			TCP Server example for demonstration purposes
	Author			Richard Anthony	(R.J.Anthony@gre.ac.uk)
                    structure modifications made by James Hawthorne (J.Hawthorne@gre.ac.uk)
	Date			December 2011
	
	Special notes:
		This code has been specially prepared to demonstrate how to create an application using TCP over IP.
		Students following the "Systems Programming" course may use this
		code as a starting point for the development of their coursework.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Timers;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;    

namespace TCP_Server
{
    /* This structure is fully compatible with the c++ equivelent and is used by default to exchange messages
     * between c# and c#, c++ and c# in any direection.
     * 
     * Marshaling and demarshaling is the process of converting objects into a stream and vice versa
     * (see Serialize() and Deserialize() methods later in this code)
     * This is important because only streams can be sent over a network and should be converted back to an
     * object once the receiver gets it in byte[] form
     * 
     * IMPORTANT: Whatever structure is used, they must be identical on both ends of the network
     */
    [StructLayout(LayoutKind.Sequential)]
    public struct Message_PDU
    {
        // when the structure is marshaled we can force the size and type of variables to match that on the c++ side with the following attribute.
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 300)]
        public string szText;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
        public string chatText;
        public int Player;

    }

    public partial class TCP_Server_Form : Form
    {
        private const int m_iMaxConnections = 20;

        struct Connection_Struct    // Define a structure to hold details about a single connection
        {
            public Socket ClientSpecific_Socket;
            public bool bInUse;
        };
 
        Socket m_ListenSocket;
        Connection_Struct[] m_Connection_Array = new Connection_Struct[m_iMaxConnections]; // Define an array to hold a number of connections
        
        System.Net.IPEndPoint m_LocalIPEndPoint;
        static int m_iNumberOfConnectedClients;
        private static System.Windows.Forms.Timer m_CommunicationActivity_Timer;

        public TCP_Server_Form()
        {
            InitializeComponent();
            Initialise_ConnectionArray();
            m_CommunicationActivity_Timer = new System.Windows.Forms.Timer(); // Check for communication activity on Non-Blocking sockets every 200ms
            m_CommunicationActivity_Timer.Tick += new EventHandler(OnTimedEvent_PeriodicCommunicationActivityCheck); // Set event handler method for timer
            m_CommunicationActivity_Timer.Interval = 100;  // Timer interval is 1/10 second
            m_CommunicationActivity_Timer.Enabled = false;
             string szLocalIPAddress = GetLocalIPAddress_AsString(); // Get local IP address as a default value
            IP_Address_textBox.Text = szLocalIPAddress;             // Place local IP address in IP address field
            ReceivePort_textBox.Text = "8000";  // Default port number
            m_iNumberOfConnectedClients = 0;
            NumberOfClients_textBox.Text = System.Convert.ToString(m_iNumberOfConnectedClients);
            Listen_button.Enabled = false;
            Accept_button.Enabled = false;
            try
            {   // Create the Listen socket, for TCP use
                m_ListenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                m_ListenSocket.Blocking = false;
            }
			catch (SocketException se)
			{   // If an exception occurs, display an error message
                MessageBox.Show(se.Message);
			}
       }

        private void Initialise_ConnectionArray()
        {
            int iIndex;
            for (iIndex = 0; iIndex < m_iMaxConnections; iIndex++)
            {
                m_Connection_Array[iIndex].bInUse = false;
            }
        }

        private int GetnextAvailable_ConnectionArray_Entry()
        {
            int iIndex;
            for (iIndex = 0; iIndex < m_iMaxConnections; iIndex++)
            {
                if (false == m_Connection_Array[iIndex].bInUse)
                {
                    return iIndex;  // Return the index value of the first not-in-use entry found
                }
            }
            return -1;      // Signal that there were no available entries
        }
       
       private void Bind_button_Click(object sender, EventArgs e)
       {    // Bind to the selected port and start listening / receiving
            try
            {
                // Get the Port number from the appropriate text box
                String szPort = ReceivePort_textBox.Text;
                int iPort = System.Convert.ToInt16(szPort, 10);
                // Create an Endpoint that will cause the listening activity to apply to all the local node's interfaces
                m_LocalIPEndPoint = new System.Net.IPEndPoint(IPAddress.Any, iPort);
                // Bind to the local IP Address and selected port
                m_ListenSocket.Bind(m_LocalIPEndPoint);
                Bind_button.Enabled = false;
                Bind_button.Text = "Bind succeded";
                Listen_button.Enabled = true;
                // Prevent any further changes to the port number
                ReceivePort_textBox.ReadOnly = true;
            }
  
            catch // Catch any errors
            {   // If an exception occurs, display an error message
                Bind_button.Text = "Bind failed";
            }
        }
   
        public string GetLocalIPAddress_AsString()
        {
            string szHost = Dns.GetHostName();
            string szLocalIPaddress = "127.0.0.1";  // Default is local loopback address
            IPHostEntry IPHost = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress IP in IPHost.AddressList)
            {
                if (IP.AddressFamily == AddressFamily.InterNetwork) // Match only the IPv4 address
                {
                    szLocalIPaddress = IP.ToString();
                    break;
                }
            } 
            return szLocalIPaddress;
        }

        private void Listen_button_Click(object sender, EventArgs e)
        {
            try
            {
                Listen_button.Text = "Listening";
                m_ListenSocket.Listen(2); // Listen for connections, with a backlog / queue maximum of 2
                Listen_button.Enabled = false;
                Accept_button.Enabled = true;
            }
            catch (SocketException se)
            {
                // If an exception occurs, display an error message
                MessageBox.Show(se.Message);
            }
            catch // Silently handle any other exception
            {
            }
        }

        private void Accept_button_Click(object sender, EventArgs e)
        {
            m_CommunicationActivity_Timer.Start();  // Start the timer to perform periodic checking for connection requests   
            Accept_button.Text = "Accepting (waiting for connection attempt)"; 
            Accept_button.Enabled = false;
        }

        private void About_button_Click(object sender, EventArgs e)
        {
            About_Form MyAbout_Form = new About_Form();
            MyAbout_Form.Show();
        }
        
        private void Done_button_Click(object sender, EventArgs e)
        {
            Close_And_Quit();
        }
        
        private void Close_And_Quit()
        {   // Close the sockets and exit the application
            try
            {
                m_ListenSocket.Close();
            }
            catch
            {
            }
            try
            {
                int iIndex;
                for (iIndex = 0; iIndex < m_iMaxConnections; iIndex++)
                {
                    m_Connection_Array[iIndex].ClientSpecific_Socket.Shutdown(SocketShutdown.Both);
                    m_Connection_Array[iIndex].ClientSpecific_Socket.Close();
                }
            }
            catch
            {
            } 
            try
            {
                Close();
            }
            catch
            {
            }
        }

        private void OnTimedEvent_PeriodicCommunicationActivityCheck(Object myObject, EventArgs myEventArgs)     
        {   // Periodic check whether a connection request is pending or a message has been received on a connected socket     

            // First, check for pending connection requests
            int iIndex;
            iIndex = GetnextAvailable_ConnectionArray_Entry(); // Find an available array entry for next connection request
            if (-1 != iIndex)
            {   // Only continue with Accept if there is an array entry available to hold the details
           
                try
                {   
                    m_Connection_Array[iIndex].ClientSpecific_Socket = m_ListenSocket.Accept();  // Accept a connection (if pending) and assign a new socket to it (AcceptSocket)
                    // Will 'catch' if NO connection was pending, so statements below only occur when a connection WAS pending
                    m_Connection_Array[iIndex].bInUse = true;
                    m_Connection_Array[iIndex].ClientSpecific_Socket.Blocking = false;           // Make the new socket operate in non-blocking mode
                    m_iNumberOfConnectedClients++;
                    NumberOfClients_textBox.Text = System.Convert.ToString(m_iNumberOfConnectedClients);
                    Status_textBox.Text = "A new client connected";
                    if (iIndex == 0)
                    {
                        sendData(iIndex, "3", "0", "1", "14");

                    } else if (iIndex == 1) {
                        sendData(0, "1", "0", "1", "0");
                        sendData(iIndex, "1", "0", "2", "0");

                    } else if (iIndex > 1) {
                        sendData(2, "3", "0", "4", "13");
                    }
                   
                       

                    



                }
                catch (SocketException se) // Handle socket-related exception
                {   // If an exception occurs, display an error message
                    if (10053 == se.ErrorCode || 10054 == se.ErrorCode) // Remote end closed the connection
                    {   
                        CloseConnection(iIndex);
                    }
                    else if (10035 != se.ErrorCode)
                    {   // Ignore error messages relating to normal behaviour of non-blocking sockets
                        MessageBox.Show(se.Message);
                    }
                }
                catch // Silently handle any other exception
                {
                }
            }
            
            // Second, check for received messages on each connected socket
            for (iIndex = 0; iIndex < m_iMaxConnections; iIndex++)
            {
                if (true == m_Connection_Array[iIndex].bInUse)
                {
                    try 
                    {   
                        EndPoint localEndPoint = (EndPoint)m_LocalIPEndPoint;
                        byte[] ReceiveBuffer = new byte[1024];
                        int iReceiveByteCount;
                        iReceiveByteCount = m_Connection_Array[iIndex].ClientSpecific_Socket.ReceiveFrom(ReceiveBuffer, ref localEndPoint);
                        byte[] data = new byte[iReceiveByteCount];
                        Array.Copy(ReceiveBuffer, data, iReceiveByteCount); //make sure byte[] is the same length as the recieved byte[]

                        if (0 < iReceiveByteCount)
                        {
                            
                            try
                            {
                                Message_PDU myPDU = DeSerialize(data); //convert byte[] to structure so it can be read
                                if (myPDU.szText.Equals("Disconnect"))
                                {
                                    CloseConnection(iIndex);
                                }
                                else
                                {
                                    string[] test = myPDU.szText.Split(null);
                                    if (int.Parse(test[0]) == 7)
                                    {
                                        if (iIndex == 0)
                                        {
                                            sendData(1, "7", test[0], myPDU.chatText, "1");
                                        }
                                        else if (iIndex == 1) {
                                            sendData(0, "7", test[1], myPDU.chatText, "2");
                                        }
                                    }

                                    if (int.Parse(test[0]) == 0)
                                    {
                                        if (iIndex == 0)
                                        {
                                            sendData(1, "0", test[1], "1", "4");
                                            sendData(0, "3", test[1], "0", "0");


                                        }
                                        else if (iIndex == 1)
                                        {

                                            sendData(0, "0", test[1], "2", "4");
                                            sendData(1, "3", test[1], "4", "0");

                                        }

                                    }
                                    if (int.Parse(test[0]) == 9)
                                    {
                                        if (iIndex == 0)
                                        {
                                            sendData(0, "3", test[1], "4", "12");
                                            sendData(1, "3", "0", "4", "11");
                                        } else if (iIndex == 1) {
                                            sendData(0, "3", "0", "4", "11");
                                            sendData(1, "3", test[1], "4", "12");

                                        }



                                    }


                                        // Message_textBox.Text = myPDU.szText; //display received message in edit box

                                    }
                            }
                            catch (Exception e) { System.Console.WriteLine(e.Message); }
                        }
                    }
                    catch (SocketException se) // Handle socket-related exception
                    {   // If an exception occurs, display an error message
                        if (10053 == se.ErrorCode || 10054 == se.ErrorCode) // Remote end closed the connection
                        {
                            CloseConnection(iIndex);
                        }
                        else if (10035 != se.ErrorCode)
                        {   // Ignore error messages relating to normal behaviour of non-blocking sockets
                            MessageBox.Show(se.Message);
                        }
                    }
                    catch // Silently handle any other exception
                    {
                    }
                }
            }
        }

        //converts a byte[] to a Message_PDU structure
        public Message_PDU DeSerialize(byte[] received)
        {
            IntPtr ip = Marshal.AllocHGlobal(received.Length); //allocate unmanaged memory
            Marshal.Copy(received, 0, ip, received.Length); //copy the byte[] to the unmanaged memory
            Message_PDU structure = (Message_PDU)Marshal.PtrToStructure(ip, typeof(Message_PDU)); //Marshal the unmanaged memory contents to the Message_PDU structure
            Marshal.FreeHGlobal(ip); //free unmanaged memory
            return structure;
        }

        /*private void SendUpdateMesageToAllConnectedclients()
        {   // Send message to each connected client informing of the total number of connected clients
            int iIndex;
            for (iIndex = 0; iIndex < m_iMaxConnections; iIndex++)
            {
                if (true == m_Connection_Array[iIndex].bInUse)
                {
                    Message_PDU myPDU;
                    myPDU.iMessageNumber = 0;
                    
                    if (1 == m_iNumberOfConnectedClients)
                    {
                        myPDU.szText = string.Format("There is now {0} client connected", m_iNumberOfConnectedClients);
                    }
                    else
                    {
                        myPDU.szText = string.Format("There are now {0} clients connected", m_iNumberOfConnectedClients);
                    }
                    byte[] SendMessage = Serialize(myPDU); //convert Message_PDU into a byte[] for sending
                    m_Connection_Array[iIndex].ClientSpecific_Socket.Send(SendMessage, SocketFlags.None);
                }
            }
        }
        */
        private void CloseConnection(int iIndex)
        {
            try
            {
                m_Connection_Array[iIndex].bInUse = false;
                m_Connection_Array[iIndex].ClientSpecific_Socket.Shutdown(SocketShutdown.Both);
                m_Connection_Array[iIndex].ClientSpecific_Socket.Close();
                m_iNumberOfConnectedClients--;
                NumberOfClients_textBox.Text = System.Convert.ToString(m_iNumberOfConnectedClients);
                Status_textBox.Text = "A Connection was closed";
           
            }
            catch // Silently handle any exceptions
            {
            }
       }

        //converts any object into a byte[]
        private byte[] Serialize(Object myObject)
        {
            int size = Marshal.SizeOf(myObject);
            IntPtr ip = Marshal.AllocHGlobal(size); //allocate unmanaged memory equivelent to the size of the object
            Marshal.StructureToPtr(myObject, ip, false); //marshal the object into the allocated memory
            byte[] byteArray = new byte[size];
            Marshal.Copy(ip, byteArray, 0, size); //place the contents of memory into a byte[]
            Marshal.FreeHGlobal(ip); //free unmanaged memory
            return byteArray;
        }

        public void sendData(int client,string messagei ,string colnum,string player,string open) {
            Message_PDU myPDU;
            myPDU.Player = int.Parse(open);
            myPDU.szText = string.Format(messagei + " " +player+" "+colnum + " " + open);
            myPDU.chatText = player;
            byte[] SendMessage = Serialize(myPDU); //convert Message_PDU into a byte[] for sending
            m_Connection_Array[client].ClientSpecific_Socket.Send(SendMessage, SocketFlags.None);
        }
    }
}
