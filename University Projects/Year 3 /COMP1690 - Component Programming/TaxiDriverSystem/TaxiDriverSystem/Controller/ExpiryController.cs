using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiDriverSystem.InnerJoin;
using TaxiDriverSystem.Interfaces;
using TaxiDriverSystem.Repositories;
using TaxiDriverSystem.Validation;
using TaxiDriverSystem.View;

namespace TaxiDriverSystem.Controller
{
    public class ExpiryController : IController
    {
        private InnerJoinRepository expiryRepos;
        private ExpiryView expiryV;
        private ExpiryValidation expiryValid;
        public ExpiryController(ExpiryView expiryView) {
           this.expiryV = expiryView;
           expiryV.ActivateView(this);
           this.expiryRepos = new InnerJoinRepository();
           this.expiryValid = new ExpiryValidation(this.expiryV);
           expiryV.DriverGrid.DataSource= Driver();
            expiryV.TrainingGrid.ReadOnly = true;





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

        public List<Driver> Driver()
        {

           
            IEnumerable<Driver> drivers = expiryRepos.ExpiredDrivers();


            List<Driver> driList = new List<Driver>();
            foreach (var item in drivers)
            {
             
                    driList.Add(item);

            }
            return driList;
        }

      

        public void MyClickEvent(object sender, EventArgs e)
        {

            if (sender == expiryV.DriverGrid)
            {
                if (expiryV.DriverGrid.SelectedRows.Count != 0)
                {
                    DataGridViewRow row = this.expiryV.DriverGrid.SelectedRows[0];
                    int i = (int)row.Cells["Driver_id"].Value;
                    expiryV.GeoTestGrid.DataSource =expiryRepos.expiredGeoTest(i);
                    expiryV.DriLicGrid.DataSource = expiryRepos.expiredDriLics(i);
                    expiryV.TrainingGrid.DataSource = expiryRepos.expiredDriverSession(i);
                }
               
                
            }
        }
    }
}
