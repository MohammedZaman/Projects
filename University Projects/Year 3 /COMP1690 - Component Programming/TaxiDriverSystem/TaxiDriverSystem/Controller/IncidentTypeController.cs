using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiDriverSystem.View;
using TaxiDriverSystem.Validation;
using TaxiDriverSystem.Misc;
using TaxiDriverSystem.Interfaces;
using TaxiDriverSystem.InnerJoin;

namespace TaxiDriverSystem.Controller
{
    public class IncidentTypeController : IController
    {
        private IRepository<IncidentType> trainTypeRepos;
        private IncidentTypeView iTypeView;
        private IncidentTypeValidation iTypeValid;
        public IncidentTypeController(IncidentTypeView view) {
            this.trainTypeRepos = new GenericRepository<IncidentType>();
            this.iTypeView = view;
            view.ActivateView(this);
            this.iTypeValid = new IncidentTypeValidation(view);
        


        }

        public void MyClickEvent(object sender, EventArgs e)
        {
            if (sender == iTypeView.AddSubmitBtn1)
            {
                if (iTypeValid.onClickAddValidate() == true)
                {

                    //Data to be entered
                    String tName = iTypeView.AddIncidentTypeTxt.Text;


                    // create object to send to the database
                    IncidentType tType = new IncidentType();
                    tType.incident_type = tName;


                    // add to database
                    trainTypeRepos.insert(tType);
                    trainTypeRepos.save();
                    MessageBox.Show("Incident Type Added");
                    iTypeValid.clearAddTxtBoxes();
                }
                else { MessageBox.Show("Please fill in the Required Fields"); }

             } else if (sender == iTypeView.EditSubmitBtn1) {

                if (iTypeValid.onClickEditValidate() == true)
                {
                    trainTypeRepos = new GenericRepository<IncidentType>();
                    ComboboxValue tmpComboboxValue = (ComboboxValue)iTypeView.EditSelectIBox1.SelectedItem;
                    //Data to be entered
                    String tName = iTypeView.EditIncidentTypeTxt.Text;

                    // create object to send to the database
                    IncidentType tType = new IncidentType();
                    tType.IncidentType_Id = tmpComboboxValue.Id;
                    tType.incident_type = tName;

                    // add to database
                    trainTypeRepos.update(tType);
                    trainTypeRepos.save();
                    MessageBox.Show("Incident Type Updated");
                    iTypeValid.clearEditTxtBoxes();
                    iTypeView.EditSelectIBox1.SelectedIndex = -1;
                    updateTypeBox();
                    iTypeValid.lockEdit();
                }
                else { MessageBox.Show("fill in the required Fields"); }





            }else if (sender == iTypeView.DelBtn1)
            {
                if (iTypeView.DelSelectIBox.SelectedIndex != -1)
                {

               
                        string message = "Do you want to delete " + iTypeView.DelSelectIBox.Text + " Incident type";
                        string title = "Delete Incident Type!";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {
                            trainTypeRepos = new GenericRepository<IncidentType>();
                            ComboboxValue tmpComboboxValue = (ComboboxValue)iTypeView.DelSelectIBox.SelectedItem;
                            //Data to be entered
                            String tName = iTypeView.EditIncidentTypeTxt.Text;
                            // create object to send to the database
                            IncidentType tType = new IncidentType();
                            tType.IncidentType_Id = tmpComboboxValue.Id;
                            tType.incident_type = tName;
                            // add to database
                            trainTypeRepos.delete(tType);
                            trainTypeRepos.save();
                            iTypeView.DelSelectIBox.SelectedIndex = -1;
                            updateTypeBox();
                             MessageBox.Show("Incident Type Deleted");

                    }
                    
                }
                else { MessageBox.Show("Select Incident Type"); }
            }

            }


        
        

        public void MyIndexChange(object sender, EventArgs e)
        {
            if (sender == iTypeView.EditSelectIBox1)
            {
                if (iTypeView.EditSelectIBox1.SelectedIndex != -1)
                {
                    iTypeValid.unlockEdit();
                    ComboboxValue tmpComboboxValue = (ComboboxValue)iTypeView.EditSelectIBox1.SelectedItem;
                    IncidentType selectedType = (IncidentType)SingleType(tmpComboboxValue.Id);
                    iTypeView.EditIncidentTypeTxt.Text = selectedType.incident_type;

                    int count = iTypeView.EditSelectIBox1.Items.Count;
                    if (count != 0)
                    {
                        iTypeValid.unlockEdit();
                    }
                    else
                    {
                        iTypeValid.lockEdit();

                    }


                }

            }
            else if (sender == iTypeView.DelSelectIBox)
            {
                if (iTypeView.DelSelectIBox.SelectedIndex != -1)
                {
                    iTypeValid.unlockDel();
                }
            }
        }

        public void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (iTypeView.EditSelectIBox1.Text == "" )
            {

                iTypeValid.lockEdit();

            }
            else
            {
                iTypeValid.unlockEdit();
            }
            updateTypeBox();


            if (iTypeView.getTabindex() == 2) {
                if (iTypeView.DelSelectIBox.SelectedIndex == -1)
                {
                    iTypeValid.lockDel();
                }
                else { iTypeValid.unlockDel(); }
            }
        }

        public void updateTypeBox()
        {
            // loop data into combo box 
            IEnumerable<IncidentType> tTypes = trainTypeRepos.SelectAll();
            iTypeView.EditSelectIBox1.Items.Clear();
            iTypeView.DelSelectIBox.Items.Clear();

            foreach (var item in tTypes)
            {
                iTypeView.EditSelectIBox1.Items.Add(new ComboboxValue(item.IncidentType_Id, item.incident_type));
                iTypeView.DelSelectIBox.Items.Add(new ComboboxValue(item.IncidentType_Id, item.incident_type));
            }
        }


        public void textBox_Validating(object sender, CancelEventArgs e)
        {

            iTypeValid.onChangeAddValidate();
            iTypeValid.onChangeEditValidate();
        }


        public IncidentType SingleType(int id)
        {
            IEnumerable<IncidentType> GeoTests = trainTypeRepos.SelectAll();
            foreach (var test in GeoTests)
            {
                if (test.IncidentType_Id == id)
                {
                    return test;
                }

            }


            return null;
        }
    }
}
