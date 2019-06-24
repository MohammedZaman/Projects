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
    public class TrainTypeController : IController
    {
        private IRepository<TrainingType> trainTypeRepos;
        private TrainTypeView tTypeView;
        private TrainTypeValidation trainTypeValid;
        public TrainTypeController(TrainTypeView view) {
            this.trainTypeRepos = new GenericRepository<TrainingType>();
            this.tTypeView = view;
            view.ActivateView(this);
            this.trainTypeValid = new TrainTypeValidation(view);
        


        }

        public void MyClickEvent(object sender, EventArgs e)
        {
            if (sender == tTypeView.AddSubmitBtn1)
            {
                if (trainTypeValid.onClickAddValidate() == true)
                {

                    //Data to be entered
                    String tName = tTypeView.AddTrainTypeTxt.Text;


                    // create object to send to the database
                    TrainingType tType = new TrainingType();
                    tType.Training_name = tName;


                    // add to database
                    trainTypeRepos.insert(tType);
                    trainTypeRepos.save();
                    MessageBox.Show("Training Type Added");
                    trainTypeValid.clearAddTxtBoxes();
                }
                else { MessageBox.Show("Please fill in the Required Fields"); }

             } else if (sender == tTypeView.EditSubmitBtn1) {

                if (trainTypeValid.onClickEditValidate() == true)
                {
                    trainTypeRepos = new GenericRepository<TrainingType>();
                    ComboboxValue tmpComboboxValue = (ComboboxValue)tTypeView.EditSelectTBox1.SelectedItem;
                    //Data to be entered
                    String tName = tTypeView.EditTrainTypeTxt.Text;

                    // create object to send to the database
                    TrainingType tType = new TrainingType();
                    tType.TrainingType_Id = tmpComboboxValue.Id;
                    tType.Training_name = tName;

                    // add to database
                    trainTypeRepos.update(tType);
                    trainTypeRepos.save();
                    MessageBox.Show("Training Type Updated");
                    trainTypeValid.clearEditTxtBoxes();
                    tTypeView.EditSelectTBox1.SelectedIndex = -1;
                    updateTypeBox();
                    trainTypeValid.lockEdit();
                }
                else { MessageBox.Show("fill in the required Fields"); }





            }else if (sender == tTypeView.DelBtn1)
            {
                if (tTypeView.DelSelectTBox.SelectedIndex != -1)
                {

               
                        string message = "Do you want to delete " + tTypeView.DelSelectTBox.Text + " Training Type";
                        string title = "Delete Training Type!";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {
                            trainTypeRepos = new GenericRepository<TrainingType>();
                            ComboboxValue tmpComboboxValue = (ComboboxValue)tTypeView.DelSelectTBox.SelectedItem;
                            //Data to be entered
                            String tName = tTypeView.EditTrainTypeTxt.Text;
                            // create object to send to the database
                            TrainingType tType = new TrainingType();
                            tType.TrainingType_Id = tmpComboboxValue.Id;
                            tType.Training_name = tName;
                            // add to database
                            trainTypeRepos.delete(tType);
                            trainTypeRepos.save();
                            tTypeView.DelSelectTBox.SelectedIndex = -1;
                            updateTypeBox();
                           MessageBox.Show("Training Type is deleted");

                    }
                    
                }
                else { MessageBox.Show("Select Training Type"); }
            }

            }


        
        

        public void MyIndexChange(object sender, EventArgs e)
        {
            if (sender == tTypeView.EditSelectTBox1)
            {
                if (tTypeView.EditSelectTBox1.SelectedIndex != -1)
                {
                    trainTypeValid.unlockEdit();
                    ComboboxValue tmpComboboxValue = (ComboboxValue)tTypeView.EditSelectTBox1.SelectedItem;
                    TrainingType selectedType = (TrainingType)SingleType(tmpComboboxValue.Id);
                    tTypeView.EditTrainTypeTxt.Text = selectedType.Training_name;

                    int count = tTypeView.EditSelectTBox1.Items.Count;
                    if (count != 0)
                    {
                        trainTypeValid.unlockEdit();
                    }
                    else
                    {
                        trainTypeValid.lockEdit();

                    }


                }

            }
            else if (sender == tTypeView.DelSelectTBox)
            {
                if (tTypeView.DelSelectTBox.SelectedIndex != -1)
                {
                    trainTypeValid.unlockDel();
                }
            }
        }

        public void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tTypeView.EditSelectTBox1.Text == "" )
            {

                trainTypeValid.lockEdit();

            }
            else
            {
                trainTypeValid.unlockEdit();
            }
            updateTypeBox();


            if (tTypeView.getTabindex() == 2) {
                if (tTypeView.DelSelectTBox.SelectedIndex == -1)
                {
                    trainTypeValid.lockDel();
                }
                else { trainTypeValid.unlockDel(); }
            }
        }

        public void updateTypeBox()
        {
            // loop data into combo box 
            IEnumerable<TrainingType> tTypes = trainTypeRepos.SelectAll();
            tTypeView.EditSelectTBox1.Items.Clear();
            tTypeView.DelSelectTBox.Items.Clear();

            foreach (var item in tTypes)
            {
                tTypeView.EditSelectTBox1.Items.Add(new ComboboxValue(item.TrainingType_Id, item.Training_name));
                tTypeView.DelSelectTBox.Items.Add(new ComboboxValue(item.TrainingType_Id, item.Training_name));
            }
        }


        public void textBox_Validating(object sender, CancelEventArgs e)
        {

            trainTypeValid.onChangeAddValidate();
            trainTypeValid.onChangeEditValidate();
        }


        public TrainingType SingleType(int id)
        {
            IEnumerable<TrainingType> GeoTests = trainTypeRepos.SelectAll();
            foreach (var test in GeoTests)
            {
                if (test.TrainingType_Id == id)
                {
                    return test;
                }

            }


            return null;
        }
    }
}
