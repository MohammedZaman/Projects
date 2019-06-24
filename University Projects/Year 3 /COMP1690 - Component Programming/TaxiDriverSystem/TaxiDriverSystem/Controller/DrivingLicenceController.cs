using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiDriverSystem.InnerJoin;
using TaxiDriverSystem.Interfaces;
using TaxiDriverSystem.Misc;
using TaxiDriverSystem.Repositories;
using TaxiDriverSystem.Validation;
using TaxiDriverSystem.View;

namespace TaxiDriverSystem.Controller
{
    public class DrivingLicenceController : IController
    {
        private GenericRepository<DrivingLicence> driLicRepos;
        private DrivingLicenceView driLicView;
        private DrivLicenceValidation driLicValid;
        public DrivingLicenceController(DrivingLicenceView view)
        {
            this.driLicRepos = new GenericRepository<DrivingLicence>();
            this.driLicView = view;
            view.ActivateView(this);// addding event handlers to buttons
            this.driLicValid = new DrivLicenceValidation(driLicView);
            updateDriverBox();
        }

        public void MyClickEvent(object sender, EventArgs e)
        {
            if (sender == driLicView.AddSubmitBtn1)
            {

                if (driLicValid.onClickAddValidate() == true)
                {
                    ComboboxValue tmpComboboxValue = (ComboboxValue)driLicView.SelectDBox1.SelectedItem;
                    int driverId = tmpComboboxValue.Id;
                    string driNum = driLicView.AddDriverNumTxt.Text;
                    DateTime expiryDate = driLicView.ExpiryPicker.Value;

                    DrivingLicence drvLicnece = new DrivingLicence();
                    drvLicnece.Driver_Id = driverId;
                    drvLicnece.Driver_number = driNum;
                    drvLicnece.Expiry_date = expiryDate;
                    driLicRepos.insert(drvLicnece);
                    driLicRepos.save();


                    MessageBox.Show("Driving Licence Added");
                    driLicValid.clearAddTxtBoxes();
                }
                else { MessageBox.Show("Please fill in the Required Fields"); }


            }
            else if (sender == driLicView.EditSubmitBtn1)
            {
                if (driLicValid.onClickEditValidate() == true)
                {
                    if (driLicView.EditSelectLicBox.SelectedIndex != -1)
                    {
                        ComboboxValue tmpComboboxValue = (ComboboxValue)driLicView.EditSelectDBox1.SelectedItem;
                        ComboboxValue lic = (ComboboxValue)driLicView.EditSelectLicBox.SelectedItem;
                        int driverId = tmpComboboxValue.Id;
                        string driNum = driLicView.EditDriverNumTxt.Text;
                        DateTime expiryDate = driLicView.EditExpiryPicker.Value;

                        driLicRepos = new GenericRepository<DrivingLicence>();
                        DrivingLicence DriLic = new DrivingLicence();
                        DriLic.Driver_Id = driverId;
                        DriLic.Driver_number = driNum;
                        DriLic.Expiry_date = expiryDate;
                        DriLic.DrvingLicence_Id = lic.Id;
                        driLicRepos.update(DriLic);
                        driLicRepos.save();
                        MessageBox.Show("Driving Licence Updated");
                        updateDriLicBox(tmpComboboxValue.Id);
                    }
                }
                else { MessageBox.Show("Please fill in the Required Fields"); }
            }
            else if (sender == driLicView.DelBtn1)
            {

                if (driLicView.DelSelectLicBox1.SelectedIndex != -1)
                {
                    string message = "Do you want to delete " + driLicView.EditSelectDBox1.Text + " Driving Licence ";
                    string title = "Delete Driving Licence! ";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    ComboboxValue driverBox = (ComboboxValue)driLicView.DelSelectDBox1.SelectedItem;
                    ComboboxValue tmpComboboxValue = (ComboboxValue)driLicView.DelSelectLicBox1.SelectedItem;
                    if (result == DialogResult.Yes)
                    {
                        DrivingLicence delTest = new DrivingLicence();
                        delTest.DrvingLicence_Id= tmpComboboxValue.Id;
                        delTest.Driver_Id = driverBox.Id;
                        driLicRepos = new GenericRepository<DrivingLicence>();
                        driLicRepos.delete(delTest);
                        driLicRepos.save();
                        MessageBox.Show(driLicView.DelSelectDBox1.Text + "'s Driving Licence deleted");
                        //updateDriverBox();
                        driLicView.DelSelectLicBox1.SelectedIndex = -1;
                        updateDriLicBox(driverBox.Id);
                    }
                }
                else { MessageBox.Show("Select Driving Licence"); }
            }


        }


        public void MyIndexChange(object sender, EventArgs e)
        {
            if (sender == driLicView.EditSelectDBox1)
            {
                if (driLicView.EditSelectDBox1.SelectedIndex != -1)
                {
                    ComboboxValue tmpComboboxValue = (ComboboxValue)driLicView.EditSelectDBox1.SelectedItem;
                    updateDriLicBox(tmpComboboxValue.Id);
                    int count = driLicView.EditSelectLicBox.Items.Count;
                    if (count != 0)
                    {
                        driLicValid.unlockInput();
                        driLicView.EditErrLbl.Text = "";
                    }
                    else
                    {
                        driLicValid.lockInput();
                        driLicView.EditErrLbl.Text = "Driver has no Licence";
                    }
                }

            }

            if (sender == driLicView.EditSelectLicBox)
            {
                ComboboxValue tmpTest = (ComboboxValue)driLicView.EditSelectLicBox.SelectedItem;
                if (tmpTest != null)
                {
                    InnerJoinRepository driLic = new InnerJoinRepository();
                    ComboboxValue tmpComboboxValue = (ComboboxValue)driLicView.EditSelectDBox1.SelectedItem;
                    List<DriLicence> list = driLic.DriverLic(tmpComboboxValue.Id);
                    DrivingLicence test = SingleDriLicence(tmpTest.Id);
                    driLicView.EditDriverNumTxt.Text = test.Driver_number;
                    driLicView.EditExpiryPicker.Value = (DateTime)test.Expiry_date;



                }
            }

            if (sender == driLicView.DelSelectDBox1)
            {
                ComboboxValue tmpComboboxValue = (ComboboxValue)driLicView.DelSelectDBox1.SelectedItem;
                if (tmpComboboxValue != null)
                {
                    driLicView.DelSelectLicBox1.SelectedIndex = -1;
                    updateDriLicBox(tmpComboboxValue.Id);
                    int count = driLicView.DelSelectLicBox1.Items.Count;
                    if (count != 0)
                    {
                        driLicValid.deleteTabUnlockBtn();
                        driLicView.DelErrLbl.Text = "";
                    }
                    else
                    {
                        driLicValid.deleteTabLockBtn();
                        driLicView.DelErrLbl.Text = "Driver has no Licence";
                    }

                }


            }


        }


        public void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (driLicView.getTabindex() == 1)
            {

                if (string.IsNullOrEmpty(driLicView.EditSelectDBox1.Text))
                {
                    driLicValid.lockInput();
                }

            }

            if (driLicView.getTabindex() == 2)
            {
                if (string.IsNullOrEmpty(driLicView.DelSelectDBox1.Text))
                {
                    driLicValid.deleteTabLockBtn();
                }

            }

            updateDriverBox();


        }

        public void textBox_Validating(object sender, CancelEventArgs e)
        {
            driLicValid.onChangeAddValidate();
            driLicValid.onChangeEditValidate();
        }

        public void updateDriverBox()
        {
            GenericRepository<Driver> driverRepos = new GenericRepository<Driver>();
            // loop data into combo box 
            IEnumerable<Driver> drivers = driverRepos.SelectAll();
            driLicView.SelectDBox1.Items.Clear();
            driLicView.EditSelectDBox1.Items.Clear();
            driLicView.DelSelectDBox1.Items.Clear();

            foreach (var item in drivers)
            {
                driLicView.SelectDBox1.Items.Add(new ComboboxValue(item.Driver_Id, item.First_Name));
                driLicView.EditSelectDBox1.Items.Add(new ComboboxValue(item.Driver_Id, item.First_Name));
                driLicView.DelSelectDBox1.Items.Add(new ComboboxValue(item.Driver_Id, item.First_Name));

            }
        }

        public void updateDriLicBox(int driverId)
        {
            driLicView.EditSelectLicBox.SelectedIndex = -1;
            driLicView.EditSelectLicBox.Items.Clear();
            driLicView.EditDriverNumTxt.Text = "";
            driLicView.EditExpiryPicker.Value = DateTime.Now;
            IEnumerable<DrivingLicence> GeoTests = driLicRepos.SelectAll();
            driLicView.EditSelectLicBox.Items.Clear();
            driLicView.DelSelectLicBox1.Items.Clear();

            foreach (var item in GeoTests)
            {
                if (item.Driver_Id == driverId)
                {
                    driLicView.EditSelectLicBox.Items.Add(new ComboboxValue(item.DrvingLicence_Id, item.Driver_number));
                    driLicView.DelSelectLicBox1.Items.Add(new ComboboxValue(item.DrvingLicence_Id, item.Driver_number));
                }

            }
        }



        public DrivingLicence SingleDriLicence(int id)
        {
            IEnumerable<DrivingLicence> driLic = driLicRepos.SelectAll();
            foreach (var test in driLic)
            {
                if (test.DrvingLicence_Id == id)
                {
                    return test;
                }

            }


            return null;
        }


    }
}
