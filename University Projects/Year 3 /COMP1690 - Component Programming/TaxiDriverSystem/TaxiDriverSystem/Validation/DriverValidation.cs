using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiDriverSystem.View;

namespace TaxiDriverSystem.Validation
{
    public class DriverValidation
    {
        private DriverView crudView = new DriverView();

        public DriverValidation(DriverView cView) {
            this.crudView = cView;

        }

        public void onChangeAddValidate(){
            if (string.IsNullOrEmpty(crudView.FirstNameTxt.Text.Trim()))
            {
                crudView.ErrorProvider1.SetError(crudView.FirstNameTxt, "First Name is required.");
            }
            else { crudView.ErrorProvider1.SetError(crudView.FirstNameTxt, string.Empty); }


            if (string.IsNullOrEmpty(crudView.LastNameTxt.Text.Trim()))
            {
                crudView.ErrorProvider1.SetError(crudView.LastNameTxt, "last Name is required.");
            }
            else { crudView.ErrorProvider1.SetError(crudView.LastNameTxt, string.Empty); }


            if (string.IsNullOrEmpty(crudView.UserNameTxt.Text.Trim()))
            {
                crudView.ErrorProvider1.SetError(crudView.UserNameTxt, "User Name is required.");
            }
            else
            { crudView.ErrorProvider1.SetError(crudView.UserNameTxt, string.Empty); }


            if (string.IsNullOrEmpty(crudView.PasswordTxt.Text.Trim()))
            {
                crudView.ErrorProvider1.SetError(crudView.PasswordTxt, "Password is required.");
            }
            else
            { crudView.ErrorProvider1.SetError(crudView.PasswordTxt, string.Empty); }

            if (string.IsNullOrEmpty(crudView.AddPhoneComp.PhoneTxtBox.Text.Trim()))
            {
                crudView.ErrorProvider1.SetError(crudView.AddPhoneComp.PhoneTxtBox, "Phone Number is required.");
            }
            else { crudView.ErrorProvider1.SetError(crudView.AddPhoneComp.PhoneTxtBox, string.Empty); }


        }

        public void onChangeEditValidate()
        {
            if (string.IsNullOrEmpty(crudView.EditFirstNameTxt.Text.Trim()))
            {
                crudView.ErrorProvider2.SetError(crudView.EditFirstNameTxt, "First Name is required.");
            }
            else { crudView.ErrorProvider2.SetError(crudView.EditFirstNameTxt, string.Empty); }


            if (string.IsNullOrEmpty(crudView.EditLastNameTxt.Text.Trim()))
            {
                crudView.ErrorProvider2.SetError(crudView.EditLastNameTxt, "last Name is required.");
            }
            else { crudView.ErrorProvider2.SetError(crudView.EditLastNameTxt, string.Empty); }


            if (string.IsNullOrEmpty(crudView.EditUserNameTxt1.Text.Trim()))
            {
                crudView.ErrorProvider2.SetError(crudView.EditUserNameTxt1, "User Name is required.");
            }
            else
            { crudView.ErrorProvider2.SetError(crudView.EditUserNameTxt1, string.Empty); }


            if (string.IsNullOrEmpty(crudView.EditPasswordTxt.Text.Trim()))
            {
                crudView.ErrorProvider2.SetError(crudView.EditPasswordTxt, "Password is required.");
            }
            else
            { crudView.ErrorProvider2.SetError(crudView.EditPasswordTxt, string.Empty); }

            if (string.IsNullOrEmpty(crudView.EditPhoneComp1.PhoneTxtBox.Text.Trim()))
            {
                crudView.ErrorProvider2.SetError(crudView.EditPhoneComp1.PhoneTxtBox, "Phone Number is required.");
            }
            else { crudView.ErrorProvider2.SetError(crudView.EditPhoneComp1.PhoneTxtBox, string.Empty); }


        }




        public Boolean onClickAddValidate()
        {
            bool isOk = false;
            if (crudView.FirstNameTxt.Text == String.Empty)
            {
                isOk = false;
                crudView.ErrorProvider1.SetError(crudView.FirstNameTxt, "First Name is required.");
            }
            else if (crudView.LastNameTxt.Text == String.Empty)
            {
                isOk = false;
                crudView.ErrorProvider1.SetError(crudView.LastNameTxt, "last Name is required.");
            }
            else if (crudView.UserNameTxt.Text == String.Empty)
            {
                isOk = false;
                crudView.ErrorProvider1.SetError(crudView.UserNameTxt, "User Name is required.");
            }
            else if (crudView.PasswordTxt.Text == String.Empty)
            {
                isOk = false;
                crudView.ErrorProvider1.SetError(crudView.PasswordTxt, "Password is required.");
            }
            else if (crudView.AddPhoneComp.PhoneTxtBox.Text == String.Empty)
            {
                isOk = false;
                crudView.ErrorProvider1.SetError(crudView.AddPhoneComp.PhoneTxtBox, "Phone Number is required.");
            }
            else { isOk = true; }
            return isOk;

        }


        public Boolean onClickEditValidate()
        {
            bool isOk = false;
            if (crudView.EditFirstNameTxt.Text == String.Empty)
            {
                isOk = false;
                crudView.ErrorProvider2.SetError(crudView.EditFirstNameTxt, "First Name is required.");
            }else if (crudView.EditLastNameTxt.Text == String.Empty)
            {
                isOk = false;
                crudView.ErrorProvider2.SetError(crudView.EditLastNameTxt, "last Name is required.");
            }else if (crudView.EditUserNameTxt1.Text == String.Empty)
            {
                isOk = false;
                crudView.ErrorProvider2.SetError(crudView.EditUserNameTxt1, "User Name is required.");
            }else if (crudView.EditPasswordTxt.Text == String.Empty)
            {
                isOk = false;
                crudView.ErrorProvider2.SetError(crudView.EditPasswordTxt, "Password is required.");
            }else if (crudView.EditPhoneComp1.PhoneTxtBox.Text == String.Empty)
            {
                isOk = false;
                crudView.ErrorProvider2.SetError(crudView.EditPhoneComp1.PhoneTxtBox, "Phone Number is required.");
                crudView.ErrorProvider2.SetError(crudView.DriverCBox, "Select Driver");
            }
            else if (crudView.DriverCBox.SelectedIndex == -1)
            {
            //   ERROR check if Working Properly afterwards 
                isOk = false;
                crudView.ErrorProvider2.SetError(crudView.DriverCBox, "Select Driver");
            }
            else { isOk = true; }
            return isOk;

        }


        public void lockTextBoxes() {
            crudView.EditFirstNameTxt.ReadOnly = true;
            crudView.EditLastNameTxt.ReadOnly = true;
            crudView.EditPasswordTxt.ReadOnly = true;
            crudView.EditPhoneComp1.PhoneTxtBox.ReadOnly = true;
            crudView.EditLastNameTxt.ReadOnly = true;
            crudView.EditUserNameTxt1.ReadOnly = true;
            crudView.EditDobPicker.Enabled = false;
            crudView.EditSubmitBtn.Enabled = false;
        }

        public void unlockTextBoxes()
        {
            crudView.EditFirstNameTxt.ReadOnly = false;
            crudView.EditLastNameTxt.ReadOnly = false;
            crudView.EditPasswordTxt.ReadOnly = false;
            crudView.EditPhoneComp1.PhoneTxtBox.ReadOnly = false;
            crudView.EditLastNameTxt.ReadOnly = false;
            crudView.EditUserNameTxt1.ReadOnly = false;
            crudView.EditDobPicker.Enabled = true;
            crudView.EditSubmitBtn.Enabled = true;


        }


        public void deleteTabLockBtn() {
            crudView.DeleteBtn.Enabled = false;
        }

        public void deleteTabUnlockBtn()
        {
            crudView.DeleteBtn.Enabled = true;
        }

        public void clearAddTxtBoxes() {

            crudView.FirstNameTxt.Clear();
            crudView.LastNameTxt.Clear();
            crudView.PasswordTxt.Clear();
            crudView.AddPhoneComp.PhoneTxtBox.Clear();
            crudView.LastNameTxt.Clear();
            crudView.UserNameTxt.Clear();
            crudView.DobPicker.Value = System.DateTime.Now;
        }


    }
}
