using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TaxiDriverSystem.View;

namespace TaxiDriverSystem.Validation
{
    public class GeoTestValidation
    {
        private GeoTestView geoTestView = new GeoTestView();

        public GeoTestValidation(GeoTestView view) {
            this.geoTestView = view;

        }

        public void onChangeAddValidate()
        {
            if (string.IsNullOrEmpty(geoTestView.SelectDBox1.Text.Trim()))
            {
               geoTestView.ErrorProvider1.SetError(geoTestView.SelectDBox1, "No Driver Selected");
            }
            else { geoTestView.ErrorProvider1.SetError(geoTestView.SelectDBox1, string.Empty); }

            if (string.IsNullOrEmpty(geoTestView.ScoreTxt1.Text.Trim()))
            {
                geoTestView.ErrorProvider1.SetError(geoTestView.ScoreTxt1, "Score Required");
            }
            else { geoTestView.ErrorProvider1.SetError(geoTestView.ScoreTxt1, string.Empty); }

            if (string.IsNullOrEmpty(geoTestView.GeoLocationCBox1.Text.Trim()))
            {
                geoTestView.ErrorProvider1.SetError(geoTestView.GeoLocationCBox1, "Select Location");
            }
            else { geoTestView.ErrorProvider1.SetError(geoTestView.GeoLocationCBox1, string.Empty); }


            if (string.IsNullOrEmpty(geoTestView.ExpiryPicker.Text.Trim()))
            {
                geoTestView.ErrorProvider1.SetError(geoTestView.ExpiryPicker, "Select Expiry Date");
            }
            else { geoTestView.ErrorProvider1.SetError(geoTestView.ExpiryPicker, string.Empty); }

            if (!Regex.IsMatch(geoTestView.ScoreTxt1.Text, "^[1-9]$|^[1-9][0-9]$|^(100)$"))
            {
                geoTestView.ErrorProvider1.SetError(geoTestView.ScoreTxt1, "Number from 0 to 100 Requred");
            }
            else { geoTestView.ErrorProvider1.SetError(geoTestView.ScoreTxt1, string.Empty); }
        }



        public void onChangeEditValidate()
        {
            if (string.IsNullOrEmpty(geoTestView.EditSelectDBox1.Text.Trim()))
            {
                geoTestView.ErrorProvider2.SetError(geoTestView.EditSelectDBox1, "No Driver Selected");
            }
            else { geoTestView.ErrorProvider2.SetError(geoTestView.EditSelectDBox1, string.Empty); }

            if (string.IsNullOrEmpty(geoTestView.EditScoreTxt1.Text.Trim()))
            {
                geoTestView.ErrorProvider2.SetError(geoTestView.EditScoreTxt1, "Score Required");
            }
            else { geoTestView.ErrorProvider2.SetError(geoTestView.EditScoreTxt1, string.Empty); }

            if (string.IsNullOrEmpty(geoTestView.EditGeoLocationCBox1.Text.Trim()))
            {
                geoTestView.ErrorProvider2.SetError(geoTestView.EditGeoLocationCBox1, "Select Location");
            }
            else { geoTestView.ErrorProvider2.SetError(geoTestView.EditGeoLocationCBox1, string.Empty); }


            if (string.IsNullOrEmpty(geoTestView.EditExpiryPicker.Text.Trim()))
            {
                geoTestView.ErrorProvider2.SetError(geoTestView.EditExpiryPicker, "Select Expiry Date");
            }
            else { geoTestView.ErrorProvider2.SetError(geoTestView.EditExpiryPicker, string.Empty); }

            if (!Regex.IsMatch(geoTestView.EditScoreTxt1.Text, "^[1-9]$|^[1-9][0-9]$|^(100)$"))
            {
               
                geoTestView.ErrorProvider2.SetError(geoTestView.EditScoreTxt1, "Number from 0 to 100 Requred");
            }
            else { geoTestView.ErrorProvider2.SetError(geoTestView.EditScoreTxt1, string.Empty); }

        }



        public Boolean onClickAddValidate()
        {
            bool isOk = false;
            if (geoTestView.SelectDBox1.Text == String.Empty)
            {
                isOk = false;
                geoTestView.ErrorProvider1.SetError(geoTestView.SelectDBox1, "No Driver Selected");
            }
            else if (geoTestView.ScoreTxt1.Text == String.Empty)
            {
                isOk = false;
                geoTestView.ErrorProvider1.SetError(geoTestView.ScoreTxt1, "Score Required");
            }
            else if (geoTestView.GeoLocationCBox1.Text == String.Empty)
            {
                isOk = false;
                geoTestView.ErrorProvider1.SetError(geoTestView.GeoLocationCBox1, "Select Location");
            }
            else if (geoTestView.ExpiryPicker.Text == String.Empty)
            {
                isOk = false;
                geoTestView.ErrorProvider1.SetError(geoTestView.ExpiryPicker, "Select Expiry Date");
            }
            else if (!Regex.IsMatch(geoTestView.ScoreTxt1.Text, "^[1-9]$|^[1-9][0-9]$|^(100)$"))
            {
                isOk = false;
                geoTestView.ErrorProvider1.SetError(geoTestView.ScoreTxt1, "Number from 0 to 100 Requred");
            }
            else { isOk = true; }
            return isOk;

        }

        public Boolean onClickEditValidate()
        {
            bool isOk = false;
            if (geoTestView.EditSelectDBox1.SelectedIndex == -1)
            {
                isOk = false;
                geoTestView.ErrorProvider1.SetError(geoTestView.EditSelectDBox1, "No Driver Selected");
            }
            else if (geoTestView.EditScoreTxt1.Text == String.Empty)
            {
                isOk = false;
                geoTestView.ErrorProvider1.SetError(geoTestView.EditScoreTxt1, "Score Required");
            }
            else if (geoTestView.EditGeoLocationCBox1.SelectedIndex == -1)
            {
                isOk = false;
                geoTestView.ErrorProvider1.SetError(geoTestView.EditGeoLocationCBox1, "Select Location");
            }
            else if (geoTestView.EditExpiryPicker.Text == String.Empty)
            {
                isOk = false;
                geoTestView.ErrorProvider1.SetError(geoTestView.EditExpiryPicker, "Select Expiry Date");
            }
            else if (!Regex.IsMatch(geoTestView.EditScoreTxt1.Text, "^[1-9]$|^[1-9][0-9]$|^(100)$")) {
                isOk = false;
                geoTestView.ErrorProvider1.SetError(geoTestView.EditScoreTxt1, "Number from 0 to 100 Requred");
            }
            else { isOk = true; }
            return isOk;

        }



        public void lockInput()
        {
            geoTestView.EditGeoLocationCBox1.Enabled = false;
            geoTestView.EditSelectTestBox1.Enabled = false;
            geoTestView.EditScoreTxt1.Enabled = false;
            geoTestView.EditGeoLocationCBox1.Enabled = false;
            geoTestView.EditExpiryPicker.Enabled = false;
            geoTestView.EditSubmitBtn1.Enabled = false;

        }

        public void unlockInput()
        {
            geoTestView.EditGeoLocationCBox1.Enabled =true;
            geoTestView.EditSelectTestBox1.Enabled = true ;
            geoTestView.EditScoreTxt1.Enabled = true;
            geoTestView.EditGeoLocationCBox1.Enabled = true;
            geoTestView.EditExpiryPicker.Enabled = true;
            geoTestView.EditSubmitBtn1.Enabled = true;


        }


        public void deleteTabLockBtn()
        {
            geoTestView.DelBtn1.Enabled = false;
            geoTestView.DelSelectTestBox1.Enabled = false;

        }

        public void deleteTabUnlockBtn()
        {
            geoTestView.DelBtn1.Enabled =true;
            geoTestView.DelSelectTestBox1.Enabled = true;
        }

        public void clearAddTxtBoxes()
        {

           geoTestView.ScoreTxt1.Clear();
           geoTestView.GeoLocationCBox1.SelectedIndex= -1;
           geoTestView.GeoLocationCBox1.SelectedIndex = -1;
           geoTestView.ExpiryPicker.Value = System.DateTime.Now;
        }


    }
}
