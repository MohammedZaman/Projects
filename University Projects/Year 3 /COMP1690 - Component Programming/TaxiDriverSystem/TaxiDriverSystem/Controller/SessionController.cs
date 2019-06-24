using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TaxiDriverSystem.Interfaces;
using TaxiDriverSystem.Misc;
using TaxiDriverSystem.Repositories;
using TaxiDriverSystem.Validation;
using TaxiDriverSystem.View;

namespace TaxiDriverSystem.Controller
{
    public class SessionController : IController
    {
        private GenericRepository<TrainingSession> tSessionRepos;
        private InnerJoinRepository driverSessionsRepos;

        private SessionView sessionView;
        private SessionValidation sessValid;

        public SessionController(SessionView view)
        {
            this.driverSessionsRepos = new InnerJoinRepository();
            this.tSessionRepos = new GenericRepository<TrainingSession>();
            this.sessionView = view;
            view.ActivateView(this);// addding event handlers to buttons
            this.sessValid = new SessionValidation(sessionView);
            updateTypeBox();
            sessValid.block();
         
        }
        public void MyClickEvent(object sender, EventArgs e)
        {
            if (sender == sessionView.SubmitBtn1) {
                if (sessValid.onClickAddValidate() == true  && sessionView.SelectTTBox1.SelectedIndex != -1)
                {

                    //Data to be entered
                    ComboboxValue tmpComboboxValue = (ComboboxValue)sessionView.SelectTTBox1.SelectedItem;
                    DateTime sDate = sessionView.SDatePicker.Value;
                    DateTime sTime = sessionView.STimePicker.Value;
                    DateTime eTime = sessionView.ETimePicker.Value;
                    DateTime expiry = sessionView.ExpiryDatePicker.Value;

                    TrainingSession session = new TrainingSession();
                    session.TrainingType_Id = tmpComboboxValue.Id;
                    session.Date_of_session = sDate;
                    session.Start_Time = sTime;
                    session.End_Time = eTime;
                    session.Expiry_Date = expiry;

                    tSessionRepos.insert(session);
                    tSessionRepos.save();
                    sessValid.clearAddTxtBoxes();
                    MessageBox.Show("Session Sheduled");


                }
                else { MessageBox.Show("Please fill in the Required Fields"); }

            } 
        }

        public void MyIndexChange(object sender, EventArgs e)
        {
            if (sender == sessionView.SelectTTBox1)
            {
                if (sessionView.SelectTTBox1.SelectedIndex == -1)
                {
                    sessValid.block();
                }
                else
                {
                    sessValid.Unblock();
                }
            }
        }
        public void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void textBox_Validating(object sender, CancelEventArgs e)
        {
            sessValid.onChangeAddValidate();
        }

        public void updateTypeBox()
        {
            // loop data into combo box 
            GenericRepository<TrainingType> trainTypeRepos = new GenericRepository<TrainingType>();
            IEnumerable<TrainingType> tTypes = trainTypeRepos.SelectAll();
            sessionView.SelectTTBox1.Items.Clear();
         

            foreach (var item in tTypes)
            {
                sessionView.SelectTTBox1.Items.Add(new ComboboxValue(item.TrainingType_Id, item.Training_name));
                
            }
        }
    }
}
