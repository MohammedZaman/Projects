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
    public partial class addSpecies : System.Web.UI.Page
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
        }
        public DataTable DisplayRecord()
        {
            DataTable Dt = new DataTable();
            addSpeciesGrid.DataSource = DBConnect.LoadSpecies();
            addSpeciesGrid.DataBind();
            return Dt;
        
         }

        protected void submit_Click(object sender, EventArgs e)
        {
          

                String species = speciesTxtBox.Text;
            SqlCommand cmd = SQLCON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Species(Species) VALUES (@species)";
            cmd.Parameters.Add("@species", SqlDbType.NVarChar).Value = species;
            if (!DBConnect.LoadSpecies().Any(cus => cus.PetSpecie == species))
            {
                error.Text = "";


                try
                {
                    SQLCON.Open();
                    cmd.ExecuteNonQuery();
                    SQLCON.Close();
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
                    DisplayRecord();
                    //Page.Response.Redirect(Page.Request.Url.ToString(), true);
                }


                catch
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error Connection Failed')", true);
                }
            }
            else {
                error.Text = "Species Already Exists";

            }
        }

      
    }
}