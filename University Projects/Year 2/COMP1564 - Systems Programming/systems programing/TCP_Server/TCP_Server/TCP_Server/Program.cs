/*	File			Program.cs
	Purpose			TCP Server example for demonstration purposes
	Author			Richard Anthony	(R.J.Anthony@gre.ac.uk)
	Date			December 2011
	
	Special notes:
		This code has been specially prepared to demonstrate how to create an application using TCP over IP.
		Students following the "Systems Programming" course may use this
		code as a starting point for the development of their coursework.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TCP_Server
{
    static class Program
    {
        // The main entry point for the application.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TCP_Server_Form());
        }
    }
}
