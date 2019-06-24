using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiDriverSystem.Interfaces;
using TaxiDriverSystem.View;

namespace TaxiDriverSystem.Validation
{
    public class IncidentTypeValidation
    {
        private IncidentTypeView tTypeView;

        public IncidentTypeValidation(IncidentTypeView view)
        {
            this.tTypeView = view;
        }

       public Boolean onClickAddValidate()
        {
            bool isOk = false;
            if (tTypeView.AddIncidentTypeTxt.Text == String.Empty)
            {
                isOk = false;
                tTypeView.ErrorProvider1.SetError(tTypeView.AddIncidentTypeTxt, "Incident Type is Required");
            }
            else { isOk = true; }
            return isOk;
        }

        public Boolean onClickEditValidate()
        {
            bool isOk = false;
            if (tTypeView.EditIncidentTypeTxt.Text == String.Empty)
            {
                isOk = false;
                tTypeView.ErrorProvider1.SetError(tTypeView.EditIncidentTypeTxt,"Incident Type is required");
            }
            else { isOk = true; }

            if (tTypeView.EditSelectIBox1.Text == String.Empty)
            {
                isOk = false;
                tTypeView.ErrorProvider1.SetError(tTypeView.EditSelectIBox1, "Select incident Type");
            }
            else { isOk = true; }
            return isOk;
        }


        public void onChangeAddValidate()
        {
            if (string.IsNullOrEmpty(tTypeView.AddIncidentTypeTxt.Text.Trim()))
            {
                tTypeView.ErrorProvider1.SetError(tTypeView.AddIncidentTypeTxt, "Incident Type Required");
            }
            else { tTypeView.ErrorProvider1.SetError(tTypeView.AddIncidentTypeTxt, string.Empty); }

        }

        public void onChangeEditValidate()
        {
            if (string.IsNullOrEmpty(tTypeView.EditIncidentTypeTxt.Text.Trim()))
            {
                tTypeView.ErrorProvider2.SetError(tTypeView.EditIncidentTypeTxt, "Incident Type Required");
            }
            else { tTypeView.ErrorProvider2.SetError(tTypeView.EditIncidentTypeTxt, string.Empty); }

            if (string.IsNullOrEmpty(tTypeView.EditSelectIBox1.Text.Trim()))
            {
                tTypeView.ErrorProvider2.SetError(tTypeView.EditSelectIBox1, "Incident Type Required");
            }
            else { tTypeView.ErrorProvider2.SetError(tTypeView.EditSelectIBox1, string.Empty); }

        }




        public void clearAddTxtBoxes()
        {
            tTypeView.AddIncidentTypeTxt.Clear();
        }

        public void clearEditTxtBoxes()
        {
            tTypeView.EditIncidentTypeTxt.Clear();
        }

        public void lockEdit() {
            tTypeView.EditIncidentTypeTxt.Enabled = false;
            tTypeView.EditSubmitBtn1.Enabled = false;
        }
        public void unlockEdit()
        {
            tTypeView.EditIncidentTypeTxt.Enabled = true;
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
