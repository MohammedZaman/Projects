using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace friendsWithPaws
{
    public partial class DeletePet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {

               petDD.DataSource = DBConnect.LoadPet();
                petDD.DataTextField = "PetName";
                petDD.DataValueField = "PetID";   //the name of the property that returns the ID
                petDD.DataBind();
                petDD.Items.Insert(0, new ListItem(text: String.Empty, value: String.Empty));
                petDD.SelectedIndex = 0;
            }

        }

        protected void submit_Click(object sender, EventArgs e)
        {

          
              
            string confirmValue = Request.Form["confirm_value"];
            if (confirmValue == "Yes")
            {
                string id = petDD.SelectedValue;
                DBConnect.removePet(id);
            }
            else
            {
                
            }


        }
    }
}