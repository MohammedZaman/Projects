using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Systems_Development.Objects
{
    public class Address
    {

        private int addressID;
        private string customerUserName;
        
        private string address1;
        private string address2;
        private string city;
        private string postCode;
        

        public int AddressID { get => addressID; set => addressID = value; }
       
        public string Address1 { get => address1; set => address1 = value; }
        public string Address2 { get => address2; set => address2 = value; }
        public string City { get => city; set => city = value; }
        public string PostCode { get => postCode; set => postCode = value; }
        public string CustomerUserName { get => customerUserName; set => customerUserName = value; }

        public Address(int addressID, string cUserName, string address1, string address2, string city, string postCode)
        {
            this.addressID = addressID;
           
            this.customerUserName = cUserName;
            this.address1 = address1;
            this.address2 = address2;
            this.city = city;
            this.postCode = postCode;
        }
    }
}