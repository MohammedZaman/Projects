using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace friendsWithPaws
{
    public class DBConnect
    {
        private static System.Data.SqlClient.SqlConnection GetConnection()
        {
            string connString;
            //  change to your connection string in the following line
            connString = ConfigurationManager.ConnectionStrings["mz7340g"].ConnectionString; 
            return new System.Data.SqlClient.SqlConnection(connString);
        }


        public Pet GetPet() {
        }

        public static List<Breed> LoadALLBreed()
        {
         


            List<Breed> Allbreed = new List<Breed>();
            SqlConnection myConnection = GetConnection();


            string myQuery = "SELECT * FROM Breed ";
            SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

            try
            {

                myConnection.Open();
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Breed b = new Breed(int.Parse(myReader["BreedID"].ToString()), myReader["Breed"].ToString(), double.Parse(myReader["FoodCostPerKG"].ToString()), double.Parse(myReader["HousingCosts"].ToString()));
                    Allbreed.Add(b);

                }
                return Allbreed;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }



        public static List<Breed> LoadBreed(String Species)
        {
            if (string.IsNullOrEmpty(Species))
            {
                throw new ArgumentException("message", nameof(Species));
            }

            List<Breed> breed = new List<Breed>();
            SqlConnection myConnection = GetConnection();


            string myQuery = "SELECT * FROM Breed where SpeciesID = " + Species;
            SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

            try
            {

                myConnection.Open();
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Breed b = new Breed(int.Parse(myReader["BreedID"].ToString()), myReader["Breed"].ToString(), double.Parse(myReader["FoodCostPerKG"].ToString()), double.Parse(myReader["HousingCosts"].ToString()));
                    breed.Add(b);

                }
                return breed;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static List<Species> LoadSpecies()
        {
            List<Species> Species = new List<Species>();
            SqlConnection myConnection = GetConnection();

            string myQuery = "SELECT * FROM Species";
            SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Species s = new Species(int.Parse(myReader["SpeciesID"].ToString()), myReader["Species"].ToString());
                    Species.Add(s);
                }
                return Species;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }





        public static void addPet(byte[] img, string petName, string gender, string country, String breed, double weight, string date, int age)
        {
            SqlConnection myConnection = GetConnection();
            string myQuery = "Insert into Pet(PetImage,PetName,Gender,Country,BreedID,PetWeight,DateWhenRescued,AgeWhenRescued) VALUES (@img,'" + petName + "','" + gender + "','" + country + "','" + breed + "','" + weight + "','" + date + "','" + age + "')";
            SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
            myCommand.Parameters.Add("@img", SqlDbType.VarBinary).Value = img;


            myConnection.Open();
            myCommand.ExecuteNonQuery();



        }



        public static void addBreed(String species, string breed, double foodCostPerKg, double HousingCosts)
        {
            SqlConnection myConnection = GetConnection();
            string myQuery = "Insert into Breed(SpeciesID,Breed,FoodCostPerKG,HousingCosts) VALUES ('" + species + "','" + breed + "', '" + foodCostPerKg + "' ,'" + HousingCosts + "')";
            SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);

            }
            finally
            {
                myConnection.Close();
            }
        }



        public static void addVetBills(String petID, double neutering_Procedures, double Vaccines, double Id_chipping, double Flea_Spraying, double Worming_Pills)
        {
            SqlConnection myConnection = GetConnection();
            string myQuery = "Insert into Vetbill(PetID,Vaccines,Neutering_Procedures,Id_chipping,Flea_Spraying,Worming_Pills) VALUES ('" + petID + "','" + Vaccines + "','" + neutering_Procedures + "', '" + Id_chipping + "' ,'" + Flea_Spraying + "','" + Worming_Pills + "')";
            SqlCommand myCommand = new SqlCommand(myQuery, myConnection);


            myConnection.Open();
            myCommand.ExecuteNonQuery();
        }

        public static List<Pet> LoadPet()
        {
            
                List<Pet> pet= new List<Pet>();
                SqlConnection myConnection = GetConnection();

                string myQuery = "SELECT * FROM Pet";
                SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

                try
                {
                    myConnection.Open();
                    SqlDataReader myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        Pet s = new Pet(int.Parse(myReader["PetID"].ToString()), myReader["PetName"].ToString());
                        pet.Add(s);
                    }
                    return pet;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception in DBHandler", ex);
                    return null;
                }
                finally
                {
                    myConnection.Close();
                }
        }

        public static List<Objects.VetBill> LoadVetBills()
        {

            List<Objects.VetBill> vetbill = new List<Objects.VetBill>();
            SqlConnection myConnection = GetConnection();

            string myQuery = "SELECT VetBill.PetID ,Pet.PetName,Breed.HousingCosts,Breed.FoodCostPerKG,Pet.PetWeight,Vetbill.Vaccines,Vetbill.Neutering_Procedures,Vetbill.Id_Chipping,Vetbill.Flea_Spraying,Vetbill.Worming_Pills FROM Pet JOIN Vetbill ON Pet.PetID = Vetbill.PetID JOIN Breed ON Pet.BreedID = Breed.BreedID; ";
            SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    int petid = int.Parse(myReader["PetID"].ToString());
                    String petName = myReader["PetName"].ToString();
                    Double HC = double.Parse(myReader["HousingCosts"].ToString());
                    Double foodCostPerKG = double.Parse(myReader["FoodCostPerKG"].ToString());
                    Double PetWeight  = double.Parse(myReader["PetWeight"].ToString());
                    Double Vac = double.Parse(myReader["Vaccines"].ToString());
                    Double Np = double.Parse(myReader["Neutering_Procedures"].ToString());
                    Double id_Chip = double.Parse(myReader["Id_Chipping"].ToString());
                    Double Flea_Spray = double.Parse(myReader["Flea_Spraying"].ToString());
                    Double Worm_Pills = double.Parse(myReader["Flea_Spraying"].ToString());
                    Double total = foodCostPerKG * PetWeight + HC + Vac + Np + id_Chip + Flea_Spray + Worm_Pills;

                    Objects.VetBill vb = new Objects.VetBill(petid,petName,HC,foodCostPerKG,PetWeight,Vac,Np,id_Chip,Flea_Spray,Worm_Pills,total);
                    vetbill.Add(vb);
                }
                return vetbill;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }


        public static void removePet(string id )
        {
            SqlConnection myConnection = GetConnection();
            string myQuery =" DELETE FROM Pet WHERE PetID ='" + id + "'";
            SqlCommand myCommand = new SqlCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);

            }
            finally
            {
                myConnection.Close();
            }
        }
    }
}


    

