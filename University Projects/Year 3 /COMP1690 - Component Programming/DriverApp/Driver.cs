using DriverApp.Log;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverApp
{
    public partial class Driver : Form
    {

        private LogSoapClient client;
        public Driver()
        {
            InitializeComponent();
            client = new LogSoapClient();
        }

        private void startDayBtn_Click(object sender, EventArgs e)
        {
            
            if (DriverIdTxt.Text != "") {
                int id = int.Parse(DriverIdTxt.Text);
                MessageBox.Show(client.startDay(id));
            }
            else { MessageBox.Show("Driver Id requred"); }
          

        }

        private void endDayBtn_Click(object sender, EventArgs e)
        {
            
            if (DriverIdTxt.Text != "")
            {
                int id = int.Parse(DriverIdTxt.Text);
                MessageBox.Show(client.endDay(id));
            }
            else { MessageBox.Show("Driver Id requred"); }
        }

        private void startJBtn_Click(object sender, EventArgs e)
        {
          
            if (DriverIdTxt.Text != "")
            {
                int id = int.Parse(DriverIdTxt.Text);
                MessageBox.Show(client.startJourney(id));
            }
            else { MessageBox.Show("Driver Id requred"); }
        }

        private void endJBtn_Click(object sender, EventArgs e)
        {
           
            if (DriverIdTxt.Text != "")
            {
                int id = int.Parse(DriverIdTxt.Text);
                MessageBox.Show(client.endJourney(id));
            }
            else { MessageBox.Show("Driver Id requred"); }
        }
    }
}
