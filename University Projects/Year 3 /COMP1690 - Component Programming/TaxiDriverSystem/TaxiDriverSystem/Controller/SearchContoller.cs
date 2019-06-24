using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TaxiDriverSystem.InnerJoin;
using TaxiDriverSystem.Interfaces;
using TaxiDriverSystem.Misc;
using TaxiDriverSystem.Repositories;
using TaxiDriverSystem.Validation;
using TaxiDriverSystem.View;

namespace TaxiDriverSystem.Controller
{
    public class SearchContoller : IController
    {
        private IRepository<Driver> searchRepos;
        private SearchView searchV;
        private SearchValidation searchValid;
        private IRepository<TrainingSession> sessionRepos;
        public SearchContoller(SearchView view)
        {
            this.searchRepos = new GenericRepository<Driver>();
            this.sessionRepos = new GenericRepository<TrainingSession>();
            this.searchV= view;
            view.ActivateView(this);// addding event handlers to buttons
            this.searchValid = new SearchValidation(searchV);
            updateDriverBox();
          
        }
        public void MyClickEvent(object sender, EventArgs e)
        {
            if (searchValid.onClickSearchValidate() == true) {
                if (searchV.EditSelectTBox1.SelectedIndex != -1)
                {
                    ComboboxValue tmpComboboxValue = (ComboboxValue)searchV.EditSelectTBox1.SelectedItem;
                    int id = tmpComboboxValue.Id;
                    searchV.DriverGrid1.DataSource = Driver(id);
                    searchV.GeoTestGrid1.DataSource = GeoTest(id);
                    searchV.DrivingLicenceGrid1.DataSource = drivLicence(id);
                    searchV.TrainingGrid1.DataSource = training(id);


                }
            }
            else { MessageBox.Show("Select Driver"); }

        }

        public void updateDriverBox()
        {
           
            // loop data into combo box 
            IEnumerable<Driver> drivers = searchRepos.SelectAll();
            
            searchV.EditSelectTBox1.Items.Clear();

            foreach (var item in drivers)
            {
                searchV.EditSelectTBox1.Items.Add(new ComboboxValue(item.Driver_Id, item.First_Name));
               
            }
        }


        public List<Driver> Driver(int id ) {

            Repositories.InnerJoinRepository driverRepos = new Repositories.InnerJoinRepository();
            IEnumerable<Driver> drivers = driverRepos.Driver(id);

            
            List<Driver> driList = new List<Driver>();
            foreach (var item in drivers)
            {
                if (item.Driver_Id == id) {
                    driList.Add(item);
                }

            }
            return driList;
        }

        public List<GeographicalTest> GeoTest(int id)
        {

            Repositories.InnerJoinRepository driverRepos = new Repositories.InnerJoinRepository();
            IEnumerable<GeographicalTest> geoTests = driverRepos.DriverGeoTest(id);

           
            List<GeographicalTest> geoTestList = new List<GeographicalTest>();
            foreach (var item in geoTests)
            {
                if (item.Driver_Id == id)
                {
                    geoTestList.Add(item);
                }

            }
            return geoTestList;
        }

        public List<DrivingLicence> drivLicence(int id)
        {

            Repositories.InnerJoinRepository driverRepos = new Repositories.InnerJoinRepository();
            IEnumerable<DrivingLicence> drivingLics = driverRepos.DriverDrivingLicence(id);

            List<DrivingLicence> drivLicenceList = new List<DrivingLicence>();
            foreach (var item in drivingLics)
            {
                if (item.Driver_Id == id)
                {
                    drivLicenceList.Add(item);
                }

            }
            return drivLicenceList;
        }

        public List<DriverSessions> training(int id)
        {

            InnerJoinRepository driverRepos = new InnerJoinRepository();
            IEnumerable<DriverSessions> trainings = driverRepos.DriverTraining(id);

            List<DriverSessions> trainingLists = new List<DriverSessions>();
            foreach (var item in trainings)
            {
             
                    trainingLists.Add(item);
                

            }
            return trainingLists;
        }
        public void MyIndexChange(object sender, EventArgs e)
        {
           
        }

        public void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void textBox_Validating(object sender, CancelEventArgs e)
        {
            searchValid.onChangeSearchValidate();
        }
    }
}
