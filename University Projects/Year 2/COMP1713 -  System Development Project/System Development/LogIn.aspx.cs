using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Systems_Development
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void logInBtn_Click(object sender, EventArgs e)
        {
            checkLogIn();
          
        }

        public void checkLogIn() {

       
            string uid = uNameTxtBox.Text;
            string pass = passwordTxtBox.Text;
            Boolean logInsate = DBController.getInstance.CheckLog(uid, pass);
            if (logInsate == true)
            {
             Session["username"] = uid;
             Response.Redirect("Defualt.aspx");
            }
            else if (logInsate == false)
            {
             Label1.Text = "User Name or Password Is not correct Try again..!!";
            }
        }
    }
}