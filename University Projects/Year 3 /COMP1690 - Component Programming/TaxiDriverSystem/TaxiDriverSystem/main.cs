using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiDriverSystem.Controller;
using TaxiDriverSystem.View;

namespace TaxiDriverSystem
{
    static class main
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            LogInView login = new LogInView();
            LogInController logInContro = new LogInController(login);
            login.ShowDialog();




        }
    }
}
