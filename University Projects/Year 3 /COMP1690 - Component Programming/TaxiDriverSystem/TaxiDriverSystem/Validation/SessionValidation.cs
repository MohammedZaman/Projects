using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiDriverSystem.View;

namespace TaxiDriverSystem.Validation
{
    public class SessionValidation
    {

        private SessionView sessionV = new SessionView();

        public SessionValidation(SessionView sView)
        {
            this.sessionV = sView;

        }


        public Boolean onClickAddValidate()
        {
            bool isOk = false;
            if (sessionV.SelectTTBox1.Text == String.Empty)
            {
                isOk = false;
                sessionV.ErrorProvider1.SetError(sessionV.SelectTTBox1, "Select Training Session");
            }
            else { isOk = true; }
            if (sessionV.SDatePicker.Text == String.Empty)
            {
                isOk = false;
                sessionV.ErrorProvider1.SetError(sessionV.SDatePicker, "Start Date Required");
            }
            else { isOk = true; }
            if (sessionV.STimePicker.Text == String.Empty)
            {
                isOk = false;
                sessionV.ErrorProvider1.SetError(sessionV.STimePicker, "Start Time Required");
            }
            else { isOk = true; }

            if (sessionV.ETimePicker.Text == String.Empty)
            {
                isOk = false;
                sessionV.ErrorProvider1.SetError(sessionV.ETimePicker, "End Time Required");
            }
            else { isOk = true; }

            if (sessionV.ExpiryDatePicker.Text == String.Empty)
            {
                isOk = false;
                sessionV.ErrorProvider1.SetError(sessionV.ExpiryDatePicker, "Expiry Date Required");
            }
            else { isOk = true; }
            return isOk;
        }

     

        public void onChangeAddValidate()
        {
            if (string.IsNullOrEmpty(sessionV.SelectTTBox1.Text.Trim()))
            {
                sessionV.ErrorProvider1.SetError(sessionV.SelectTTBox1, "Training Type Required");
            }
            else { sessionV.ErrorProvider1.SetError(sessionV.SelectTTBox1, string.Empty); }


            if (string.IsNullOrEmpty(sessionV.SDatePicker.Text.Trim()))
            {
                sessionV.ErrorProvider1.SetError(sessionV.SDatePicker, "Training Type Required");
            }
            else { sessionV.ErrorProvider1.SetError(sessionV.SDatePicker, string.Empty); }


            if (string.IsNullOrEmpty(sessionV.STimePicker.Text.Trim()))
            {
                sessionV.ErrorProvider1.SetError(sessionV.STimePicker, "Start Time Required");
            }
            else { sessionV.ErrorProvider1.SetError(sessionV.STimePicker, string.Empty); }

            if (string.IsNullOrEmpty(sessionV.ETimePicker.Text.Trim()))
            {
                sessionV.ErrorProvider1.SetError(sessionV.ETimePicker, "End Time Required");
            }
            else { sessionV.ErrorProvider1.SetError(sessionV.ETimePicker, string.Empty); }

            if (string.IsNullOrEmpty(sessionV.ExpiryDatePicker.Text.Trim()))
            {
                sessionV.ErrorProvider1.SetError(sessionV.ExpiryDatePicker, "Expiry Date Required");
            }
            else { sessionV.ErrorProvider1.SetError(sessionV.ExpiryDatePicker, string.Empty); }



        }


        public void clearAddTxtBoxes()
        {
            sessionV.SelectTTBox1.SelectedIndex = -1 ;
            sessionV.SDatePicker.Value = System.DateTime.Now;
            sessionV.STimePicker.Value = System.DateTime.Now;
            sessionV.ETimePicker.Value = System.DateTime.Now;
            sessionV.ExpiryDatePicker.Value = System.DateTime.Now;

        }

        public void block() {
            sessionV.SDatePicker.Enabled = false;
            sessionV.STimePicker.Enabled = false;
            sessionV.ETimePicker.Enabled = false;
            sessionV.ExpiryDatePicker.Enabled = false;
        }

        public void Unblock()
        {
            sessionV.SDatePicker.Enabled = true;
            sessionV.STimePicker.Enabled = true;
            sessionV.ETimePicker.Enabled = true;
            sessionV.ExpiryDatePicker.Enabled = true;
        }





    }
}
