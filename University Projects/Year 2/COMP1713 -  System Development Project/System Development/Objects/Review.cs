using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Systems_Development.Objects
{
    public class Review
    {
        private string CustomerUsername;
        private string star;
        private string reviewText;

        public Review(string customerUsername, string star, string reviewText)
        {
            this.CustomerUsername = customerUsername;
            this.star = star;
            this.reviewText = reviewText;
        }

        public string CustomerUsername1 { get => CustomerUsername; set => CustomerUsername = value; }
        public string Star { get => star; set => star = value; }
        public string ReviewText { get => reviewText; set => reviewText = value; }
    }
}