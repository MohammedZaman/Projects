using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiDriverSystem.Interfaces;
using TaxiDriverSystem.Repositories;
using TaxiDriverSystem.Security.Encryption;
using TaxiDriverSystem.Validation;
using TaxiDriverSystem.View;

namespace TaxiDriverSystem.Controller
{
    public class LogInController : IController
    {
        private LogInView logIn;
        private InnerJoinRepository logRepos;
        private LogInValidation logInValid;
        private PasswordEncrypt encrypt;

        public LogInController(LogInView login)
        {
           this.logIn = login;
           logIn.ActivateView(this);
           this.logRepos = new InnerJoinRepository();
           this.logInValid = new LogInValidation(logIn);
           this.encrypt = new PasswordEncrypt();
        

        }

        public void MyClickEvent(object sender, EventArgs e)
        {
            if (sender == logIn.LogInBtn) {
                if (logInValid.onClicklogInValidate() == true) {
                    string uName = logIn.UserNameTxt.Text;
                    string password = encrypt.GetSha1(logIn.PasswordTxt.Text);
                    if (logRepos.IsvalidUser(uName,password) == true)
                    {
                        MainConsole mainView = new MainConsole();
                        MainViewController mainController = new MainViewController(mainView);
                        mainView.WindowState = FormWindowState.Maximized;
                        mainView.ShowDialog();
                        logIn.Close();
                        logIn.ShowInTaskbar = false;
                    }
                    else
                    {
                        logIn.ErrorMsg1.Text = "Username or Password Incorrect";
                    }
                }
            }
            
        }

        public void MyIndexChange(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void textBox_Validating(object sender, CancelEventArgs e)
        {
            logInValid.OnChangeValidate();
        }
    }
}
