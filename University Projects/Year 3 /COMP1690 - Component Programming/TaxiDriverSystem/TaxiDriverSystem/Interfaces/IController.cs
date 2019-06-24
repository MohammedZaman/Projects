using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDriverSystem.Interfaces
{
    public interface IController
    {

        void MyClickEvent(object sender, EventArgs e);
        void MyIndexChange(object sender, EventArgs e);
        void tabControl1_SelectedIndexChanged(object sender, EventArgs e);
        void textBox_Validating(object sender, CancelEventArgs e);





    }
}
