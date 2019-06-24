using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDriverSystem.InnerJoin
{
     public class DriverGeoTest
    {
        private int GeotestID;
        private int DriverID;
        private string Location;
        private Decimal score;
        private DateTime ExpiryDate;

        public DriverGeoTest()
        {
        }

        public int GeotestID1 { get => GeotestID; set => GeotestID = value; }
        public int DriverID1 { get => DriverID; set => DriverID = value; }
        public string Location1 { get => Location; set => Location = value; }
        public decimal Score { get => score; set => score = value; }
        public DateTime ExpiryDate1 { get => ExpiryDate; set => ExpiryDate = value; }
    }
}
