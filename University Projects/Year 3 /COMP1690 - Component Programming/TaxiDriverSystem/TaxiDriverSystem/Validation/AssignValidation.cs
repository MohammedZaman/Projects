using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiDriverSystem.View;

namespace TaxiDriverSystem.Validation
{
    public class AssignValidation
    {
        private AssignView assignV = new AssignView();

        public AssignValidation(AssignView aView)
        {
            this.assignV = aView;

        }

        public Boolean onClickAddValidate()
        {
            bool isOk = false;
            if (assignV.SelectDBox1.Text == String.Empty)
            {
                isOk = false;
                assignV.ErrorProvider1.SetError(assignV.SelectDBox1, "Driver is Required.");
            }
            else if (assignV.SessionBox.Text == String.Empty)
            {
                isOk = false;
                assignV.ErrorProvider1.SetError(assignV.SessionBox, "Session is required.");
            }
            else { isOk = true; }
            return isOk;

        }

        public void onChangeAssignValidate()
        {
            if (string.IsNullOrEmpty(assignV.SelectDBox1.Text.Trim()))
            {
                assignV.ErrorProvider1.SetError(assignV.SelectDBox1, "Driver is required.");
            }
            else { assignV.ErrorProvider1.SetError(assignV.SelectDBox1, string.Empty); }


            if (string.IsNullOrEmpty(assignV.SessionBox.Text.Trim()))
            {
               assignV.ErrorProvider1.SetError(assignV.SessionBox, "Session is required.");
            }
            else { assignV.ErrorProvider1.SetError(assignV.SessionBox, string.Empty); }
        }


        public void onChangeOutcomeValidate()
        {
            if (string.IsNullOrEmpty(assignV.EditDriverBox.Text.Trim()))
            {
                assignV.ErrorProvider2.SetError(assignV.EditDriverBox, "Driver is required.");
            }
            else { assignV.ErrorProvider2.SetError(assignV.EditDriverBox, string.Empty); }


            if (string.IsNullOrEmpty(assignV.EditSessionBox.Text.Trim()))
            {
                assignV.ErrorProvider2.SetError(assignV.EditSessionBox, "Session is required.");
            }
            else { assignV.ErrorProvider1.SetError(assignV.EditSessionBox, string.Empty); }

            if (string.IsNullOrEmpty(assignV.StatusBox.Text.Trim()))
            {
                assignV.ErrorProvider2.SetError(assignV.StatusBox, "Status is required.");
            }
            else { assignV.ErrorProvider1.SetError(assignV.StatusBox, string.Empty); }

        }

        public Boolean onClickOutcomeValidate()
        {
            bool isOk = false;
            if (assignV.EditDriverBox.Text == String.Empty)
            {
                isOk = false;
                assignV.ErrorProvider1.SetError(assignV.EditDriverBox, "Driver is Required.");
            }
            else if (assignV.EditSessionBox.Text == String.Empty)
            {
                isOk = false;
                assignV.ErrorProvider1.SetError(assignV.EditSessionBox, "Session is required.");
            }
            else if (assignV.StatusBox.Text == String.Empty)
            {
                isOk = false;
                assignV.ErrorProvider1.SetError(assignV.StatusBox, "Status is required.");
            }
            else { isOk = true; }
            return isOk;

        }

    }
}
