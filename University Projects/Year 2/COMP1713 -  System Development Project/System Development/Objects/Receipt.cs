using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Systems_Development.Objects
{
    public class Receipt
    {
        private string recieptText;
        private double miles;
        private double cost;
        private string date;

        public Receipt(string recieptText, double miles, double cost, string date )
        {
            this.Date = date;
            this.recieptText = recieptText;
            this.miles = miles;
            this.cost = cost;
        }

        public string RecieptText { get => recieptText; set => recieptText = value; }
        public double Miles { get => miles; set => miles = value; }
        public double Cost { get => cost; set => cost = value; }
        public string Date { get => date; set => date = value; }

      
    }
}