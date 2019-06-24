using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiDriverSystem.View;

namespace TaxiDriverSystem.Validation
{
    public class IncidentValidation
    {
        private IncidentView iView;
        public IncidentValidation(IncidentView iView){
            this.iView = iView;
          
        }


        public Boolean onClickAddValidate()
        {
            bool isOk = false;
            if (iView.SelectDBox1.Text == String.Empty)
            {
                isOk = false;
                iView.ErrorProvider1.SetError(iView.SelectDBox1, "Select Driver");
            }
            else { isOk = true; }

            if (iView.SelectIBox.Text == String.Empty)
            {
                isOk = false;
                iView.ErrorProvider1.SetError(iView.SelectIBox, "Select Incident Type");
            }
            else { isOk = true; }
            
            if (iView.IBox.Text == String.Empty)
            {
                isOk = false;
                iView.ErrorProvider1.SetError(iView.IBox, "Incident Report Required");
            }
            else { isOk = true; }
            return isOk;
        }


        public void onChangeAddValidate()
        {
            if (string.IsNullOrEmpty(iView.SelectDBox1.Text.Trim()))
            {
                 iView.ErrorProvider1.SetError(iView.SelectDBox1 , "Select Driver");
            }
            else { iView.ErrorProvider1.SetError(iView.SelectDBox1, string.Empty); }

            if (string.IsNullOrEmpty(iView.SelectIBox.Text.Trim()))
            {
                iView.ErrorProvider1.SetError(iView.SelectIBox, "Select Incident Type");
            }
            else { iView.ErrorProvider1.SetError(iView.SelectIBox, string.Empty); }

            if (string.IsNullOrEmpty(iView.IBox.Text.Trim()))
            {
                iView.ErrorProvider1.SetError(iView.IBox, "Incident Report Required");
            }
            else { iView.ErrorProvider1.SetError(iView.IBox, string.Empty); }

        }

    }
}
