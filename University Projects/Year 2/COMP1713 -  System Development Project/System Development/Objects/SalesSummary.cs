using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Systems_Development.Objects
{
    public class SalesSummary
    {
        private double salesTotal;

        public SalesSummary(double salesTotal)
        {
            this.SalesTotal = salesTotal;
        }

        public double SalesTotal { get => salesTotal; set => salesTotal = value; }
    }
}