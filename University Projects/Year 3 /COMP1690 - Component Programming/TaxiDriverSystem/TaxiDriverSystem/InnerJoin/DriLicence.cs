using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDriverSystem.InnerJoin
{
    public class DriLicence
    {
        private int DriLicence_ID;
        private int DriverID;
        private string DriLic_Num;
        private DateTime ExpiryDate;

        public int GeotestID1 { get => DriLicence_ID; set => DriLicence_ID = value; }
        public int DriverID1 { get => DriverID; set => DriverID = value; }
        public string DriLic_Num1 { get => DriLic_Num; set => DriLic_Num = value; }
        public DateTime ExpiryDate1 { get => ExpiryDate; set => ExpiryDate = value; }
    }
}
