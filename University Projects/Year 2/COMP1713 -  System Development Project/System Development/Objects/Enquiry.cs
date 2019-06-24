using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Systems_Development.Objects
{
    public class Enquiry
    {
        private string customerUserName;
        private string date;
        private string subject;
        private string enquiryText;

        public Enquiry(string customerUserName, string date, string subject, string enquiryText)
        {
            this.CustomerUserName = customerUserName;
            this.Date = date;
            this.Subject = subject;
            this.EnquiryText = enquiryText;
        }

        public string CustomerUserName { get => customerUserName; set => customerUserName = value; }
        public string Date { get => date; set => date = value; }
        public string Subject { get => subject; set => subject = value; }
        public string EnquiryText { get => enquiryText; set => enquiryText = value; }
    }
}