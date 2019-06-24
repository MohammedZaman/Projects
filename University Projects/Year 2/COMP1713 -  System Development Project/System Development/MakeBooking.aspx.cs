using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Systems_Development
{
    public partial class MakeBooking : System.Web.UI.Page, Discount
    {
        public string pickUp;
        public string dropOff;
        public string vehicle;
        public string uName;
        public double miles;
        public double cost;
     
        DBController dbCon = DBController.getInstance;
        protected void Page_Load(object sender, EventArgs e)
        {


            if (Session["username"] == null)
            {
                Response.Redirect("LogIn.aspx");
            }


        }

        protected void MakeBookingBtn_Click(object sender, EventArgs e)
        {
            pickUp = Page.Request.Form["pick-up"].ToString();
            dropOff = Page.Request.Form["drop-off"].ToString();
            vehicle = carDropDown.SelectedItem.Text;
            uName = (string)Session["username"].ToString();
            if (pickUp.Equals(""))
            {
                validationLbl.Text = "Fill in the required inputs";

            }
            else if (dropOff.Equals(""))
            {
                validationLbl.Text = "Fill in the required inputs";
            }
            else if (carDropDown.SelectedIndex == 0)
            {
                validationLbl.Text = "Fill in the required inputs";
            }
            else
            {

          Page page = HttpContext.Current.CurrentHandler as Page;
                 page.ClientScript.RegisterStartupScript(
                     typeof(Page),
                     "Test",
                     "<script type='text/javascript'>openModel();</script>");

               

                AdressLongLat adrs = new AdressLongLat();
                adrs.Address = pickUp;
                adrs.GeoCode();

                AdressLongLat adrs2 = new AdressLongLat();
                adrs2.Address = dropOff;
                adrs2.GeoCode();


                int index = carDropDown.SelectedIndex;
                if (adrs.Longitude == null || adrs.Latitude == null || adrs2.Longitude == null || adrs2.Latitude == null)
                {
                    miles = DistanceTo(51.507351, -0.127758, 51.446210, 0.216872, 'M');
                }
                else
                {
                    miles = DistanceTo(Double.Parse(adrs.Latitude), Double.Parse(adrs.Longitude), Double.Parse(adrs2.Latitude), Double.Parse(adrs2.Longitude), 'M');
                }
                cost = Math.Round(discountOff(15, calculateTime(miles, index)), 2);
              //  ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + s.ToString() + "');", true);
             //   validationLbl.Text = "Your Driver is on the way £" + cost;
             

                //  Confrim.Text = "Pay £" + cost;
                message1Lbl.Text = "Your Driver is on the Way";
                message2Lbl.Text = "Cost: " + "£"+cost;
                message3Lbl.Text = "Miles: " + Math.Round(miles, 2);

                string today = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
                dbCon.addBooking(uName, vehicle, dropOff, pickUp);
                dbCon.AddReceipt(uName, today, "hope you have enjoyed your journey, what do you think of our services", Math.Round(miles, 2), cost);









            }



        }



        public double calculateTime(double miles, int vehicle)
        {
            int i = Convert.ToInt32(miles);
            if (vehicle == 1)
            {
                double x = 7.00 + 2.10 * miles;
                return x;
            }
            else if (vehicle == 2)
            {
                double x = 2.50 + 1.25 * miles;
                return x;
            }
            return 0.0;


        }

        public static double DistanceTo(double lat1, double lon1, double lat2, double lon2, char unit = 'M')
        {
            double rlat1 = Math.PI * lat1 / 180;
            double rlat2 = Math.PI * lat2 / 180;
            double theta = lon1 - lon2;
            double rtheta = Math.PI * theta / 180;
            double dist =
                Math.Sin(rlat1) * Math.Sin(rlat2) + Math.Cos(rlat1) *
                Math.Cos(rlat2) * Math.Cos(rtheta);
            dist = Math.Acos(dist);
            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;

            switch (unit)
            {
                case 'K': //Kilometers -> default
                    return dist * 1.609344;
                case 'N': //Nautical Miles 
                    return dist * 0.8684;
                case 'M': //Miles
                    return dist;
            }

            return dist;
        }


        public double discountOff(int percentages, double cost)
        {
            double newCost = Math.Round((cost / 100) * (100 - percentages), 2);

            return newCost;
        }






       private class AdressLongLat
        {
            public AdressLongLat()
            {
            }
            //Properties
            public string Latitude { get; set; }
            public string Longitude { get; set; }
            public string Address { get; set; }

            //The Geocoding here i.e getting the latt/long of address
            public void GeoCode()
            {
                //to Read the Stream
                StreamReader sr = null;

                //The Google Maps API Either return JSON or XML. We are using XML Here
                //Saving the url of the Google API 
                string url = String.Format("http://maps.googleapis.com/maps/api/geocode/xml?address=" +
                this.Address + "&sensor=false");

                //to Send the request to Web Client 
                WebClient wc = new WebClient();
                try
                {
                    sr = new StreamReader(wc.OpenRead(url));
                }
                catch (Exception ex)
                {
                    throw new Exception("The Error Occured" + ex.Message);
                }

                try
                {
                    XmlTextReader xmlReader = new XmlTextReader(sr);
                    bool latread = false;
                    bool longread = false;

                    while (xmlReader.Read())
                    {
                        xmlReader.MoveToElement();
                        switch (xmlReader.Name)
                        {
                            case "lat":

                                if (!latread)
                                {
                                    xmlReader.Read();
                                    this.Latitude = xmlReader.Value.ToString();
                                    latread = true;

                                }
                                break;
                            case "lng":
                                if (!longread)
                                {
                                    xmlReader.Read();
                                    this.Longitude = xmlReader.Value.ToString();
                                    longread = true;
                                }

                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An Error Occured" + ex.Message);
                }
            }
        }

        protected void ConfrimBtn_Click(object sender, EventArgs e)
        {

            Page page = HttpContext.Current.CurrentHandler as Page;
            page.ClientScript.RegisterStartupScript(
                typeof(Page),
                "Test",
                "<script type='text/javascript'>closeModel();</script>");

        }
    }
}

 


