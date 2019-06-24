using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Systems_Development.Objects
{
    public class Card
    {
        private int cardID;
        private string customerUserName;
        private string nameOnCard;
        private string cardNumber;
        private string expirationDate;
        private string cvc;

        public int CardID { get => cardID; set => cardID = value; }
        public string CustomerUsername { get => customerUserName; set => customerUserName = value; }
        public string NameOnCard { get => nameOnCard; set => nameOnCard = value; }
       public string CardNumber { get => cardNumber; set => cardNumber = value; }
        public string ExpirationDate { get => expirationDate; set => expirationDate = value; }
       public string Cvc { get => cvc; set => cvc = value; }

        public Card(int cardID, string customerUsername, string nameOnCard, string cardNumber, string expirationDate, string cvc)
        {
            this.cardID = cardID;
            this.customerUserName = customerUsername;
            NameOnCard = nameOnCard;
            CardNumber = cardNumber;
            ExpirationDate = expirationDate;
            this.cvc = cvc;
        }
    }
}