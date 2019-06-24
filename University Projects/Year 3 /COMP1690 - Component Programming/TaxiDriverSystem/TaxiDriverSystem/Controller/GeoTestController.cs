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
using TaxiDriverSystem.Repositories;

namespace TaxiDriverSystem.Controller
{
   public class GeoTestController : IController
    {

        private GenericRepository<GeographicalTest> geoTestRepos;
        private InnerJoinRepository  driverTestsRepos;
        private GeoTestView geoView;
        private GeoTestValidation geoValid;
        public GeoTestController(GeoTestView view)
        {
            this.geoTestRepos = new GenericRepository<GeographicalTest>();
            this.driverTestsRepos = new InnerJoinRepository();
            this.geoView = view;
            view.ActivateView(this);// addding event handlers to buttons
            this.geoValid = new GeoTestValidation(geoView);
            updateDriverBox();
        }


        public void MyClickEvent(object sender, EventArgs e)
        {
            if (sender == geoView.AddSubmit1) {

                if (geoValid.onClickAddValidate() == true)
                {
                    ComboboxValue tmpComboboxValue = (ComboboxValue)geoView.SelectDBox1.SelectedItem;
                    int driverId = tmpComboboxValue.Id;
                    string location = geoView.GeoLocationCBox1.SelectedItem.ToString();
                    Decimal score = Decimal.Parse(geoView.ScoreTxt1.Text);
                    DateTime expiryDate = geoView.ExpiryPicker.Value;

                    GeographicalTest geoTest = new GeographicalTest();
                    geoTest.Driver_Id = driverId;
                    geoTest.Location = location;
                    geoTest.Score = score;
                    geoTest.Expiry_date = expiryDate;
                    geoTestRepos.insert(geoTest);
                    geoTestRepos.save();


                    MessageBox.Show("Geographical Test Added");
                    geoValid.clearAddTxtBoxes();
                }
                else { MessageBox.Show("Please fill in the Required Fields"); }


            } else if (sender == geoView.EditSubmitBtn1) {
                if (geoValid.onClickEditValidate() == true)
                {
                    if (geoView.EditSelectTestBox1.SelectedIndex != -1)
                    {
                        ComboboxValue tmpComboboxValue = (ComboboxValue)geoView.EditSelectDBox1.SelectedItem;
                        ComboboxValue geo = (ComboboxValue)geoView.EditSelectTestBox1.SelectedItem;
                        int driverId = tmpComboboxValue.Id;
                        string location = geoView.EditGeoLocationCBox1.SelectedItem.ToString();
                        Decimal score = Decimal.Parse(geoView.EditScoreTxt1.Text);
                        DateTime expiryDate = geoView.EditExpiryPicker.Value;

                        geoTestRepos = new GenericRepository<GeographicalTest>();
                        GeographicalTest geoTest = new GeographicalTest();
                        geoTest.Driver_Id = driverId;
                        geoTest.Location = location;
                        geoTest.Score = score;
                        geoTest.Expiry_date = expiryDate;
                        geoTest.GeoTest_Id = geo.Id;
                        geoTestRepos.update(geoTest);
                        geoTestRepos.save();
                        MessageBox.Show("Qaulification Updated");

                        updateTestBox(tmpComboboxValue.Id);
                    }
                }
                else { MessageBox.Show("Please fill in the Required Fields"); }
            } else if (sender == geoView.DelBtn1) {

                if (geoView.DelSelectTestBox1.SelectedIndex != -1)
                {
                    string message = "Do you want to delete " + geoView.EditSelectDBox1.Text + " Qualification";
                    string title = "Delete Driver!";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    ComboboxValue driverBox = (ComboboxValue)geoView.DelSelectDBox1.SelectedItem;
                    ComboboxValue tmpComboboxValue = (ComboboxValue)geoView.DelSelectTestBox1.SelectedItem;
                    if (result == DialogResult.Yes)
                    {
                        GeographicalTest delTest = new GeographicalTest();
                        delTest.GeoTest_Id = tmpComboboxValue.Id;
                        delTest.Driver_Id = driverBox.Id;

                        geoTestRepos = new GenericRepository<GeographicalTest>();
                        geoTestRepos.delete(delTest);
                        geoTestRepos.save();
                        MessageBox.Show(geoView.DelSelectDBox1.Text + "'s Qualification deleted");
                        //updateDriverBox();
                        geoView.DelSelectTestBox1.SelectedIndex = -1;
                        updateTestBox(driverBox.Id);
                    }
                }
                else { MessageBox.Show("Select Test"); }
            }


        }


        public void MyIndexChange(object sender, EventArgs e)
        {
            if (sender == geoView.EditSelectDBox1) {
                if (geoView.EditSelectDBox1.SelectedIndex != -1)
                {
                    ComboboxValue tmpComboboxValue = (ComboboxValue)geoView.EditSelectDBox1.SelectedItem;
                    updateTestBox(tmpComboboxValue.Id);
                    int count = geoView.EditSelectTestBox1.Items.Count;
                    if (count != 0)
                    {
                    geoValid.unlockInput();
                    geoView.EditErrLbl.Text = "";
                    }
                    else
                    {
                        geoValid.lockInput();
                        geoView.EditErrLbl.Text = "Driver has no Tests";
                    }
                }

            }

            if (sender == geoView.EditSelectTestBox1) {
                ComboboxValue tmpTest = (ComboboxValue)geoView.EditSelectTestBox1.SelectedItem;
                if (tmpTest != null)
                {
                    
                        ComboboxValue tmpComboboxValue = (ComboboxValue)geoView.EditSelectDBox1.SelectedItem;
                        List<DriverGeoTest> list = driverTestsRepos.DriverGeoTests(tmpComboboxValue.Id);
                        GeographicalTest test = SingleGeoTest(tmpTest.Id);
                        geoView.EditGeoLocationCBox1.SelectedItem = test.Location;
                        geoView.EditScoreTxt1.Text = test.Score.ToString();
                        geoView.EditExpiryPicker.Value = (DateTime)test.Expiry_date;
                       
                  
                   
                }
            }

            if (sender == geoView.DelSelectDBox1)
            {
                ComboboxValue tmpComboboxValue = (ComboboxValue)geoView.DelSelectDBox1.SelectedItem;
                if (tmpComboboxValue != null)
                {
                    geoView.DelSelectTestBox1.SelectedIndex = -1;
                    updateTestBox(tmpComboboxValue.Id);
                    int count = geoView.DelSelectTestBox1.Items.Count;
                    if (count != 0) {
                        geoValid.deleteTabUnlockBtn();
                        geoView.DelErrLbl.Text = "";
                    }
                    else
                    {
                        geoValid.deleteTabLockBtn();
                        geoView.DelErrLbl.Text = "Driver has no Tests";
                    }
                    
                }


            }


        }


        public void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (geoView.getTabindex() == 1)
            {

                if (string.IsNullOrEmpty(geoView.EditSelectDBox1.Text))
                {
                    geoValid.lockInput();
                }

            }

            if (geoView.getTabindex() == 2)
            {
                if (string.IsNullOrEmpty(geoView.DelSelectDBox1.Text))
                {
                    geoValid.deleteTabLockBtn();
                }

            }

            updateDriverBox();


        }

        public void textBox_Validating(object sender, CancelEventArgs e)
        {
            geoValid.onChangeAddValidate();
            geoValid.onChangeEditValidate();
        }

        public void updateDriverBox()
        {
            GenericRepository<Driver> driverRepos = new GenericRepository<Driver>();
            // loop data into combo box 
            IEnumerable<Driver> drivers = driverRepos.SelectAll();
            geoView.SelectDBox1.Items.Clear();
            geoView.EditSelectDBox1.Items.Clear();
            geoView.DelSelectDBox1.Items.Clear();

            foreach (var item in drivers)
            {
                geoView.SelectDBox1.Items.Add(new ComboboxValue(item.Driver_Id, item.First_Name));
                geoView.EditSelectDBox1.Items.Add(new ComboboxValue(item.Driver_Id, item.First_Name));
                geoView.DelSelectDBox1.Items.Add(new ComboboxValue(item.Driver_Id, item.First_Name));

            }
        }

        public void updateTestBox(int driverId)
        {
            geoView.EditSelectTestBox1.SelectedIndex = -1;
            geoView.EditSelectTestBox1.Items.Clear();
            geoView.EditGeoLocationCBox1.SelectedIndex = -1;
            geoView.EditScoreTxt1.Text = "";
            geoView.EditExpiryPicker.Value = DateTime.Now;
            IEnumerable<GeographicalTest> GeoTests = geoTestRepos.SelectAll();
            geoView.EditSelectTestBox1.Items.Clear();
            geoView.DelSelectTestBox1.Items.Clear();

            foreach (var item in GeoTests)
            {
                if (item.Driver_Id == driverId) {
                 geoView.EditSelectTestBox1.Items.Add(new ComboboxValue(item.GeoTest_Id, item.Location));
                 geoView.DelSelectTestBox1.Items.Add(new ComboboxValue(item.GeoTest_Id, item.Location));
                }

            }
        }

       

        public GeographicalTest SingleGeoTest(int id)
        {
            IEnumerable<GeographicalTest> GeoTests = geoTestRepos.SelectAll();
            foreach (var test in GeoTests)
            {
                if (test.GeoTest_Id == id)
                {
                    return test;
                }

            }


            return null;
        }
    }


   
    }
