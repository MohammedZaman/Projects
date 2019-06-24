using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Systems_Development.Objects
{
    public class Booking
    {
        // anis this journey
        private string customerUserName;
        private string vehicle;
        private string pickup;
        private string destination;
        private Boolean discount;

        public string UserName { get => customerUserName; set => customerUserName = value; }
        public string Vehicle { get => vehicle; set => vehicle = value; }
        public string Pickup { get => pickup; set => pickup = value; }
        public string Destination { get => destination; set => destination = value; }
        public bool Discount { get => discount; set => discount = value; }
    }
}