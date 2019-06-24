using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Globalization;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;

namespace friendsWithPaws
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection SQLCON = new SqlConnection("server=sql-server;database=mz7340g;User ID=mz7340g;Password=Yahya123");


        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {



                SpeciesList.DataSource = DBConnect.LoadSpecies();
                SpeciesList.DataTextField = "PetSpecie";
                SpeciesList.DataValueField = "SpeciesID"; //the name of the property that returns the ID
                SpeciesList.DataBind();
                SpeciesList.Items.Insert(0, new ListItem(String.Empty, String.Empty));
                SpeciesList.SelectedIndex = 0;

            }


        }

    







       

        protected void submit_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile == true)
            {
                string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
                string uploadName = Path.GetFullPath(FileUpload1.PostedFile.FileName);
                //Save files to images folder
                FileUpload1.SaveAs(Server.MapPath("~/img/" + fileName));
            }




            int img = FileUpload1.PostedFile.ContentLength;

            byte[] msdata = new byte[img];

            FileUpload1.PostedFile.InputStream.Read(msdata, 0, img);

            if (genderDropDown.Text.Equals(""))
            {
                valid.Text = "Fill in the required fields";
            }
            else if (breedDropDown.Equals(""))
            {
                valid.Text = "Fill in the required fields ";

            }
            else if (countryDD.Text.Equals(""))
            {
                valid.Text = "Fill in the required fields ";
            }
            else
            {



                try
                {
                   

                    String breedId = breedDropDown.SelectedValue;
                    String name = nameTxtBox.Text;
                    String gender = genderDropDown.SelectedItem.Text;
                    String country = countryDD.SelectedItem.Text;

                    double petWeight = double.Parse(weightTxtBox.Text);
                    String dateWhenRescued = dateWhenRescuedTxtBox.Text.ToString();
                    int ageWhenRescued = int.Parse(ageWhenRescuedTxtBox.Text);





                    SqlCommand cmd = new SqlCommand("insert into Pet(PetImage,PetName,Gender,Country,BreedID,PetWeight,DateWhenRescued,AgeWhenRescued) values(@image,@Name,@Gender,@country,@breed,@PetWeight,@dateWhenRescued,@ageWhenRescued)", SQLCON);
                    cmd.Parameters.Add("@image", SqlDbType.Image).Value = msdata;
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = gender;
                    cmd.Parameters.Add("@country", SqlDbType.VarChar).Value = country;
                    cmd.Parameters.Add("@breed", SqlDbType.VarChar).Value = breedId;
                    cmd.Parameters.Add("@PetWeight", SqlDbType.Decimal).Value = petWeight;
                    cmd.Parameters.Add("@dateWhenRescued", SqlDbType.Date).Value = dateWhenRescued;
                    cmd.Parameters.Add("@ageWhenRescued", SqlDbType.Int).Value = ageWhenRescued;



                    if (SQLCON.State == ConnectionState.Closed)
                    {
                        SQLCON.Open();
                    }
                    cmd.ExecuteNonQuery();
                    SQLCON.Close();
                    valid.Text = "Record Added ";

                }
                catch {
                    valid.Text = "connection Error ";
                }

            }


            /*

            if (FileUpload1.PostedFile != null)
            {
                string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
                string uploadName = Path.GetFullPath(FileUpload1.PostedFile.FileName);
                //Save files to images folder
                FileUpload1.SaveAs(Server.MapPath("~/img/" + fileName));
                this.petImage.ImageUrl = "img/" + fileName;


            }

            SqlCommand cmd = new SqlCommand("insert into Pet(PetImage,PetName,Gender,Country,BreedID) values(@image,@Name,@Gender,@country,@breed)", SQLCON);
 
    
            int img = FileUpload1.PostedFile.ContentLength;

            byte[] msdata = new byte[img];

            FileUpload1.PostedFile.InputStream.Read(msdata, 0, img);

            cmd.Parameters.AddWithValue("@image", msdata);

            if (SQLCON.State == ConnectionState.Closed)
            {
                SQLCON.Open();
            }
            cmd.ExecuteNonQuery();
            SQLCON.Close();



*/


            /*


            if (weightTxtBox.Equals("") || ageWhenRescuedTxtBox.Text.Equals(""))
            {
                valid.Text = "Fill in the required fields";
            }
            else
            {
                checkTxtBox();

                

                
                
            }
            */
        }


        protected void SpeciesList_SelectedIndexChanged(object sender, EventArgs e)

        {
            String species = SpeciesList.SelectedValue;
            breedDropDown.DataSource = DBConnect.LoadBreed(species);
            breedDropDown.DataTextField = "Breed";
            breedDropDown.DataValueField = "BreedId"; //the name of the property that returns the ID
            breedDropDown.DataBind();
       
        }
    }
}































