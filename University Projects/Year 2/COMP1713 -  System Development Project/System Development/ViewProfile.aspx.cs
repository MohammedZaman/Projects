using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Systems_Development
{
    public partial class ViewProfile : System.Web.UI.Page
    {

        DBController dbCon = DBController.getInstance;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["username"] == null)
            {
                Response.Redirect("LogIn.aspx");
            }
            else
            {

               
                string uid = Session["username"].ToString();
                List<Objects.Customer> customer = dbCon.getCustomeDetails(uid);
                uNameTxtBox.Text = customer[0].Uname;
                passwordTxtBox.Text = customer[0].Password;
                fNameTxt.Text = customer[0].FName;
                lNameTxt.Text = customer[0].LName;
                emailTxt.Text = customer[0].EMail;
                mobileTxt.Text = customer[0].MobNum;

                List<Objects.Address> address = dbCon.getCustomerAddress(uid);
                address1Txt.Text = address[0].Address1;
                address2Txt.Text = address[0].Address2;
                cityTxt.Text = address[0].City;
                postCodeTxt.Text = address[0].PostCode;

                List <Objects.Card> card = dbCon.getCustomerCard(uid);
                nocTxt.Text = card[0].NameOnCard;
                cardNumTxt.Text = card[0].CardNumber;
                expiaryTxt.Text = card[0].ExpirationDate;
                cvcTxt.Text = card[0].Cvc;
                

        







            }

        }

        protected void delAccount_Click(object sender, EventArgs e)
        {
            string uid = Session["username"].ToString();
            dbCon.deleteAccount(uid);
            Session.Remove("username");
            Response.Redirect("Defualt.aspx");


        }
    }
}