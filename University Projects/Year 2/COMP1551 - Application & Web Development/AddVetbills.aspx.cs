using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace friendsWithPaws
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            if (!Page.IsPostBack)
            {

                petList.DataSource = DBConnect.LoadPet();
                petList.DataTextField = "PetName";
                petList.DataValueField = "PetID";   //the name of the property that returns the ID
                petList.DataBind();
                petList.Items.Insert(0, new ListItem(text: String.Empty, value: String.Empty));
                petList.SelectedIndex = 0;
            }
           
        }

        protected void submit_Click(object sender, EventArgs e)
        {


            String petID = petList.SelectedValue;


            if (!petList.SelectedItem.ToString().Equals(""))
            {
                if (!DBConnect.LoadVetBills().Any(cus => cus.PetID1 == int.Parse(petID)))
                {
                    error.Text = "";
                    try
                    {
                        double vaccines = double.Parse(vaccinesTxtBox.Text);
                        double nProcedures = double.Parse(n_ProcceduresTxtBox.Text);
                        double idChip = double.Parse(id_chippingTxtBox.Text);
                        double flea_spraying = double.Parse(flea_SprayingTxtBox.Text);
                        double wormingPills = double.Parse(wormingPillsTxtBox.Text);
                        DBConnect.addVetBills(petID, vaccines, nProcedures, idChip, flea_spraying, wormingPills);
                        success.Text = "Record Added Successfly";
                    }
                    catch
                    {
                        success.Text = "Input Error";
                    }
                }
                else
                {
                    error.Text = "This Pet has vet bills assigned to it already";
                }
            }
        }
        }
    }
    
