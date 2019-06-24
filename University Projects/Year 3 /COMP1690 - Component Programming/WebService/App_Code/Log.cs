using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for Log
/// </summary>
[WebService(Namespace = "http://cms.gre.ac.uk/pdc/jjj")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Log : System.Web.Services.WebService
{
    private LinkToSQLDataContext db;
    public Log()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
        String constr = System.Configuration.ConfigurationManager.ConnectionStrings["DataSourceConnectionString"].ConnectionString;
        db = new LinkToSQLDataContext(constr);
    }

    [WebMethod]
    public string startDay(int id)
    {

        var foundDrivers = from d in db.Drivers
                      where d.Driver_Id == id
                      select d;

        if (foundDrivers.Count() <= 0)
        {
            return "Driver does not exist";
        }
        else
        {


            var drivers = from d in db.Drivers
                          join dc in db.DayLogs on d.Driver_Id equals dc.Driver_Id
                          where d.Driver_Id == id && dc.Day_start.Value.Date == System.DateTime.Now.Date
                          select dc;

            DayLog day = new DayLog();
            foreach (var per in drivers)
            {
                day.Day_start = per.Day_start;
                day.Day_end = per.Day_end;
                day.Day_Id = per.Day_Id;
                day.Driver_Id = per.Driver_Id;
            }

            int count = drivers.Count();
            if (count <= 0)
            {
                day.Day_start = System.DateTime.Now;
                day.Driver_Id = id;
                db.GetTable<DayLog>().InsertOnSubmit(day);
                db.SubmitChanges();
                return "Day Started";
            }
            else if (count > 0 && day.Day_start != null && day.Day_end == null)
            {
                return "Day has begun Already";
            }
            else if (count > 0 && day.Day_start != null && day.Day_end != null)
            {
                return "Day Concluded";
            }
            else if (count > 0 && day.Day_start != null)
            {
                return "Day has begun Already";
            }
            else { return "undefined"; }
        }
    }


    [WebMethod]
    public string endDay(int id)
    {

        var foundDrivers = from d in db.Drivers
                           where d.Driver_Id == id
                           select d;

        if (foundDrivers.Count() <= 0)
        {
            return "Driver does not exist";
        }
        else
        {
            var dayLogs = from d in db.Drivers
                          join dc in db.DayLogs on d.Driver_Id equals dc.Driver_Id
                          where d.Driver_Id == id && dc.Day_start.Value.Date == System.DateTime.Now.Date
                          select dc;

            DayLog day = new DayLog();
            foreach (var per in dayLogs)
            {
                day.Day_start = per.Day_start;
                day.Day_end = per.Day_end;
                day.Day_Id = per.Day_Id;
                day.Driver_Id = per.Driver_Id;
            }

            int count = dayLogs.Count();
            if (count >= 0 && day.Day_start != null && day.Day_end == null)
            {
                DayLog result = (from d in db.DayLogs
                                 where d.Day_Id == day.Day_Id
                                 select d).SingleOrDefault();

                result.Day_end = System.DateTime.Now;
                DateTime dayS = (DateTime)day.Day_start;
                TimeSpan time  = dayS.TimeOfDay;
                TimeSpan timeNow = System.DateTime.Now.TimeOfDay;
                TimeSpan duration = timeNow.Subtract(time);
                result.Day_duration = (Decimal)duration.TotalMinutes;


                db.SubmitChanges();
                return "Day Ended";
            }
            else if (count <= 0)
            {
                return "Day has not been started";
            }
            else if (day.Day_start != null && day.Day_end != null)
            {
                return "Day Concluded";
            }
            else { return "undefined"; }
        }
    }


    [WebMethod]
    public string startJourney(int id)
    {

       
        
            var dayLogs = from d in db.Drivers
                          join dc in db.DayLogs on d.Driver_Id equals dc.Driver_Id
                          where d.Driver_Id == id && dc.Day_start.Value.Date == System.DateTime.Now.Date
                          select dc;

            DayLog day = new DayLog();


            var JourneyLogs = from d in db.DayLogs
                              join dc in db.JourneyLogs on d.Day_Id equals dc.Day_Id
                              where d.Driver_Id == id
                              select dc;

            JourneyLog journey = new JourneyLog();
            foreach (var per in JourneyLogs)
            {
                journey.Journey_start = per.Journey_start;
                journey.Journey_end = per.Journey_end;
                journey.Day_Id = per.Day_Id;

            }
            int countJ = JourneyLogs.Count();

            foreach (var per in dayLogs)
            {
                day.Day_start = per.Day_start;
                day.Day_end = per.Day_end;
                day.Day_Id = per.Day_Id;
                day.Driver_Id = per.Driver_Id;
            }

            int count = dayLogs.Count();
            if (count <= 0)
            {
                return "Start Day ";
            }
        else if (count > 0 && day.Day_start != null && day.Day_end != null)
        {

            return "Day Concluded, No journey can be added to day until the next day";

        }
        else if (count >= 0)
            {
            if (journey.Journey_start == null && journey.Journey_end == null)
            {
                journey.Journey_start = System.DateTime.Now;
                journey.Day_Id = day.Day_Id;
                db.GetTable<JourneyLog>().InsertOnSubmit(journey);
                db.SubmitChanges();
                return "Journey Started";
            } else if (countJ >= 0) {

                journey.Journey_start = System.DateTime.Now;
                journey.Journey_end = null;
                journey.Day_Id = day.Day_Id;
                db.GetTable<JourneyLog>().InsertOnSubmit(journey);
                db.SubmitChanges();

                return "Journey Started";

            }
            return "";
            }
          
            else
            {
                return "Journey Already Started";
            }

        
        }


    [WebMethod]
    public string endJourney(int id)
    {

        
            var dayLogs = from d in db.Drivers
                          join dc in db.DayLogs on d.Driver_Id equals dc.Driver_Id
                          where d.Driver_Id == id && dc.Day_start.Value.Date == System.DateTime.Now.Date
                          select dc;

            DayLog day = new DayLog();
            foreach (var per in dayLogs)
            {
                day.Day_start = per.Day_start;
                day.Day_end = per.Day_end;
                day.Day_Id = per.Day_Id;
                day.Driver_Id = per.Driver_Id;
            }

            int count = dayLogs.Count();
            if (count <= 0)
            {
                return "Start Day ";
            }
            else if (count >= 0 && day.Day_start != null && day.Day_end == null)
            {
                var JourneyLogs = from d in db.DayLogs
                                  join dc in db.JourneyLogs on d.Day_Id equals dc.Day_Id
                                  where d.Driver_Id == id
                                  select dc;

                JourneyLog journey = new JourneyLog();
                foreach (var per in JourneyLogs)
                {
                    journey.Journey_start = per.Journey_start;
                    journey.Day_Id = per.Day_Id;

                }
                int countJourney = JourneyLogs.Count();
                if (countJourney > 0 && journey.Journey_start != null && journey.Journey_end == null)
                {
                    JourneyLog result = (from d in db.JourneyLogs
                                         where d.Day_Id == journey.Day_Id && d.Journey_end == null
                                         select d).SingleOrDefault();

                
                result.Journey_end = System.DateTime.Now;
                DateTime dayS = (DateTime)day.Day_start;
                TimeSpan time = dayS.TimeOfDay;
                TimeSpan timeNow = System.DateTime.Now.TimeOfDay;
                TimeSpan duration = timeNow.Subtract(time);
                result.Journey_duration = (Decimal)duration.TotalMinutes;

                db.SubmitChanges();
                    return "Journey Ended";
                }
                else if (countJourney > 0 && journey.Journey_start != null && journey.Journey_end != null)
                {
                    return "journey Concluded";
                }
                else
                {
                    return "Journey Not Started";
                }

            }
            else if (count > 0 && day.Day_start != null && day.Day_end != null)
            {

                return "Day Concluded, No journey can be added to day until the next day";

            }
            else
            {
                return "Undefined ";
            }

        
    }
}
