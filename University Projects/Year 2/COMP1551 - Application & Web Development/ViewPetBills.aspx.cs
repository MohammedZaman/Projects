using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace friendsWithPaws
{
    public partial class ViewPetBills : System.Web.UI.Page
    {
        SqlConnection SQLCON = new SqlConnection("server=sql-server;database=mz7340g;User ID=mz7340g;Password=Yahya123");
        protected void Page_Load(object sender, EventArgs e)
        {
    
                DisplayRecord();
            double total = DBConnect.LoadVetBills().Sum(item => item.Total1);
            TotalLbl.Text ="Grand Total £"+ total.ToString();

        }

        public DataTable DisplayRecord()
        {
            DataTable Dt = new DataTable();
            addVetBillsGrid.DataSource = DBConnect.LoadVetBills();
            addVetBillsGrid.DataBind();
            return Dt;

        }
    }
}