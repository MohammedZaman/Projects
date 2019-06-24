using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Systems_Development
{
    public sealed class DBController
    {
        private static DBController instance = null;

        private DBController()
        {
        }

        public static DBController getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBController();
                }
                return instance;
            }
        }




        public static System.Data.SqlClient.SqlConnection GetConnection()
        {
            string connString;
            //  change to your connection string in the following line
            connString = "server=sql-server ;database=aa4692t; uid=aa4692t; password=!1SQLServer;";
            return new System.Data.SqlClient.SqlConnection(connString);
        }



        // Insert data into the customerProfile table 
        public void addProfile(string uName, string password, string fName, string lName, string eMail, string mobNum)
        {
            SqlConnection myConnection = GetConnection();
            string myQuery = "Insert into CustomerProfile(CustomerUserName,CustomerPassword,CustomerFname,CustomerLname,CustomerEmail,MobileNum) VALUES ('" + uName + "','" + password + "', '" + fName + "' ,'" + lName + "','" + eMail + "','" + mobNum + "')";
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

        // insert data into the address table in the sql database 
        public void addAddress(string CUserName, string address1, string address2, string city, string postcode)
        {
            SqlConnection myConnection = GetConnection();
            string myQuery = "Insert into Address(CustomerUserName,Address1,Address2,City,Postcode) VALUES ('" + CUserName + "','" + address1 + "', '" + address2 + "' ,'" + city + "','" + postcode + "')";
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

        public Boolean CheckLog(string uName, string pass)
        {

            SqlConnection myConnection = GetConnection();

            myConnection.Open();
            string qry = "select * from CustomerProfile where CustomerUserName='" + uName + "' and CustomerPassword ='" + pass + "'";
            SqlCommand cmd = new SqlCommand(qry, myConnection);
            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {
                return true;

            }
            else
            {

                return false;

            }





        }
        // add data to card table in sql database 
        public void AddCard(string CUserName, string nameOnCard, string Cardnumber, string expirationDate, string cvc)
        {
            SqlConnection myConnection = GetConnection();
            string myQuery = "Insert into Card(CustomerUsername,NameOnCard,CardNumber,ExpirationDate,cvc) VALUES ('" + CUserName + "','" + nameOnCard + "', '" + Cardnumber + "' ,'" + expirationDate + "','" + cvc + "')";
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

        public void AddReceipt(string CUserName, string date, string receiptText, double miles, double cost)
        {
            SqlConnection myConnection = GetConnection();
            string myQuery = "Insert into Receipt(CustomerUsername,date,ReceiptText,Miles,Cost) VALUES ('" + CUserName + "','" + date + "', '" + receiptText + "' ,'" + miles.ToString() + "','" + cost.ToString() + "')";
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
        public void addBooking(string cUsername, string vehicle, string des, string pickup)
        {
            SqlConnection myConnection = GetConnection();
            string myQuery = "Insert into Booking(customerUsername,vehicle,destination,pickup) VALUES ('" + cUsername + "','" + vehicle + "', '" + des + "' ,'" + pickup + "')";
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

        public void addEquiry(string date, string subject, string CustomerUserName, string enquiryText, string answ)
        {
            SqlConnection myConnection = GetConnection();
            string myQuery = "Insert into Equiry(DateOFEnquiry,subjectOfEnquiry,CustomerUserName,EnquiryText,answered) VALUES ('" + date + "','" + subject + "', '" + CustomerUserName + "' ,'" + enquiryText + "','" + answ + "')";
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




        public void addCustomerProfile(string uName, string pass, string fName, string lName, string email, string mobNum, string add1, string add2, string city, string postCode, string nameOnCard, string cardNum, string expi, string cvc)
        {

            addProfile(uName, pass, fName, lName, email, mobNum);
            addAddress(uName, add1, add2, city, postCode);
            AddCard(uName, nameOnCard, cardNum, expi, cvc);

        }

        public void addReview(string userName, string stars, string reviewText)
        {
            SqlConnection myConnection = GetConnection();
            string myQuery = "Insert into Review(CustomerUserName,Stars,ReviewText) VALUES ('" + userName + "','" + stars + "', '" + reviewText + "')";
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

        public List<Objects.Review> getAllReviews()
        {



            List<Objects.Review> receipts = new List<Objects.Review>();

            SqlConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM Review ";
            SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
            try
            {

                myConnection.Open();
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Objects.Review b = new Objects.Review(myReader["CustomerUserName"].ToString(), myReader["Stars"].ToString(), myReader["ReviewText"].ToString());
                    receipts.Add(b);

                }
                return receipts;
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

        public List<Objects.Receipt> getAllReceipt(string CustomerUserName)
        {



            List<Objects.Receipt> receipts = new List<Objects.Receipt>();

            SqlConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM Receipt where CustomerUserName = '" + CustomerUserName + "'";
            SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
            try
            {

                myConnection.Open();
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Objects.Receipt b = new Objects.Receipt(myReader["ReceiptText"].ToString(), double.Parse(myReader["Miles"].ToString()), double.Parse(myReader["Cost"].ToString()), myReader["date"].ToString());
                    receipts.Add(b);

                }
                return receipts;
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



        public List<Objects.Customer> getAllCustomers()
        {



            List<Objects.Customer> customers = new List<Objects.Customer>();

            SqlConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM CustomerProfile ";
            SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
            try
            {

                myConnection.Open();
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Objects.Customer b = new Objects.Customer(myReader["CustomerUserName"].ToString(), null, myReader["CustomerFname"].ToString(), myReader["CustomerLname"].ToString(), myReader["CustomerEmail"].ToString(), myReader["MobileNum"].ToString(), "Customer");
                    customers.Add(b);

                }
                return customers;
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

        public List<Objects.Customer> getCustomeDetails(string CustomerUserName)
        {



            List<Objects.Customer> customers = new List<Objects.Customer>();

            SqlConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM CustomerProfile where CustomerUserName = '" + CustomerUserName + "' ";
            SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
            try
            {

                myConnection.Open();
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Objects.Customer b = new Objects.Customer(myReader["CustomerUserName"].ToString(), myReader["CustomerPassword"].ToString(), myReader["CustomerFname"].ToString(), myReader["CustomerLname"].ToString(), myReader["CustomerEmail"].ToString(), myReader["MobileNum"].ToString(), "Customer");
                    customers.Add(b);

                }
                return customers;
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


        public List<Objects.Address> getCustomerAddress(string CustomerUserName)
        {




            List<Objects.Address> address = new List<Objects.Address>();

            SqlConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM Address where CustomerUserName = '" + CustomerUserName + "' ";
            SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
            try
            {

                myConnection.Open();
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Objects.Address b = new Objects.Address(int.Parse(myReader["AddressID"].ToString()), myReader["CustomerUserName"].ToString(), myReader["Address1"].ToString(), myReader["Address2"].ToString(), myReader["City"].ToString(), myReader["Postcode"].ToString());
                    address.Add(b);

                }
                return address;
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

        public List<Objects.Card> getCustomerCard(string CustomerUserName)
        {




            List<Objects.Card> card = new List<Objects.Card>();

            SqlConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM Card where CustomerUserName = '" + CustomerUserName + "' ";
            SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
            try
            {

                myConnection.Open();
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Objects.Card b = new Objects.Card(int.Parse(myReader["CardID"].ToString()), myReader["CustomerUserName"].ToString(), myReader["NameOnCard"].ToString(), myReader["CardNumber"].ToString(), myReader["ExpirationDate"].ToString(), myReader["cvc"].ToString());
                    card.Add(b);

                }
                return card;
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

        public void deleteAccount(string id) {
            deleteProfile(id);
            deleteAddress(id);
            deleteCard(id);
           
        }

        public void deleteProfile(string id) {
            SqlConnection myConnection = GetConnection();
            string myQuery = " DELETE FROM CustomerProfile where CustomerUserName ='" + id + "'";
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

        public void deleteAddress(string id)
        {
            SqlConnection myConnection = GetConnection();
            string myQuery = " DELETE FROM Address where CustomerUserName ='" + id + "'";
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

        public void deleteCard(string id)
        {
            SqlConnection myConnection = GetConnection();
            string myQuery = " DELETE FROM Card where CustomerUserName ='" + id + "'";
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