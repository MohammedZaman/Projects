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
using TaxiDriverSystem.Security.Encryption;

namespace TaxiDriverSystem.Controller
{


    public class DriverController: IController
    {
        private IRepository<Driver> driverRepos;
        private DriverView crudView;
        private DriverValidation driverValid;
        private PasswordEncrypt encrypt;
        public DriverController(DriverView view)
        {
            this.driverRepos = new GenericRepository<Driver>();
            this.crudView = view;
            view.ActivateView(this);// addding event handlers to buttons
            this.driverValid = new DriverValidation(crudView);
            this.encrypt = new PasswordEncrypt();
        }

        public void MyClickEvent(object sender, EventArgs e)
        {
            // events from the Crudview

            // Add Driver 
            if (sender == crudView.AddSubmitBtn)
            {
                if (driverValid.onClickAddValidate() == true && crudView.AddPhoneComp.PhoneTxtBox.TextLength == 13)
                {

                    //Data to be entered
                    String fName = crudView.FirstNameTxt.Text;
                    String lName = crudView.LastNameTxt.Text;
                    DateTime dob = crudView.DobPicker.Value;
                    String phoneNum = crudView.AddPhoneComp.getPhoneNumber();
                    String userName = crudView.UserNameTxt.Text;
                    String password = crudView.PasswordTxt.Text;

                    // create object to send to the database
                    Driver driver = new Driver();
                    driver.First_Name = fName;
                    driver.Last_Name = lName;
                    driver.Date_Of_Birth = dob;
                    driver.PhoneNumber = phoneNum;
                    driver.User_Name = userName;
                    driver.Password = encrypt.GetSha1(password);

                    // add to database
                    driverRepos.insert(driver);
                    driverRepos.save();
                    MessageBox.Show("Driver Added");
                    driverValid.clearAddTxtBoxes();
                }
                else { MessageBox.Show("Please fill in the Required Fields"); }

            }
            // edit driver  
            else if (sender == crudView.EditSubmitBtn) {
                
                    if (driverValid.onClickEditValidate() == true  &&  crudView.EditPhoneComp1.PhoneTxtBox.TextLength == 13)
                    {
                        //Data to be entered
                        String fName = crudView.EditFirstNameTxt.Text;
                        String lName = crudView.EditLastNameTxt.Text;
                        DateTime dob = crudView.EditDobPicker.Value;
                        String phoneNum = crudView.EditPhoneComp1.PhoneTxtBox.Text;
                        String userName = crudView.EditUserNameTxt1.Text;
                        String password = crudView.EditPasswordTxt.Text;

                        // this object is used add value and name to a combobox
                        ComboboxValue tmpComboboxValue = (ComboboxValue)crudView.DriverCBox.SelectedItem;

                        // create object to send to the database
                        Driver driver = new Driver();
                        driver.Driver_Id = tmpComboboxValue.Id;
                        driver.First_Name = fName;
                        driver.Last_Name = lName;
                        driver.Date_Of_Birth = dob;
                        driver.PhoneNumber = phoneNum;
                        driver.User_Name = userName;
                        driver.Password = encrypt.GetSha1(password);// password converted to SHA1 for security

                        // new repos created for some reason using the same repos object does not upload
                        GenericRepository<Driver> driverRepos1 = new GenericRepository<Driver>();

                        // upload to database through repos/linq
                        driverRepos1.update(driver);
                        driverRepos1.save();
                        MessageBox.Show("Driver Updated");
                    }
                    else { MessageBox.Show("Please fill in the Required Fields"); }
                
            }
            // Delete Driver
            else if (sender == crudView.DeleteBtn) {

                string message = "Do you want to delete driver";
                string title = "Delete Driver!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                ComboboxValue tmpComboboxValue = (ComboboxValue)crudView.DelDriverCBox.SelectedItem;
                if (result == DialogResult.Yes)
                {
                    Driver delDriver = new Driver();
                    delDriver.Driver_Id = tmpComboboxValue.Id;
                    GenericRepository<Driver> DriverDel = new GenericRepository<Driver>();
                    DriverDel.delete(delDriver);
                    DriverDel.save();
                    MessageBox.Show("Driver Deleted");
                    updateDriverBox();
                    crudView.DelDriverCBox.SelectedIndex = -1;
                }

            }

        }


        
        



        // Combo box index events 
        public void MyIndexChange(object sender, EventArgs e)
        {
            if (sender == crudView.DriverCBox) {
                if (crudView.DriverCBox.SelectedIndex != -1) {
                    driverValid.unlockTextBoxes();
                    ComboboxValue tmpComboboxValue = (ComboboxValue)crudView.DriverCBox.SelectedItem;
                    Driver selectedDriver = (Driver)SingleDriver(tmpComboboxValue.Id);
                    crudView.EditFirstNameTxt.Text = selectedDriver.First_Name;
                    crudView.EditLastNameTxt.Text = selectedDriver.Last_Name;
                    if (selectedDriver.Date_Of_Birth != null)
                    {
                        crudView.EditDobPicker.Value = (DateTime)selectedDriver.Date_Of_Birth;
                    }
                    crudView.EditPhoneComp1.PhoneTxtBox.Text = selectedDriver.PhoneNumber;
                    crudView.EditUserNameTxt1.Text = selectedDriver.User_Name;
                    //geoView.EditPasswordTxt.Text = selectedDriver.Password;
                }
            }

            if (sender == crudView.DelDriverCBox)
            {
                driverValid.deleteTabUnlockBtn();

               
            }



        }

        // tab change event handler
        public void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (crudView.getTabindex() == 1)
            {
                
                if (string.IsNullOrEmpty(crudView.DriverCBox.Text))
                {
                    driverValid.lockTextBoxes();
                }
               
            }

            if (crudView.getTabindex() == 2) {
                if (string.IsNullOrEmpty(crudView.DelDriverCBox.Text))
                {
                    driverValid.deleteTabLockBtn();
                }
               
            }
           
                updateDriverBox();
        }


        public void updateDriverBox() {
            // loop data into combo box 
            IEnumerable<Driver> drivers = driverRepos.SelectAll();
            crudView.DriverCBox.Items.Clear();
            crudView.DelDriverCBox.Items.Clear();

            foreach (var item in drivers)
            {
                crudView.DriverCBox.Items.Add(new ComboboxValue(item.Driver_Id, item.First_Name));
                crudView.DelDriverCBox.Items.Add(new ComboboxValue(item.Driver_Id, item.First_Name));
            }
        }


        // validation event handlers
        public void textBox_Validating(object sender, CancelEventArgs e)
        {
            driverValid.onChangeAddValidate();
            driverValid.onChangeEditValidate();

        }





       



        public Driver SingleDriver (int id){
           IEnumerable<Driver> drivers =  driverRepos.SelectAll();
            foreach (var item in drivers)
            {
                if (item.Driver_Id == id) {
                    return item;
                }
              
            }


            return null;
        }


       
    }
}
