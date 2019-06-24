using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiDriverSystem.Interfaces;
using TaxiDriverSystem.Validation;
using TaxiDriverSystem.View;

namespace TaxiDriverSystem.Controller
{
    public class MainViewController : IController
    {
        private MainConsole main;
        private FlowLayoutPanel MainLayout;
        public MainViewController(MainConsole mainConsole) {
            this.main = mainConsole;
            main.ActivateView(this);
            this.MainLayout = main.MainLayout1;

            MainLayout.Controls.Clear();
            DriverView s = new DriverView();
            DriverController driverController = new DriverController(s);
            MainLayout.Controls.Add(s);
        }
        public void MyClickEvent(object sender, EventArgs e)
        {
            if (sender == main.DriverToolMenuItem)
            {
                MainLayout.Controls.Clear();
                DriverView s = new DriverView();
                DriverController driverController = new DriverController(s);
                MainLayout.Controls.Add(s);

            }
            else if (sender == main.GeoMenuItem)
            {

                MainLayout.Controls.Clear();
                GeoTestView s = new GeoTestView();
                GeoTestController geoTestContoller = new GeoTestController(s);
                MainLayout.Controls.Add(s);

            }
            else if (sender == main.DriLicMenuItem)
            {

                MainLayout.Controls.Clear();
                DrivingLicenceView s = new DrivingLicenceView();
                DrivingLicenceController drivContoller = new DrivingLicenceController(s);
                MainLayout.Controls.Add(s);
            }
            else if (sender == main.TrainingTypesMenuItem)
            {

                MainLayout.Controls.Clear();
                TrainTypeView s = new TrainTypeView();
                TrainTypeController trainTypeContoller = new TrainTypeController(s);
                MainLayout.Controls.Add(s);
              
            }
            else if (sender == main.SheduleMenuItem1)
            {

                MainLayout.Controls.Clear();
                SessionView s = new SessionView();
                SessionController sessionContoller = new SessionController(s);
                MainLayout.Controls.Add(s);

            }
            else if(sender == main.AssignMenuItem1)
            {

                MainLayout.Controls.Clear();
                AssignView s = new AssignView();
                AssignController assigncontroller = new AssignController(s);
                MainLayout.Controls.Add(s);

            }
            else if (sender == main.SearchMenuItem)
            {
                MainLayout.Controls.Clear();
                SearchView s = new SearchView();
                SearchContoller searchContoller = new SearchContoller(s);
                MainLayout.Controls.Add(s);

            }
            else if (sender == main.ViewExpryMenuItem1)
            {
                MainLayout.Controls.Clear();
                ExpiryView s = new ExpiryView();
                ExpiryController expiryController = new ExpiryController(s);
                MainLayout.Controls.Add(s);

            }
            else if (sender == main.IncidentTypeMenuItem1)
            {
                MainLayout.Controls.Clear();
                IncidentTypeView s = new IncidentTypeView();
                IncidentTypeController expiryController = new IncidentTypeController(s);
                MainLayout.Controls.Add(s);

            }
            else if (sender == main.DisaplinaryMenuItem1)
            {
                MainLayout.Controls.Clear();
                IncidentView s = new IncidentView();
                IncidentController expiryController = new IncidentController(s);
                MainLayout.Controls.Add(s);

            }
            else if (sender == main.PredictionMenuItem)
            {
                MainLayout.Controls.Clear();
                PredictionView s = new PredictionView();
                PredictionController expiryController = new PredictionController(s);
                MainLayout.Controls.Add(s);

            }
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
