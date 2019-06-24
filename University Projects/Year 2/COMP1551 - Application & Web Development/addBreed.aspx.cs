using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace friendsWithPaws
{
    public partial class addBreed : System.Web.UI.Page
    {
        SqlConnection SQLCON = new SqlConnection("server=sql-server;database=mz7340g;User ID=mz7340g;Password=Yahya123");
        protected void Page_Load(object sender, EventArgs e)
        {


            SQLCON.Open();
            if (!IsPostBack)
            {
                DisplayRecord();
            }
            SQLCON.Close();


            if (!Page.IsPostBack)
            {



                speciesDD.DataSource = DBConnect.LoadSpecies();
                speciesDD.DataTextField = "PetSpecie";
                speciesDD.DataValueField = "SpeciesID"; //the name of the property that returns the ID
                speciesDD.DataBind();
                speciesDD.Items.Insert(0, new ListItem(String.Empty, String.Empty));
                speciesDD.SelectedIndex = 0;

            }


        }

        protected void submit_Click(object sender, EventArgs e)
        {
            String species = speciesDD.SelectedValue;
            String breed = breedTxtBox.Text;
            if (!DBConnect.LoadALLBreed().Any(cus => cus.breed == breed))
            {
                try
                {
                    Double foodCost = Double.Parse(foodCostTxtBox.Text);
                    Double housingCost = Double.Parse(housingCostTxtBox.Text);
                    error.Text = "";
                    DBConnect.addBreed(species, breed, foodCost, housingCost);
                }
                catch
                {
                    error.Text = "Input Error";
                }
            }
            else {
                error.Text = "Breed already exists";
            }
        }
       
        public DataTable DisplayRecord()
        {
        
            DataTable Dt = new DataTable();
            addBreedGrid.DataSource = DBConnect.LoadALLBreed();
            addBreedGrid.DataBind();
            return Dt;

        }
    }
    }
