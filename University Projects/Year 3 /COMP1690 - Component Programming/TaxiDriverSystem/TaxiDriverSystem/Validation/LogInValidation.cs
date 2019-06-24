using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiDriverSystem.View;

namespace TaxiDriverSystem.Validation
{
    public class LogInValidation
    {
        private LogInView logInV;

        public LogInValidation(LogInView logView)
        {
            this.logInV = logView;

        }

        public Boolean onClicklogInValidate()
        {
            bool isOk = false;
            if (logInV.UserNameTxt.Text == String.Empty)
            {
                isOk = false;
                logInV.ErrorProvider1.SetError(logInV.UserNameTxt, "User Name is Required");
            }
            else { isOk = true; }

            if (logInV.PasswordTxt.Text == String.Empty)
            {
                isOk = false;
                logInV.ErrorProvider1.SetError(logInV.PasswordTxt, "Password is Required");
            }
            else { isOk = true; }
            return isOk;
        }


        public void OnChangeValidate()
        {
            if (string.IsNullOrEmpty(logInV.UserNameTxt.Text.Trim()))
            {
                logInV.ErrorProvider1.SetError(logInV.UserNameTxt, "UserName Required");
            }
            else { logInV.ErrorProvider1.SetError(logInV.UserNameTxt, string.Empty); }

            if (string.IsNullOrEmpty(logInV.PasswordTxt.Text.Trim()))
            {
                logInV.ErrorProvider1.SetError(logInV.PasswordTxt, "Password Required");
            }
            else { logInV.ErrorProvider1.SetError(logInV.PasswordTxt, string.Empty); }
        }



    }
}
