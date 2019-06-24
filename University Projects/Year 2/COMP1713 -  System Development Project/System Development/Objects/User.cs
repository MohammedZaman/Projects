using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Systems_Development.Objects
{
    public class User
    {

 
        private string uname;
        private string password;
        private string fName;
        private string lName;
        private string eMail;
        private string mobNum;
        private string Type;



        public User(string uname, string password, string fName, string lName, string eMail, string mobNum,string type)
        {
           
            this.uname = uname;
            this.password = password;
            this.fName = fName;
            this.lName = lName;
            this.eMail = eMail;
            this.mobNum = mobNum;
            this.Type = type;
        }

     
        public string Uname { get => uname; set => uname = value; }
        public string Password { get => password; set => password = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public string EMail { get => eMail; set => eMail = value; }
        public string MobNum { get => mobNum; set => mobNum = value; }
        public string Type1 { get => Type; set => Type = value; }
    }
}