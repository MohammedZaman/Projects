using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDriverSystem.InnerJoin
{
    public class DriverSessions
    {

        private int TrainingSession_Id;
        private DateTime Date_of_session;
        private string Training_name;
        private Boolean status;
        private DateTime expiryDate;
        private int training_id;
       


        public int TrainingSession_Id1 { get => TrainingSession_Id; set => TrainingSession_Id = value; }
        public DateTime Date_of_session1 { get => Date_of_session; set => Date_of_session = value; }
        public string Training_name1 { get => Training_name; set => Training_name = value; }
        public bool Status { get => status; set => status = value; }
        public int Training_id { get => training_id; set => training_id = value; }
        public DateTime ExpiryDate { get => expiryDate; set => expiryDate = value; }
    }
}
