using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TaxiDriverSystem.InnerJoin;
using TaxiDriverSystem.Interfaces;
using TaxiDriverSystem.Misc;
using TaxiDriverSystem.Repositories;
using TaxiDriverSystem.Validation;
using TaxiDriverSystem.View;

namespace TaxiDriverSystem.Controller
{
    public class  AssignController : IController
    {
        private IRepository<Training> trainingRepos;
        private AssignView assignV;
        private AssignValidation assignValid;
        private IRepository<TrainingSession> sessionRepos;
        public AssignController(AssignView view)
        {
            this.trainingRepos = new GenericRepository<Training>();
            this.sessionRepos = new GenericRepository<TrainingSession>();
            this.assignV = view;
            view.ActivateView(this);// addding event handlers to buttons
            this.assignValid = new AssignValidation(assignV);
            updateDriverBox();
            updateSessionBox();
        }
        public void MyClickEvent(object sender, EventArgs e)
        {
            if (sender == assignV.AssignBtn)
            {
                if (assignValid.onClickAddValidate() == true)
                {
                    Training training = new Training();
                    // this object is used add value and name to a combobox
                    ComboboxValue tmpComboboxValue = (ComboboxValue)assignV.SelectDBox1.SelectedItem;
                    ComboboxValue session = (ComboboxValue)assignV.SessionBox.SelectedItem;
                    training.Driver_Id = tmpComboboxValue.Id;
                    training.TrainingSession_Id = session.Id;
                    training.Status = false;
                    trainingRepos.insert(training);
                    trainingRepos.save();
                    MessageBox.Show("Driver Assigned to Traning Session");
                }
                else { MessageBox.Show("Please fill in the Required Fields"); }

            }

            else if (sender == assignV.UpdateBtn)
            {

                if (assignValid.onClickOutcomeValidate() == true)
                {
                    trainingRepos = new GenericRepository<Training>();
                    ComboboxValue tmpComboboxValue = (ComboboxValue)assignV.EditDriverBox.SelectedItem;
                    ComboboxValue session = (ComboboxValue)assignV.EditSessionBox.SelectedItem;
                    Training training = new Training();
                    training.Training_Id = session.Id;
                    training.Driver_Id = tmpComboboxValue.Id;
                    training.TrainingSession_Id = getSession(session.Id);

                    if (assignV.StatusBox.SelectedIndex == 0)
                    {
                        training.Status = true;
                    }
                    else
                    {
                        training.Status = false;
                    }
                    trainingRepos.update(training);
                    trainingRepos.save();

                    MessageBox.Show("Training Updated");
                }
                else { MessageBox.Show("Please fill in the Required Fields"); }
            }
        }

        public void MyIndexChange(object sender, EventArgs e)
        {
            if (sender == assignV.EditDriverBox) {
                ComboboxValue tmpComboboxValue = (ComboboxValue)assignV.EditDriverBox.SelectedItem;
                innerJoin(tmpComboboxValue.Id);
            } else if (sender == assignV.EditSessionBox){
                if (assignV.EditSessionBox.SelectedIndex != -1)
                {
                    ComboboxValue tmpComboboxValue = (ComboboxValue)assignV.EditSessionBox.SelectedItem;
                    getStatus(tmpComboboxValue.Id);
                }

            }
          
        }

        public void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        public void textBox_Validating(object sender, CancelEventArgs e)
        {
            assignValid.onChangeAssignValidate();
            assignValid.onChangeOutcomeValidate();
           
        }

        public void updateDriverBox()
        {
            GenericRepository<Driver> driverRepos = new GenericRepository<Driver>();
            // loop data into combo box 
            IEnumerable<Driver> drivers = driverRepos.SelectAll();
            assignV.SelectDBox1.Items.Clear();
            assignV.EditDriverBox.Items.Clear();

            foreach (var item in drivers)
            {
                assignV.SelectDBox1.Items.Add(new ComboboxValue(item.Driver_Id, item.First_Name));
                assignV.EditDriverBox.Items.Add(new ComboboxValue(item.Driver_Id, item.First_Name));
               

            }
        }

        public void updateSessionBox()
        { 
            IEnumerable<TrainingSession> session = sessionRepos.SelectAll();
            assignV.SessionBox.Items.Clear();
        
            foreach (var item in session)
            {

                
                DateTime date  = (DateTime)item.Date_of_session;
                if (date >= System.DateTime.Now)
                {
                    string type = getTrainingTypeName((int)item.TrainingType_Id) + "(" + date.ToShortDateString() + ")";
                    assignV.SessionBox.Items.Add(new ComboboxValue(item.TrainingSession_Id, type));
                  
                }
               
            }
        }

        


        public string getTrainingTypeName(int id)
        {
            IRepository<TrainingType> ttRepos = new GenericRepository<TrainingType>();
            IEnumerable<TrainingType> trainingType = ttRepos.SelectAll();
            foreach (var item in trainingType)
            {
                if (item.TrainingType_Id == id) {
                    return item.Training_name;
                }

            }
            return "";
        }

        public void innerJoin(int id)
        {
            InnerJoinRepository  ttRepos = new InnerJoinRepository();
            List<DriverSessions> trainingType = ttRepos.driverSessions(id);
            assignV.EditSessionBox.SelectedIndex = -1;
            assignV.StatusBox.SelectedIndex = -1;
            assignV.EditSessionBox.Items.Clear();
            foreach (var item in trainingType)
            {
                assignV.EditSessionBox.Items.Add(new ComboboxValue(item.Training_id, item.Training_name1 +"("+item.Date_of_session1+")"));
               
            }
     
        }

        public void getStatus(int id)
        {
            InnerJoinRepository ttRepos = new InnerJoinRepository();
            List<DriverSessions> trainingType = ttRepos.FindSessionId(id);
            
            foreach (var item in trainingType)
            {
             if(item.Status == true)
                {
                    assignV.StatusBox.SelectedIndex = 0;
                }
                else
                {
                    assignV.StatusBox.SelectedIndex = 1;
                }

            }

        }

        public int getSession(int id)
        {
            InnerJoinRepository ttRepos = new InnerJoinRepository();
            List<DriverSessions> trainingType = ttRepos.FindSessionId(id);

            foreach (var item in trainingType)
            {
                if (item.Training_id == id) {
                    return item.TrainingSession_Id1;
                }
            }
            return -1;
        }












    }
}
