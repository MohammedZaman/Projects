/*	File			About_Form.cs
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCP_Server
{
    public partial class About_Form : Form
    {
        public About_Form()
        {
            InitializeComponent();
        }

        private void Done_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
