using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.InteropServices;

namespace ConnectFourClient
{
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

    public partial class Form1 : Form
    {
        Socket m_ClientSocket;
        System.Net.IPEndPoint m_remoteEndPoint;
        public int num;

        private static System.Windows.Forms.Timer m_CommunicationActivity_Timer;
        public Form1()
        {
            InitializeComponent();
            m_CommunicationActivity_Timer = new System.Windows.Forms.Timer(); // Check for communication activity on Non-Blocking sockets every 200ms
            m_CommunicationActivity_Timer.Tick += new EventHandler(OnTimedEvent_PeriodicCommunicationActivityCheck); // Set event handler method for timer
            m_CommunicationActivity_Timer.Interval = 100;  // Timer interval is 1/10 second
            m_CommunicationActivity_Timer.Enabled = false;
            CloseConnection_button.Enabled = false;
            CloseConnection_button.Text = "Close Connection";
            string szLocalIPAddress = GetLocalIPAddress_AsString(); // Get local IP address as a default value
            IP_Address_textBox.Text = szLocalIPAddress;             // Place local IP address in IP address field
            SendPort_textBox.Text = "8000"; // Default port number
           
        }
        int[,] a = new int[8, 8];
       
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private string GetLocalIPAddress_AsString()
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

        public byte[] ToBytes(object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            byte[] bytes = ms.ToArray();
            return bytes;
        }
        public int[,] FromBytes(byte[] buffer)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream(buffer);
            int[,] mat = (int[,])bf.Deserialize(ms);
            return mat;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            int columnCount = tableLayoutPanel1.ColumnCount;
            int rowCount = tableLayoutPanel1.RowCount;

            for (int x = 0; x < columnCount; x++)
            {


                for (int y = 0; y < rowCount; y++)
                {
                    a[x, y] = 0;

                }
            }

            createTable(a);

                }

        
        public void createTable(int[,] a) {
            tableLayoutPanel1.Controls.Clear();
            int columnCount = tableLayoutPanel1.ColumnCount;
            int rowCount = tableLayoutPanel1.RowCount;

            for (int x = 0; x < columnCount; x++)
            {
                for (int y = 0; y < rowCount; y++)
                {
                    //Next, add a row.  Only do this when once, when creating the first column

                    if (a[x, y] == 1)
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.BackColor = Color.Blue;
                        tableLayoutPanel1.Controls.Add(pictureBox, x, y);
                        pictureBox.Dock = DockStyle.Fill;
                        pictureBox.Margin = new Padding(1);
                    }
                    else if (a[x, y] == 2)
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.BackColor = Color.Red;
                        tableLayoutPanel1.Controls.Add(pictureBox, x, y);
                        pictureBox.Dock = DockStyle.Fill;
                        pictureBox.Margin = new Padding(1);

                    }
                    else if(a[x, y] == 0)
                    {

                    }
                }


            }
            tableLayoutPanel1.Update();

        }

        public void senddata(string colnum)
        {
            try
            {
                String szData ="0"+" " + colnum;
             
                Message_PDU myPDU = new Message_PDU();
            
                myPDU.szText = szData;
                byte[] byData = Serialize(myPDU); //convert structure into a byte[]
                m_ClientSocket.Send(byData, SocketFlags.None);
            }
            catch // Silently handle any exceptions
            {
            }
        }

        public void sendChatData(string chatText)
        {
            try
            {
                String szData = "7" +" "+playerLbl.Text+ " "+textBoxchat.Text ;

                Message_PDU myPDU = new Message_PDU();

                myPDU.szText = szData;
                myPDU.chatText = textBoxchat.Text;
                byte[] byData = Serialize(myPDU); //convert structure into a byte[]
                m_ClientSocket.Send(byData, SocketFlags.None);
            }
            catch // Silently handle any exceptions
            {
            }
        }

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

        public void addCounter(int b, int ncol) {
            int columnCount = tableLayoutPanel1.ColumnCount;
            int rowCount = tableLayoutPanel1.RowCount;







            for (int y = 7; y < rowCount; y--)
            {
                if (y == -1)
                {
                    break;
                }
                if (a[ncol, y] == 0)
                {


                    a[ncol, y] = b;


                   
                    break;
                }
                



            }


            createTable(a);

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            addCounter(num, 0);
            senddata("0");
            Boolean Winner = CheckWin(num);
            if (Winner == true)
            {
                MessageBox.Show("Player " + num + " has won the game");
                disableButtons();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            addCounter(num, 1);
            senddata("1");
            Boolean Winner = CheckWin(num);
            if (Winner == true)
            {
                MessageBox.Show("Player " + num + " has won the game");
                disableButtons();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            addCounter(num, 2);
            senddata("2");
            Boolean Winner = CheckWin(num);
            if (Winner == true)
            {
                MessageBox.Show("Player " + num + " has won the game");
                disableButtons();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            addCounter(num, 3);
            senddata("3");
            Boolean Winner = CheckWin(num);
            if (Winner == true)
            {
                MessageBox.Show("Player " + num + " has won the game");
                disableButtons();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
       
            addCounter(num, 4);
            senddata("4");
            Boolean Winner = CheckWin(num);
            if (Winner == true)
            {
                MessageBox.Show("Player " + num + " has won the game");
                disableButtons();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
     
            addCounter(num, 5);
            senddata("5");
            Boolean Winner = CheckWin(num);
            if (Winner == true)
            {
                MessageBox.Show("Player " + num + " has won the game");
                disableButtons();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
            addCounter(num, 6);
            senddata("6");
            Boolean Winner = CheckWin(num);
            if (Winner == true)
            {
                MessageBox.Show("Player " + num + " has won the game");
                disableButtons();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            addCounter(num, 7);
            senddata("7");
            Boolean Winner = CheckWin(num);
            if (Winner == true)
            {
                MessageBox.Show("Player " + num + " has won the game");
                disableButtons();
            }

        }

        public void disableButtons() {
            turnLbl.Text = "You Have Won";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
         
                try
                {
                    String szData = "9"+ " "+ playerLbl.Text;

                    Message_PDU myPDU = new Message_PDU();

                    myPDU.szText = szData;
                    byte[] byData = Serialize(myPDU); //convert structure into a byte[]
                    m_ClientSocket.Send(byData, SocketFlags.None);
                }
                catch // Silently handle any exceptions
                {
                }
            

        }
        private void Connect_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Create the socket, for TCP use
                m_ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                m_ClientSocket.Blocking = true; // Socket operates in Blocking mode initially
            }
            catch // Handle any exceptions
            {
                Close_Socket_and_Exit();
            }
            try
            {
                // Get the IP address from the appropriate text box
                String szIPAddress = IP_Address_textBox.Text;
                System.Net.IPAddress DestinationIPAddress = System.Net.IPAddress.Parse(szIPAddress);

                // Get the Port number from the appropriate text box
                String szPort = SendPort_textBox.Text;
                int iPort = System.Convert.ToInt16(szPort, 10);

                // Combine Address and Port to create an Endpoint
                m_remoteEndPoint = new System.Net.IPEndPoint(DestinationIPAddress, iPort);

                m_ClientSocket.Connect(m_remoteEndPoint);
                m_ClientSocket.Blocking = false;    // Socket is now switched to Non-Blocking mode for send/ receive activities
                Connect_button.Text = "Connected";
                Connect_button.Enabled = false;
                CloseConnection_button.Enabled = true;
                CloseConnection_button.Text = "Close Connection";
                m_CommunicationActivity_Timer.Start();  // Start the timer to perform periodic checking for received messages   
            }
            catch // Catch all exceptions
            {   // If an exception occurs, display an error message
                Connect_button.Text = "(Connect attempt failed)\nRetry Connect";
            }

        }
        private void OnTimedEvent_PeriodicCommunicationActivityCheck(Object myObject, EventArgs myEventArgs)
        {   // Periodic check whether a message has been received    
            try
            {
                EndPoint RemoteEndPoint = (EndPoint)m_remoteEndPoint;
                byte[] ReceiveBuffer = new byte[1024];
                int iReceiveByteCount;
                iReceiveByteCount = m_ClientSocket.ReceiveFrom(ReceiveBuffer, ref RemoteEndPoint);
                byte[] data = new byte[iReceiveByteCount];
                Array.Copy(ReceiveBuffer, data, iReceiveByteCount); //make sure byte[] is the same length as the recieved byte[]

                if (0 < iReceiveByteCount)
                {
                    try
                    {
                        Message_PDU myPDU = DeSerialize(data); //convert the received byte[] back into a structure

                        string[] test = myPDU.szText.Split(null);
                        if (int.Parse(test[0]) == 0)
                        {

                            addCounter(int.Parse(test[1]), int.Parse(test[2]));
                            if (int.Parse(test[3]) == 4) {
                                turnLbl.Text = "Your Turn";
                                button1.Enabled = true;
                                button2.Enabled = true;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                button5.Enabled = true;
                                button6.Enabled = true;
                                button7.Enabled = true;
                                button8.Enabled = true;

                            }
                        }
                        else if (int.Parse(test[0]) == 1)
                        {
                            num = int.Parse(test[1]);
                            playerLbl.Text = "Player " + num.ToString();
                            if (num == 1)
                            {
                                turnLbl.Text = "Your Turn";
                                playerLbl.ForeColor = Color.Blue;
                                button1.ForeColor = Color.Blue;
                                button2.ForeColor = Color.Blue;
                                button3.ForeColor = Color.Blue;
                                button4.ForeColor = Color.Blue;
                                button5.ForeColor = Color.Blue;
                                button6.ForeColor = Color.Blue;
                                button7.ForeColor = Color.Blue;
                                button8.ForeColor = Color.Blue;
                                turnLbl.Text = "Your Turn";
                                button1.Enabled = true;
                                button2.Enabled = true;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                button5.Enabled = true;
                                button6.Enabled = true;
                                button7.Enabled = true;
                                button8.Enabled = true;
                            }
                            else if (num == 2) {
                                playerLbl.ForeColor = Color.Red;
                                turnLbl.Text = "Opponent Turn";
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = false;
                                button4.Enabled = false;
                                button5.Enabled = false;
                                button6.Enabled = false;
                                button7.Enabled = false;
                                button8.Enabled = false;
                                button1.ForeColor = Color.Red;
                                button2.ForeColor = Color.Red;
                                button3.ForeColor = Color.Red;
                                button4.ForeColor = Color.Red;
                                button5.ForeColor = Color.Red;
                                button6.ForeColor = Color.Red;
                                button7.ForeColor = Color.Red;
                                button8.ForeColor = Color.Red;
                            }
                        }
                        else if (int.Parse(test[0]) == 3)
                        {
                            turnLbl.Text = "Opponent Turn";
                            button1.Enabled = false;
                            button2.Enabled = false;
                            button3.Enabled = false;
                            button4.Enabled = false;
                            button5.Enabled = false;
                            button6.Enabled = false;
                            button7.Enabled = false;
                            button8.Enabled = false;
                            if (int.Parse(test[3]) == 11) {
                                turnLbl.Text = "Opponent  Won";
                                MessageBox.Show("You have Lost");
                            } else if (int.Parse(test[3]) == 12) {
                                turnLbl.Text = "You have Won";
                            }
                            else if(int.Parse(test[3]) == 13) 
                            {
                                turnLbl.Text = "Game in Progress";
                                playerLbl.Text = "None";
                            }
                            else if (int.Parse(test[3]) == 14)
                            {
                                turnLbl.Text = "Waiting for Players";
                                playerLbl.Text = "None";
                            }


                        }
                        else if (int.Parse(test[0]) == 7) {
                            chatBox.Text += Environment.NewLine +"Player"+myPDU.Player.ToString()+": " +myPDU.chatText;
                        }
                       
                    }
                    catch (Exception e) { System.Console.WriteLine(e.Message); }
                }
            }
            catch // Silently handle any exceptions
            {
            }
        }
        public Message_PDU DeSerialize(byte[] received)
        {
            IntPtr ip = Marshal.AllocHGlobal(received.Length); //allocate unmanaged memory
            Marshal.Copy(received, 0, ip, received.Length); //copy the byte[] to the unmanaged memory
            Message_PDU structure = (Message_PDU)Marshal.PtrToStructure(ip, typeof(Message_PDU)); //Marshal the unmanaged memory contents to the Message_PDU structure
            Marshal.FreeHGlobal(ip); //free unmanaged memory
            return structure;
        }

        private void Close_Socket_and_Exit()
        {
            try
            {
                m_ClientSocket.Shutdown(SocketShutdown.Both);
            }
            catch // Silently handle any exceptions
            {
            }
            try
            {
                m_ClientSocket.Close();
            }
            catch // Silently handle any exceptions
            {
            }
            this.Close();
        }

        private void CloseConnection_button_Click(object sender, EventArgs e)
        {
            

        }

        private void Connect_button_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Create the socket, for TCP use
                m_ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                m_ClientSocket.Blocking = true; // Socket operates in Blocking mode initially
                
            }
            catch // Handle any exceptions
            {
                Close_Socket_and_Exit();
            }
            try
            {
                // Get the IP address from the appropriate text box
                String szIPAddress = IP_Address_textBox.Text;
                System.Net.IPAddress DestinationIPAddress = System.Net.IPAddress.Parse(szIPAddress);

                // Get the Port number from the appropriate text box
                String szPort = SendPort_textBox.Text;
                int iPort = System.Convert.ToInt16(szPort, 10);

                // Combine Address and Port to create an Endpoint
                m_remoteEndPoint = new System.Net.IPEndPoint(DestinationIPAddress, iPort);

                m_ClientSocket.Connect(m_remoteEndPoint);
                m_ClientSocket.Blocking = false;    // Socket is now switched to Non-Blocking mode for send/ receive activities
                Connect_button.Text = "Connected";
                Connect_button.Enabled = false;
                CloseConnection_button.Enabled = true;
                CloseConnection_button.Text = "Close Connection";
               
                m_CommunicationActivity_Timer.Start();  // Start the timer to perform periodic checking for received messages
                groupBox1.Visible = false;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                sendChat.Enabled = true;
              
            }
            catch // Catch all exceptions
            {   // If an exception occurs, display an error message
                Connect_button.Text = "(Connect attempt failed)\nRetry Connect";
            }
        }

        private void CloseConnection_button_Click_1(object sender, EventArgs e)
        {
            try
            {
                m_ClientSocket.Shutdown(SocketShutdown.Both);
            }
            catch // Silently handle any exceptions
            {
            }
            try
            {
                m_ClientSocket.Close();
            }
            catch // Silently handle any exceptions
            {
            }
            this.Close();

        }

        private void turnLbl_Click(object sender, EventArgs e)
        {

        }

        private void sendChat_Click(object sender, EventArgs e)
        {
          
            sendChatData(textBoxchat.Text);
            string chat = textBoxchat.Text;
            chatBox.Text += Environment.NewLine + playerLbl.Text + ": " + chat ;
            textBoxchat.Clear();
            
        }

        Boolean CheckWin(int player)
        {

            if (verticalCheck(player)) return true;
            if (horizontalCheck(player)) return true;
            if (DiagonalCheck(player)) return true;
            return false;
        }

        Boolean verticalCheck(int player)
        {
            int columnCount = tableLayoutPanel1.ColumnCount;
            int rowCount = tableLayoutPanel1.RowCount;
            int Counter = 0;

            for (int x = 0; x < rowCount; x++)
            {
                for (int y = 0; y < columnCount; y++)
                {
                    if (a[x, y] == player)
                    {
                        Counter++;
                        if (Counter == 4)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        Counter = 0;
                    }
                }
            }
            return false;
        }

        Boolean horizontalCheck(int player)
        {
            int columnCount = tableLayoutPanel1.ColumnCount;
            int rowCount = tableLayoutPanel1.RowCount;
            int Counter = 0;

            for (int y = 0; y < columnCount; y++)
            {
                for (int x = 0; x < rowCount; x++)
                {
                    if (a[x, y] == player)
                    {
                        Counter++;
                        if (Counter == 4)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        Counter = 0;
                    }
                }
            }

            return false;
        }

        Boolean DiagonalCheck(int player)
        {
            int rowCount = tableLayoutPanel1.RowCount;
            int colCount = tableLayoutPanel1.ColumnCount;
            int row;
            int col;

            for (col = 0; col < (colCount - 3); col++)
                for (row = 0; row < (rowCount - 3); row++)
                {
                    {
                        if (
                           (a[col, row].Equals(player) &&
                            a[col + 1, row + 1].Equals(player) &&
                            a[col + 2, row + 2].Equals(player) &&
                            a[col + 2, row + 2].Equals(player) &&
                            a[col + 3, row + 3].Equals(player)
                            )
                            ||
                            (a[col + 3, row].Equals(player) &&
                            a[col + 2, row + 1].Equals(player) &&
                            a[col + 1, row + 2].Equals(player) &&
                            a[col, row + 3].Equals(player)
                            )
                            ) return true;
                    }
                }

            return false;

        }
    }

}

