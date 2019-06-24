using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Systems_Development
{
    public partial class MakeReview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("LogIn.aspx");
            }

        }

        protected void reviewBtn_Click(object sender, EventArgs e)
        {
            DBController dbCon = DBController.getInstance;
            if (starsDropDown.SelectedIndex == 0)
            {
                Label1.Text = "*";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                
                string stars = starsDropDown.SelectedItem.ToString();
                string uName = (string)Session["username"].ToString();
                string reviewText = ReviewTxtBox.Text;
                dbCon.addReview(uName,stars,reviewText);
                Label2.Text = "Your has been submited successful";
                starsDropDown.SelectedIndex = 0;
                ReviewTxtBox.Text = "";

            }

            }
    }
}