using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Systems_Development.Objects
{
    public class Customer : User
    {
        public Customer( string uname, string password, string fName, string lName, string eMail, string mobNum, string type) : base(uname, password, fName, lName, eMail, mobNum,type)
        {
        }

        public void view_DriverAvailability() {
        }
        public void view_CustomerDetail() {
        }
    }
}