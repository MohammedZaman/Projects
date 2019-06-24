using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace friendsWithPaws
{
    public partial class WebForm2 : Page
    {

        /*
         SELECT * 
  FROM AddPet
  JOIN Vet_bills
  ON AddPet.ID = Vet_bills.VetID; 


        */
        SqlConnection SQLCON = new SqlConnection("server=sql-server;database=mz7340g;User ID=mz7340g;Password=Yahya123");
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void search_Click(object sender, EventArgs e)
        {
            if (searchDropDown.Text.Equals(""))
            {
                checkSearch.Text = "Select Option from DropDown";
            }
            else if (searchDropDown.Text.Equals("Breed"))
            {
                String input = petInput.Text;
                CreateContent("SELECT Pet.PetID,Pet.PetImage,Pet.PetName,Pet.Gender,Pet.Country,Breed.Breed,Pet.PetWeight,Pet.DateWhenRescued,Pet.AgeWhenRescued,breed.BreedID FROM Pet JOIN Breed ON Pet.BreedID = Breed.BreedID where Breed ='" + input + "'");
                checkSearch.Text = "";
            }

            else if (searchDropDown.Text.Equals("Country"))
            {
                String input = petInput.Text;
                CreateContent("SELECT Pet.PetID,Pet.PetImage,Pet.PetName,Pet.Gender,Pet.Country,Breed.Breed,Pet.PetWeight,Pet.DateWhenRescued,Pet.AgeWhenRescued,breed.BreedID FROM Pet JOIN Breed ON Pet.BreedID = Breed.BreedID where Country ='" + input + "'");
                checkSearch.Text = "";
            }
            else if (searchDropDown.Text.Equals("Species"))
            {
                String input = petInput.Text;
                CreateContent("SELECT Pet.PetID,Pet.PetImage,Pet.PetName,Pet.Gender,Pet.Country,Breed.Breed,Pet.PetWeight,Pet.DateWhenRescued,Pet.AgeWhenRescued,breed.BreedID FROM Pet JOIN Breed ON Pet.BreedID = Breed.BreedID Join Species ON Breed.SpeciesID = Species.SpeciesID where Species ='" + input + "'");
                checkSearch.Text = "";
            }




        }
        



        public void CreateContent(String sqlQuery)
        {
            SqlConnection SQLCON = new SqlConnection("server=sql-server;database=mz7340g;User ID=mz7340g;Password=Yahya123");
            SQLCON.Open();
            using (SqlCommand command = new SqlCommand(sqlQuery, SQLCON))
            using (SqlDataReader reader = command.ExecuteReader())

            {

                if (!reader.HasRows)
                {
                    checkSearch.Text = "no record found";
                }
                else
                {
                    while (reader.Read())
                    {





                        System.Web.UI.HtmlControls.HtmlGenericControl createDiv =
            new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                        createDiv.ID = "createDiv";
                        createDiv.Attributes["class"] = "petdiv";
                        content.Controls.Add(createDiv);
                        int idBefore = reader.GetInt32(0);
                        string id = Convert.ToString(idBefore);
                        createDiv.Style.Add(HtmlTextWriterStyle.MarginBottom, "15px");








                        System.Web.UI.HtmlControls.HtmlGenericControl petImage =
        new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                        petImage.ID = "innerDiv";
                        createDiv.Controls.Add(petImage);
                     



                        petImage.Attributes["class"] = "petImageItem";
                        petImage.Style.Add(HtmlTextWriterStyle.Padding, "60px 120px");
                        // use this to check if data is null 
                        if (reader["PetImage"] != DBNull.Value)
                        {

                            System.Web.UI.WebControls.Image img = new System.Web.UI.WebControls.Image();
                            img.ImageUrl = "getImage.ashx?id=" + id;
                            petImage.Controls.Add(img);
                            img.Style.Add(HtmlTextWriterStyle.Width, "150px");
                            img.Style.Add(HtmlTextWriterStyle.Height, "150px");


                        }
                        else
                        {
                            System.Web.UI.WebControls.Image img = new System.Web.UI.WebControls.Image();
                            img.ImageUrl = "img/defualt.jpg";
                            petImage.Controls.Add(img);
                            img.Style.Add(HtmlTextWriterStyle.Width, "150x");
                            img.Style.Add(HtmlTextWriterStyle.Height, "150px");
                        }





                        if (reader["PetName"] != DBNull.Value)
                        {
                            System.Web.UI.HtmlControls.HtmlGenericControl innerDiv =
                            new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                            innerDiv.ID = "innerDiv";
                            createDiv.Controls.Add(innerDiv);
                            innerDiv.Attributes["class"] = "petdivItems";
                            innerDiv.InnerHtml = "Pet Name: " + reader.GetString(2);

                        }
                        else
                        {
                            System.Web.UI.HtmlControls.HtmlGenericControl innerDiv =
                            new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                            innerDiv.ID = "innerDiv";
                            createDiv.Controls.Add(innerDiv);
                            innerDiv.Attributes["class"] = "petdivItems";
                            innerDiv.InnerHtml = "Pet Name: " + "Undefined";
                        }


                        if (reader["Gender"] != DBNull.Value)
                        {
                            System.Web.UI.HtmlControls.HtmlGenericControl innerDiv2 =
                            new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                            innerDiv2.ID = "innerDiv2";
                            createDiv.Controls.Add(innerDiv2);
                            innerDiv2.InnerHtml = "Gender: " + reader.GetString(3);
                            innerDiv2.Attributes["class"] = "petdivItems";
                        }
                        else
                        {
                            System.Web.UI.HtmlControls.HtmlGenericControl innerDiv2 =
                            new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                            innerDiv2.ID = "innerDiv2";
                            createDiv.Controls.Add(innerDiv2);
                            innerDiv2.InnerHtml = "Gender: " + "Undefined";
                            innerDiv2.Attributes["class"] = "petdivItems";

                        }


                        if (reader["Country"] != DBNull.Value)
                        {

                            System.Web.UI.HtmlControls.HtmlGenericControl innerDiv3 =
    new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                            innerDiv3.ID = "innerDiv3";
                            createDiv.Controls.Add(innerDiv3);
                            innerDiv3.InnerHtml = "Country: " + reader.GetString(4);
                            innerDiv3.Attributes["class"] = "petdivItems";
                        }
                        else
                        {

                            System.Web.UI.HtmlControls.HtmlGenericControl innerDiv3 =
                              new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                            innerDiv3.ID = "innerDiv3";
                            createDiv.Controls.Add(innerDiv3);
                            innerDiv3.InnerHtml = "Country: " + "Undefined";
                            innerDiv3.Attributes["class"] = "petdivItems";


                        }


                        if (reader["Breed"] != DBNull.Value)
                        {

                            System.Web.UI.HtmlControls.HtmlGenericControl innerDivC =
                            new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                            innerDivC.ID = "innerDivC";
                            createDiv.Controls.Add(innerDivC);
                            innerDivC.InnerHtml = "Breed: " + reader.GetString(5);
                            innerDivC.Attributes["class"] = "petdivItems";
                        }
                        else
                        {
                            System.Web.UI.HtmlControls.HtmlGenericControl innerDivC =
                            new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                            innerDivC.ID = "innerDivC";
                            createDiv.Controls.Add(innerDivC);
                            innerDivC.InnerHtml = "Breed: " + "Undefined";
                            innerDivC.Attributes["class"] = "petdivItems";


                        }



                        if (reader["PetWeight"] != DBNull.Value)
                        {
                            System.Web.UI.HtmlControls.HtmlGenericControl innerDiv4 =
                            new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                            innerDiv4.ID = "innerDiv4";
                            createDiv.Controls.Add(innerDiv4);
                            innerDiv4.InnerHtml = "Pet Weight: " + Convert.ToString(reader.GetDecimal(6));
                            innerDiv4.Attributes["class"] = "petdivItems";
                        }
                        else
                        {
                            System.Web.UI.HtmlControls.HtmlGenericControl innerDiv4 =
                            new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                            innerDiv4.ID = "innerDiv4";
                            createDiv.Controls.Add(innerDiv4);
                            innerDiv4.InnerHtml = "Pet Weight: " + "Undefined";
                            innerDiv4.Attributes["class"] = "petdivItems";
                        }

                        if (reader["DateWhenRescued"] != DBNull.Value)
                        {

                            System.Web.UI.HtmlControls.HtmlGenericControl innerDiv5 =
                            new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                            innerDiv5.ID = "innerDiv5";
                            createDiv.Controls.Add(innerDiv5);
                            innerDiv5.InnerHtml = "Date When Rescued: " + Convert.ToString(reader.GetDateTime(7));
                            innerDiv5.Attributes["class"] = "petdivItems";
                        }
                        else
                        {
                            System.Web.UI.HtmlControls.HtmlGenericControl innerDiv5 =
                            new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                            innerDiv5.ID = "innerDiv5";
                            createDiv.Controls.Add(innerDiv5);
                            innerDiv5.InnerHtml = "Date When Rescued: " + "Undefined";
                            innerDiv5.Attributes["class"] = "petdivItems";

                        }

                        if (reader["AgeWhenRescued"] != DBNull.Value)
                        {
                            System.Web.UI.HtmlControls.HtmlGenericControl innerDiv6 =
                            new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                            innerDiv6.ID = "innerDiv6";
                            createDiv.Controls.Add(innerDiv6);
                            innerDiv6.InnerHtml = "Age When Rescued " + Convert.ToString(reader.GetInt32(8));
                            innerDiv6.Attributes["class"] = "petdivItems";
                        }
                        else
                        {
                            System.Web.UI.HtmlControls.HtmlGenericControl innerDiv6 =
                            new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                            innerDiv6.ID = "innerDiv6";
                            createDiv.Controls.Add(innerDiv6);
                            innerDiv6.InnerHtml = "Pet Age " + "Undefined";
                            innerDiv6.Attributes["class"] = "petdivItems";

                        }

                    }


                }












            }
            SQLCON.Close();
        }

        protected void showAll_Click(object sender, EventArgs e)
        {
            CreateContent("SELECT Pet.PetID,Pet.PetImage,Pet.PetName,Pet.Gender,Pet.Country,Breed.Breed,Pet.PetWeight,Pet.DateWhenRescued,Pet.AgeWhenRescued,breed.BreedID FROM Pet JOIN Breed ON Pet.BreedID = Breed.BreedID Join Species ON Breed.SpeciesID = Species.SpeciesID");
            checkSearch.Text = "";

        }
    }
    
        }

   

  
