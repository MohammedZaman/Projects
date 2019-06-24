using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TaxiDriverSystem.Interfaces;
using TaxiDriverSystem.Misc;
using TaxiDriverSystem.View;

namespace TaxiDriverSystem.Validation
{
    public class IncidentController:IController
    {

        private IRepository<Disciplinary> iRepos;
        private IncidentView iView;
        private IncidentValidation iValid;
        public IncidentController(IncidentView view)
        {
            this.iRepos = new GenericRepository<Disciplinary>();
            this.iView = view;
            view.ActivateView(this);
            this.iValid = new IncidentValidation(view);
            updateDrivers();
            updateIncidentTypes();



        }

        public void MyClickEvent(object sender, EventArgs e)
        {
            if (sender == iView.AddSubmitBtn1) {

                if (iValid.onClickAddValidate() == true)
                {
                    ComboboxValue tmpComboboxValue = (ComboboxValue)iView.SelectDBox1.SelectedItem;
                    ComboboxValue incident = (ComboboxValue)iView.SelectIBox.SelectedItem;

                    int id = tmpComboboxValue.Id;
                    int incidentType = incident.Id;
                    string incidentReport = iView.IBox.Text;

                    Disciplinary disciplinary = new Disciplinary();
                    disciplinary.Driver_Id = id;
                    disciplinary.IncidentType_Id = incidentType;
                    disciplinary.Incident_report = incidentReport;

                    iRepos.insert(disciplinary);
                    iRepos.save();
                    MessageBox.Show("Disaplinary added");
                }
                else { MessageBox.Show("Fill in required Fields"); }



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
            iValid.onChangeAddValidate(); 
        }


        public void updateIncidentTypes()
        {


            // loop data into combo box 
            GenericRepository<IncidentType> iTypeRepos = new GenericRepository<IncidentType>();
                IEnumerable<IncidentType> tTypes  = iTypeRepos.SelectAll();
               
              

                foreach (var item in tTypes)
                {
                    iView.SelectIBox.Items.Add(new ComboboxValue(item.IncidentType_Id, item.incident_type));
                   
                }
            
        }

        public void updateDrivers()
        {
            iView.SelectIBox.SelectedIndex = -1;
            iView.SelectIBox.Items.Clear();
            GenericRepository<Driver> incidentT = new GenericRepository<Driver>();
            IEnumerable<Driver> GeoTests = incidentT.SelectAll();

            foreach (var item in GeoTests)
            {

                iView.SelectDBox1.Items.Add(new ComboboxValue(item.Driver_Id, item.First_Name));
              


            }
        }
    }
}
