using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Systems_Development
{
    public partial class MakeEnquiry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("LogIn.aspx");
            }

        }

        protected void enquiryBtn_Click(object sender, EventArgs e)
        {
            DBController dbCon = DBController.getInstance;
            if (SubDropDown.SelectedIndex == 0)
            {
                Label1.Text = "*";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else {
                string date = DateTime.Now.ToString();
                string subject = SubDropDown.SelectedItem.ToString();
                string uName = (string)Session["username"].ToString();
                string enquiryText = enquiryTxtBox.Text;

               
                dbCon.addEquiry(date,subject,uName,enquiryText,"False");
                Label2.Text = "Your Enquiry has been successful";
                SubDropDown.SelectedIndex = 0;
                enquiryTxtBox.Text = "";

            }

        }
    }
}