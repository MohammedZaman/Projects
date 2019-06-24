using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TaxiDriverSystem.Components
{
    public partial class PhoneBox : UserControl
    {
        public PhoneBox()
        {
            InitializeComponent();
           
        }

        private void phoneTxtBox_TextChanged(object sender, EventArgs e)
        {

            char[] characters = phoneTxtBox.Text.ToCharArray();
            if (characters.Length > 13)
            {

                phoneTxtBox.BackColor = Color.Red;

            }
            else
            {
                phoneTxtBox.BackColor = Color.White;
            }
           
        

         


        }



      



        private void PhoneBox_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;

        }

        private void phoneTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;


            char[] characters = phoneTxtBox.Text.ToCharArray();
            if (Char.IsDigit(e.KeyChar)) {
                if (characters.Length == 4)
                {
                    phoneTxtBox.AppendText("-");
                }
                if (characters.Length == 8)
                {
                    phoneTxtBox.AppendText("-");
                }
            }else if((e.KeyChar == (char)Keys.Back)){

            }
        }

    }
    }
    

