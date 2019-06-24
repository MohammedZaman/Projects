using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Systems_Development.Objects
{
    public class Driver : User
    {
        private string licence_Plate_Number;
        private string drivingLincence;
        private Boolean avaibility;
        public Driver(string uname, string password, string fName, string lName, string eMail, string mobNum, string type,string licence_Plate_Number,string drivingLicence,Boolean avaibility) : base(uname, password, fName, lName, eMail, mobNum, type)
        {
            this.licence_Plate_Number = licence_Plate_Number;
            this.drivingLincence = drivingLicence;
            this.avaibility = avaibility;

        }
    }
}