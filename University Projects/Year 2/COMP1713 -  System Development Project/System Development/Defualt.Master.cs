using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Systems_Development
{
    public partial class Defualt : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["username"] != null)
            {
                signInState.InnerText = "" + Session["username"];
                lO.Style.Add("display", "block");
                profile.Style.Add("display", "block");
                signIn.Style.Add("display", "none");
                signUp.Style.Add("display", "none");
                content.Style.Add("display", "block");

            }

        }


        protected void logOut(object sender, EventArgs e)
        {
            Session.Remove("username");
            Response.Redirect("Defualt.aspx");
        }

        public void account(object sender, EventArgs e) {
            Response.Redirect("ViewProfile.aspx");
        }
    }
}