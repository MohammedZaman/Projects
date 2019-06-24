using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Systems_Development
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignUpBtn_Click(object sender, EventArgs e)
        {
            
            createProfile();

        }

        public void createProfile() {

            try {
            //profile
            string uName = uNameTxtBox.Text;
            string pass = passwordTxtBox.Text;
            string fName = fNameTxt.Text;
            string lName = lNameTxt.Text;
            string email = emailTxt.Text;
            string mobNum = mobileTxt.Text;
            //address
            string add1 = address1Txt.Text;
            string add2 = address2Txt.Text;
            string city = cityTxt.Text;
            string postCode = postCodeTxt.Text;
            //card
            string nameOnCard = nocTxt.Text;
            string cardNum = cardNumTxt.Text;
            string expi = mounthDD.Text + "/" + yearDD.Text;
            string cvc = cvcTxt.Text;
                DBController dbCon = DBController.getInstance;
                if (!dbCon.getAllCustomers().Any(cus => cus.Uname.Equals(uName)))
                {

                    dbCon.addCustomerProfile(uName, pass, fName, lName, email, mobNum, add1, add2, city, postCode, nameOnCard, cardNum, expi, cvc);
                    Session["username"] = uName;
                    Response.Redirect("Defualt.aspx");
                }
                else {
                    ClientScript.RegisterStartupScript(this.GetType(), "User Name", "alert('The User Name Already Exists');", true);
                    
                }
            }
            catch
            {
                Console.WriteLine("Exception in DBHandler");
            }
        }
    }
}