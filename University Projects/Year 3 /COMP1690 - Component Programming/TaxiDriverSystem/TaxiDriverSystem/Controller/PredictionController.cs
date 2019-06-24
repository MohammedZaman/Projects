using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms.DataVisualization.Charting;
using TaxiDriverSystem.Interfaces;
using TaxiDriverSystem.Repositories;
using TaxiDriverSystem.View;

namespace TaxiDriverSystem.Controller
{
    public class PredictionController : IController
    {
        private PredictionView predV;
        public PredictionController(PredictionView view)
        {
            this.predV = view;
            view.ActivateView(this);// addding event handlers to buttons
            predV.Chart1.Series.Clear();

        }
        public void MyClickEvent(object sender, EventArgs e)
        {
            if (sender == predV.TirednessBtn1) {

                fillTriednessPrediction();

            }
            else if (sender == predV.TrainingBtn1) {

                fillSessionsPrediction();



            }
        }

        private void fillTriednessPrediction() {


                predV.Chart1.Series.Clear();
          
                GenericRepository<DayLog> dayRepos = new GenericRepository<DayLog>();
                var series = new Series("Acident Rate");

                InnerJoinRepository repos = new InnerJoinRepository();
              


                GenericRepository<Driver> driverRepos = new GenericRepository<Driver>();

                IEnumerable<Driver> drivers = driverRepos.SelectAll();

                List<string> driverNames = new List<string>();
                List<float> rate = new List<float>();

                foreach (var item in drivers)
                {
                    driverNames.Add(item.First_Name);
                    rate.Add(repos.PredAccident(item.Driver_Id));
                }

                string[] driNames = driverNames.ToArray();
                float[] AcidentRate = rate.ToArray();

                // Frist parameter is X-Axis and Second is Collection of Y- Axis
                series.Points.DataBindXY(driNames, AcidentRate);
                predV.Chart1.ChartAreas[0].AxisX.Title = "Drivers Names";
                predV.Chart1.ChartAreas[0].AxisY.Title = "Accident likelyhood (%)";
                predV.Chart1.Series.Add(series);
    
                
            
        }

        private void fillSessionsPrediction()
        {


            predV.Chart1.Series.Clear();

           
            var series = new Series("Acident Rate");

            InnerJoinRepository repos = new InnerJoinRepository();



            GenericRepository<Driver> driverRepos = new GenericRepository<Driver>();

            IEnumerable<Driver> drivers = driverRepos.SelectAll();

            List<string> driverNames = new List<string>();
            List<float> rate = new List<float>();

            foreach (var item in drivers)
            {
                driverNames.Add(item.First_Name);
                rate.Add(repos.PredTrianing(item.Driver_Id));
            }

            string[] driNames = driverNames.ToArray();
            float[] AcidentRate = rate.ToArray();

            // Frist parameter is X-Axis and Second is Collection of Y- Axis
            series.Points.DataBindXY(driNames, AcidentRate);
            predV.Chart1.ChartAreas[0].AxisX.Title = "Drivers Names";
            predV.Chart1.ChartAreas[0].AxisY.Title = "Accident likelyhood (%)";
            predV.Chart1.Series.Add(series);



        }

        public void MyIndexChange(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void textBox_Validating(object sender, CancelEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
