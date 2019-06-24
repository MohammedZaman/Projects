using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Systems_Development.Objects
{
    public class Staff : User
    {
        public Staff( string uname, string password, string fName, string lName, string eMail, string mobNum,string type) : base(uname, password, fName, lName, eMail, mobNum ,type)
        {
        }


    }
}