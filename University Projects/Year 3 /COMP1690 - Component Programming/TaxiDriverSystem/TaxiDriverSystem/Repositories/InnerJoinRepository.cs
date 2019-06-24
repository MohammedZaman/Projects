using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiDriverSystem.InnerJoin;

namespace TaxiDriverSystem.Repositories
{
    public class InnerJoinRepository
    {
        private LinqToSQlDataContext db;
        public InnerJoinRepository()
        {

            String constr = Properties.Settings.Default.dbString;
            db = new LinqToSQlDataContext(constr);


        }

        public List<GeographicalTest> DriverGeoTest(int driverId)
        {
            List<GeographicalTest> retList = new List<GeographicalTest>();
            var drivers = from d in db.Drivers
                          join dc in db.GeographicalTests on d.Driver_Id equals dc.Driver_Id
                          where d.Driver_Id == driverId
                          select dc;


            foreach (var per in drivers)
            {
                GeographicalTest objPer = new GeographicalTest();
                objPer.GeoTest_Id = (int)per.GeoTest_Id;
                objPer.Score = per.Score;
                objPer.Location = per.Location;
                objPer.Expiry_date = per.Expiry_date;
                objPer.Driver_Id = per.Driver_Id;
                retList.Add(objPer);
            }
            return retList;
        }


        public List<DriverSessions> DriverTraining(int driverId)
        {
            List<DriverSessions> retList = new List<DriverSessions>();
            var drivers = from d in db.Drivers
                          join dc in db.Trainings on d.Driver_Id equals dc.Driver_Id
                          join dd in db.TrainingSessions on dc.TrainingSession_Id equals dd.TrainingSession_Id
                          join de in db.TrainingTypes on dd.TrainingType_Id equals de.TrainingType_Id
                          where d.Driver_Id == driverId
                          select new { d, dc, dd, de }; ;


            foreach (var per in drivers)
            {
                DriverSessions objPer = new DriverSessions();
                objPer.Date_of_session1 = (DateTime)per.dd.Date_of_session;
                objPer.Training_name1 = (String)per.de.Training_name;
                objPer.Status = (Boolean)per.dc.Status;
                objPer.ExpiryDate = (DateTime)per.dd.Expiry_Date;
                retList.Add(objPer);
            }
            return retList;
        }


        public List<DrivingLicence> DriverDrivingLicence(int driverId)
        {
            List<DrivingLicence> retList = new List<DrivingLicence>();
            var drivers = from d in db.Drivers
                          join dc in db.DrivingLicences on d.Driver_Id equals dc.Driver_Id
                          where d.Driver_Id == driverId
                          select dc;


            foreach (var per in drivers)
            {
                DrivingLicence objPer = new DrivingLicence();
                objPer.DrvingLicence_Id = per.DrvingLicence_Id;
                objPer.Driver_number = per.Driver_number;
                objPer.Expiry_date = per.Expiry_date;
                objPer.Driver_Id = per.Driver_Id;
                retList.Add(objPer);
            }
            return retList;
        }

        public List<Driver> Driver(int driverId)
        {
            List<Driver> retList = new List<Driver>();
            var drivers = from d in db.Drivers
                          where d.Driver_Id == driverId
                          select d;


            foreach (var per in drivers)
            {
                Driver objPer = new Driver();
                objPer.Driver_Id = per.Driver_Id;
                objPer.First_Name = per.First_Name;
                objPer.Last_Name = per.Last_Name;
                objPer.PhoneNumber = per.PhoneNumber;
                objPer.Date_Of_Birth = per.Date_Of_Birth;
                objPer.User_Name = per.User_Name;
                objPer.Password = per.Password;
                retList.Add(objPer);
            }
            return retList;
        }



        public List<DriverGeoTest> DriverGeoTests(int driverId)
        {
            List<DriverGeoTest> retList = new List<DriverGeoTest>();
            var drivers = from d in db.Drivers
                          join dc in db.GeographicalTests on d.Driver_Id equals dc.Driver_Id
                          where d.Driver_Id == driverId
                          select dc;


            foreach (var per in drivers)
            {
                DriverGeoTest objPer = new DriverGeoTest();
                objPer.DriverID1 = (int)per.Driver_Id;
                objPer.GeotestID1 = per.GeoTest_Id;
                objPer.Location1 = per.Location;
                objPer.Score = (Decimal)per.Score;
                objPer.ExpiryDate1 = (DateTime)per.Expiry_date;
                retList.Add(objPer);
            }
            return retList;
        }

        public List<DriLicence> DriverLic(int driverId)
        {
            List<DriLicence> retList = new List<DriLicence>();
            var drivers = from d in db.Drivers
                          join dc in db.DrivingLicences on d.Driver_Id equals dc.Driver_Id
                          where d.Driver_Id == driverId
                          select dc;


            foreach (var per in drivers)
            {
                DriLicence objPer = new DriLicence();
                objPer.DriverID1 = (int)per.Driver_Id;
                objPer.GeotestID1 = per.DrvingLicence_Id;
                objPer.DriLic_Num1 = per.Driver_number;
                objPer.ExpiryDate1 = (DateTime)per.Expiry_date;
                retList.Add(objPer);
            }
            return retList;
        }




        public List<DriverSessions> driverSessions(int driverId)
        {
            List<DriverSessions> retList = new List<DriverSessions>();
            var drivers = from d in db.Drivers
                          join dc in db.Trainings on d.Driver_Id equals dc.Driver_Id
                          join dd in db.TrainingSessions on dc.TrainingSession_Id equals dd.TrainingSession_Id
                          join de in db.TrainingTypes on dd.TrainingType_Id equals de.TrainingType_Id
                          where d.Driver_Id == driverId
                          select new { d, dc, dd, de }; ;


            foreach (var per in drivers)
            {
                DriverSessions objPer = new DriverSessions();
                objPer.Training_name1 = (string)per.de.Training_name;
                objPer.Date_of_session1 = (DateTime)per.dd.Date_of_session;
                objPer.TrainingSession_Id1 = (int)per.dd.TrainingSession_Id;
                objPer.Training_id = (int)per.dc.Training_Id;
                objPer.Status = (bool)per.dc.Status;




                retList.Add(objPer);
            }
            return retList;
        }

        public List<DriverSessions> FindSessionId(int trainingId)
        {
            List<DriverSessions> retList = new List<DriverSessions>();
            var drivers = from d in db.Drivers
                          join dc in db.Trainings on d.Driver_Id equals dc.Driver_Id
                          join dd in db.TrainingSessions on dc.TrainingSession_Id equals dd.TrainingSession_Id
                          join de in db.TrainingTypes on dd.TrainingType_Id equals de.TrainingType_Id
                          where dc.Training_Id == trainingId
                          select new { d, dc, dd, de }; ;

            foreach (var per in drivers)
            {
                DriverSessions objPer = new DriverSessions();
                objPer.Status = (Boolean)per.dc.Status;
                objPer.Training_id = (int)per.dc.Training_Id;
                objPer.TrainingSession_Id1 = (int)per.dd.TrainingSession_Id;

                retList.Add(objPer);
            }
            return retList;
        }





        public List<Driver> ExpiredDrivers()
        {
            DateTime today = DateTime.Today;
            DateTime minusThirty = today.AddDays(30);


            List<Driver> retList = new List<Driver>();
            var drivers = from d in db.Drivers
                          join dc in db.Trainings on d.Driver_Id equals dc.Driver_Id
                          join dd in db.TrainingSessions on dc.TrainingSession_Id equals dd.TrainingSession_Id
                          join de in db.TrainingTypes on dd.TrainingType_Id equals de.TrainingType_Id
                          where dd.Expiry_Date <= minusThirty && dd.Expiry_Date >= today
                          select new { d }; ;

            foreach (var per in drivers)
            {

                Driver objPer = new Driver();
                objPer.Driver_Id = per.d.Driver_Id;
                objPer.First_Name = per.d.First_Name;
                objPer.Last_Name = per.d.Last_Name;
                objPer.PhoneNumber = per.d.PhoneNumber;
                objPer.User_Name = per.d.User_Name;
                objPer.Date_Of_Birth = per.d.Date_Of_Birth;
                objPer.Password = per.d.Password;
                retList.Add(objPer);
            }


            var driverGeo = from d in db.Drivers
                            join dg in db.DrivingLicences on d.Driver_Id equals dg.Driver_Id
                            where dg.Expiry_date <= minusThirty && dg.Expiry_date >= today
                            select new { d }; ;

            foreach (var per in driverGeo)
            {

                Driver objPer = new Driver();
                objPer.Driver_Id = per.d.Driver_Id;
                objPer.First_Name = per.d.First_Name;
                objPer.Last_Name = per.d.Last_Name;
                objPer.PhoneNumber = per.d.PhoneNumber;
                objPer.User_Name = per.d.User_Name;
                objPer.Date_Of_Birth = per.d.Date_Of_Birth;
                objPer.Password = per.d.Password;
                retList.Add(objPer);
            }


            var driverDri = from d in db.Drivers
                            join df in db.GeographicalTests on d.Driver_Id equals df.Driver_Id
                            where df.Expiry_date <= minusThirty && df.Expiry_date >= today
                            select new { d }; ;

            foreach (var per in driverDri)
            {

                Driver objPer = new Driver();
                objPer.Driver_Id = per.d.Driver_Id;
                objPer.First_Name = per.d.First_Name;
                objPer.Last_Name = per.d.Last_Name;
                objPer.PhoneNumber = per.d.PhoneNumber;
                objPer.User_Name = per.d.User_Name;
                objPer.Date_Of_Birth = per.d.Date_Of_Birth;
                objPer.Password = per.d.Password;
                retList.Add(objPer);
            }

            var query = retList.GroupBy(x => x.Driver_Id).Select(y => y.FirstOrDefault());

            return query.ToList();
        }


        public List<GeographicalTest> expiredGeoTest(int driverId)
        {
            DateTime today = DateTime.Today;
            DateTime minusThirty = today.AddDays(30);
            List<GeographicalTest> retList = new List<GeographicalTest>();
            var drivers = from d in db.Drivers
                          join dc in db.GeographicalTests on d.Driver_Id equals dc.Driver_Id
                          where d.Driver_Id == driverId && dc.Expiry_date <= minusThirty && dc.Expiry_date >= today
                          select new { d, dc }; ;


            foreach (var per in drivers)
            {
                GeographicalTest objPer = new GeographicalTest();
                objPer.Driver_Id = per.dc.Driver_Id;
                objPer.Expiry_date = (DateTime)per.dc.Expiry_date;
                objPer.Location = per.dc.Location;
                objPer.Score = per.dc.Score;
                retList.Add(objPer);
            }
            return retList;
        }


        public List<DrivingLicence> expiredDriLics(int driverId)
        {
            DateTime today = DateTime.Today;
            DateTime minusThirty = today.AddDays(30);
            List<DrivingLicence> retList = new List<DrivingLicence>();
            var drivers = from d in db.Drivers
                          join dc in db.DrivingLicences on d.Driver_Id equals dc.Driver_Id
                          where d.Driver_Id == driverId && dc.Expiry_date <= minusThirty && dc.Expiry_date >= today
                          select new { d, dc }; ;


            foreach (var per in drivers)
            {
                DrivingLicence objPer = new DrivingLicence();
                objPer.Driver_Id = per.dc.Driver_Id;
                objPer.Expiry_date = (DateTime)per.dc.Expiry_date;
                objPer.Driver_number = per.dc.Driver_number;
                objPer.Driver_Id = per.dc.Driver_Id;

                retList.Add(objPer);
            }
            return retList;
        }

        public List<DriverSessions> expiredDriverSession(int driverId)
        {
            DateTime today = DateTime.Today;
            DateTime minusThirty = today.AddDays(30);
            List<DriverSessions> retList = new List<DriverSessions>();
            var drivers = from d in db.Drivers
                          join dc in db.Trainings on d.Driver_Id equals dc.Driver_Id
                          join dd in db.TrainingSessions on dc.TrainingSession_Id equals dd.TrainingSession_Id
                          join de in db.TrainingTypes on dd.TrainingType_Id equals de.TrainingType_Id
                          where d.Driver_Id == driverId && dd.Expiry_Date <= minusThirty && dd.Expiry_Date >= today
                          select new { d, dc, dd, de }; ;


            foreach (var per in drivers)
            {
                DriverSessions objPer = new DriverSessions();
                objPer.Training_name1 = (string)per.de.Training_name;
                objPer.Date_of_session1 = (DateTime)per.dd.Date_of_session;
                objPer.TrainingSession_Id1 = (int)per.dd.TrainingSession_Id;
                objPer.Training_id = (int)per.dc.Training_Id;
                objPer.Status = (bool)per.dc.Status;
                objPer.ExpiryDate = (DateTime)per.dd.Expiry_Date;




                retList.Add(objPer);
            }
            return retList;
        }


        public bool IsvalidUser(string userName, string password)
        {
            var q = from p in db.Admins

                    where p.User_Name == userName

                    && p.Password == password

                    select p;

            if (q.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public float PredAccident(int driverId)
        {
            DateTime today = DateTime.Today;
            DateTime minusThirty = today.AddDays(-7);// days from the last 7 days 
            List<DriverSessions> retList = new List<DriverSessions>();
            var logs = from d in db.Drivers
                       join dc in db.DayLogs on d.Driver_Id equals dc.Driver_Id
                       where dc.Driver_Id == driverId && dc.Day_start >= minusThirty && dc.Day_start <= today
                       select new { d, dc, }; ;

            float total = 0;
            foreach (var per in logs)
            {
                float x = (float)per.dc.Day_duration / 60;// mins to hours 
                total = total + x ;
            }
            float numDays = logs.Count(); // number of days 
            float workingHours = 16; // legal hours which can be wored for driver, for uber it is 10 hours 
            float hoursInDay = numDays * workingHours; // 16 Hours a day work
            float rate = 100 / hoursInDay; 
            float output = rate * total; // result in percentages 
            
            return output;
        }


        public float PredTrianing(int driverId)
        {
            DateTime today = DateTime.Today;
            DateTime minusThirty = today.AddDays(-7);
            var training = from d in db.Drivers
                       join dc in db.Trainings on d.Driver_Id equals dc.Driver_Id
                       where dc.Driver_Id == driverId && dc.Status == true
                       select new { d, dc, }; ;

            var types = from d in db.TrainingTypes
                           select new { d}; ;

            int Count =  training.Count();

            int typeC = types.Count();

            float rate = (float) 100 / typeC;
            float output = rate * Count;
          
            float outputFinal = output;

            return 100 - outputFinal;
        }
    }
}

