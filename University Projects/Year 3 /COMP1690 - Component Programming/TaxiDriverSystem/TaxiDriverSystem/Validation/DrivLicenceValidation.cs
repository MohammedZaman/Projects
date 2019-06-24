using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TaxiDriverSystem.View;

namespace TaxiDriverSystem.Validation
{
    public class DrivLicenceValidation
    {
        private DrivingLicenceView driLicView = new DrivingLicenceView();

        public DrivLicenceValidation(DrivingLicenceView view)
        {
            this.driLicView = view;

        }

        public void onChangeAddValidate()
        {
            if (string.IsNullOrEmpty(driLicView.SelectDBox1.Text.Trim()))
            {
                driLicView.ErrorProvider1.SetError(driLicView.SelectDBox1, "No Driver Selected");
            }
            else { driLicView.ErrorProvider1.SetError(driLicView.SelectDBox1, string.Empty); }

            if (string.IsNullOrEmpty(driLicView.AddDriverNumTxt.Text.Trim()))
            {
                driLicView.ErrorProvider1.SetError(driLicView.AddDriverNumTxt, "Driver Number Required");
            }
            else { driLicView.ErrorProvider1.SetError(driLicView.AddDriverNumTxt, string.Empty); }

            if (string.IsNullOrEmpty(driLicView.ExpiryPicker.Text.Trim()))
            {
                driLicView.ErrorProvider1.SetError(driLicView.ExpiryPicker, "Select Expiry Date");
            }
            else { driLicView.ErrorProvider1.SetError(driLicView.ExpiryPicker, string.Empty); }

            
            if (!Regex.IsMatch(driLicView.AddDriverNumTxt.Text, "^([A-Z]{2}[9]{3}|[A-Z]{3}[9]{2}|[A-Z]{4}[9]{1}|[A-Z]{5})[0-9]{6}([A-Z]{1}[9]{1}|[A-Z]{2})[A-Z0,9]{3}$"))
            {
                driLicView.ErrorProvider1.SetError(driLicView.AddDriverNumTxt, "Not a Valid Driver Number");
            }
            else { driLicView.ErrorProvider1.SetError(driLicView.AddDriverNumTxt, string.Empty); }
           
        }



        public void onChangeEditValidate()
        {
            if (string.IsNullOrEmpty(driLicView.EditSelectDBox1.Text.Trim()))
            {
                driLicView.ErrorProvider2.SetError(driLicView.EditSelectDBox1, "No Driver Selected");
            }
            else { driLicView.ErrorProvider2.SetError(driLicView.EditSelectDBox1, string.Empty); }

            if (string.IsNullOrEmpty(driLicView.EditDriverNumTxt.Text.Trim()))
            {
                driLicView.ErrorProvider2.SetError(driLicView.EditDriverNumTxt, "Driver Number Required");
            }
            else { driLicView.ErrorProvider2.SetError(driLicView.EditDriverNumTxt, string.Empty); }

            if (string.IsNullOrEmpty(driLicView.EditExpiryPicker.Text.Trim()))
            {
                driLicView.ErrorProvider2.SetError(driLicView.EditExpiryPicker, "Select Expiry Date");
            }
            else { driLicView.ErrorProvider2.SetError(driLicView.EditExpiryPicker, string.Empty); }

            
            if (!Regex.IsMatch(driLicView.EditDriverNumTxt.Text, "^([A-Z]{2}[9]{3}|[A-Z]{3}[9]{2}|[A-Z]{4}[9]{1}|[A-Z]{5})[0-9]{6}([A-Z]{1}[9]{1}|[A-Z]{2})[A-Z0,9]{3}$"))
            {

                driLicView.ErrorProvider2.SetError(driLicView.EditDriverNumTxt, "Not a Valid Driver Number");
            }
            else { driLicView.ErrorProvider2.SetError(driLicView.EditDriverNumTxt, string.Empty); }
            

        }



        public Boolean onClickAddValidate()
        {
            bool isOk = false;
            if (driLicView.SelectDBox1.Text == String.Empty)
            {
                isOk = false;
                driLicView.ErrorProvider1.SetError(driLicView.SelectDBox1, "No Driver Selected");
            }
            else if (driLicView.AddDriverNumTxt.Text == String.Empty)
            {
                isOk = false;
                driLicView.ErrorProvider1.SetError(driLicView.AddDriverNumTxt, "Driver Number Required");
            }
            else if (driLicView.ExpiryPicker.Text == String.Empty)
            {
                isOk = false;
                driLicView.ErrorProvider1.SetError(driLicView.ExpiryPicker, "Select Expiry Date");
            }
           
            else if (!Regex.IsMatch(driLicView.AddDriverNumTxt.Text, "^([A-Z]{2}[9]{3}|[A-Z]{3}[9]{2}|[A-Z]{4}[9]{1}|[A-Z]{5})[0-9]{6}([A-Z]{1}[9]{1}|[A-Z]{2})[A-Z0,9]{3}$"))
            {
                isOk = false;
                driLicView.ErrorProvider1.SetError(driLicView.AddDriverNumTxt, "Not a Valid Driver Number");
            }
            
            else { isOk = true; }
            return isOk;

        }

        public Boolean onClickEditValidate()
        {
            bool isOk = false;
            if (driLicView.EditSelectDBox1.SelectedIndex == -1)
            {
                isOk = false;
                driLicView.ErrorProvider1.SetError(driLicView.EditSelectDBox1, "No Driver Selected");
            }
            else if (driLicView.EditDriverNumTxt.Text == String.Empty)
            {
                isOk = false;
                driLicView.ErrorProvider1.SetError(driLicView.EditDriverNumTxt, "Driver Number Required");
            }
            
            else if (driLicView.EditExpiryPicker.Text == String.Empty)
            {
                isOk = false;
                driLicView.ErrorProvider1.SetError(driLicView.EditExpiryPicker, "Select Expiry Date");
            }
           
            else if (!Regex.IsMatch(driLicView.EditDriverNumTxt.Text, "^([A-Z]{2}[9]{3}|[A-Z]{3}[9]{2}|[A-Z]{4}[9]{1}|[A-Z]{5})[0-9]{6}([A-Z]{1}[9]{1}|[A-Z]{2})[A-Z0,9]{3}$"))
            {
                isOk = false;
                driLicView.ErrorProvider1.SetError(driLicView.EditDriverNumTxt, "Not a Valid Driver Number");
            }
           
            else { isOk = true; }
            return isOk;

        }



        public void lockInput()
        {
            
            driLicView.EditSelectLicBox.Enabled = false;
            driLicView.EditDriverNumTxt.Enabled = false;
            driLicView.EditExpiryPicker.Enabled = false;
            driLicView.EditSubmitBtn1.Enabled = false;

        }

        public void unlockInput()
        {
            driLicView.EditSelectLicBox.Enabled = true;
            driLicView.EditDriverNumTxt.Enabled = true;
            driLicView.EditExpiryPicker.Enabled = true;
            driLicView.EditSubmitBtn1.Enabled = true;


        }


        public void deleteTabLockBtn()
        {
            driLicView.DelBtn1.Enabled = false;
            driLicView.DelSelectLicBox1.Enabled = false;

        }

        public void deleteTabUnlockBtn()
        {
            driLicView.DelBtn1.Enabled = true;
            driLicView.DelSelectLicBox1.Enabled = true;
        }

        public void clearAddTxtBoxes()
        {

            driLicView.AddDriverNumTxt.Clear();
            driLicView.SelectDBox1.SelectedIndex = -1;
            driLicView.ExpiryPicker.Value = System.DateTime.Now;
        }


    }
}
