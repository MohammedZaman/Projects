using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiDriverSystem.Interfaces;
using TaxiDriverSystem.View;

namespace TaxiDriverSystem.Validation
{
    public class TrainTypeValidation
    {
        private TrainTypeView tTypeView;

        public TrainTypeValidation(TrainTypeView view)
        {
            this.tTypeView = view;
        }

       public Boolean onClickAddValidate()
        {
            bool isOk = false;
            if (tTypeView.AddTrainTypeTxt.Text == String.Empty)
            {
                isOk = false;
                tTypeView.ErrorProvider1.SetError(tTypeView.AddTrainTypeTxt, "Training Type is Required");
            }
            else { isOk = true; }
            return isOk;
        }

        public Boolean onClickEditValidate()
        {
            bool isOk = false;
            if (tTypeView.EditTrainTypeTxt.Text == String.Empty)
            {
                isOk = false;
                tTypeView.ErrorProvider1.SetError(tTypeView.AddTrainTypeTxt,"Training Type is required");
            }
            else { isOk = true; }

            if (tTypeView.EditSelectTBox1.Text == String.Empty)
            {
                isOk = false;
                tTypeView.ErrorProvider1.SetError(tTypeView.EditSelectTBox1, "Select Training Type");
            }
            else { isOk = true; }
            return isOk;
        }


        public void onChangeAddValidate()
        {
            if (string.IsNullOrEmpty(tTypeView.AddTrainTypeTxt.Text.Trim()))
            {
                tTypeView.ErrorProvider1.SetError(tTypeView.AddTrainTypeTxt, "Training Type Required");
            }
            else { tTypeView.ErrorProvider1.SetError(tTypeView.AddTrainTypeTxt, string.Empty); }

        }

        public void onChangeEditValidate()
        {
            if (string.IsNullOrEmpty(tTypeView.EditTrainTypeTxt.Text.Trim()))
            {
                tTypeView.ErrorProvider2.SetError(tTypeView.EditTrainTypeTxt, "Training Type Required");
            }
            else { tTypeView.ErrorProvider2.SetError(tTypeView.EditTrainTypeTxt, string.Empty); }

            if (string.IsNullOrEmpty(tTypeView.EditSelectTBox1.Text.Trim()))
            {
                tTypeView.ErrorProvider2.SetError(tTypeView.EditSelectTBox1, "Training Type Required");
            }
            else { tTypeView.ErrorProvider2.SetError(tTypeView.EditSelectTBox1, string.Empty); }

        }




        public void clearAddTxtBoxes()
        {
            tTypeView.AddTrainTypeTxt.Clear();
        }

        public void clearEditTxtBoxes()
        {
            tTypeView.EditTrainTypeTxt.Clear();
        }

        public void lockEdit() {
            tTypeView.EditTrainTypeTxt.Enabled = false;
            tTypeView.EditSubmitBtn1.Enabled = false;
        }
        public void unlockEdit()
        {
            tTypeView.EditTrainTypeTxt.Enabled = true;
            tTypeView.EditSubmitBtn1.Enabled = true;
        }

        public void lockDel() {
            tTypeView.DelBtn1.Enabled = false;

        }

        public void unlockDel()
        {
            tTypeView.DelBtn1.Enabled = true;

        }

    }
}
