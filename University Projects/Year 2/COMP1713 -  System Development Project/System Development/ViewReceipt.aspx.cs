using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Systems_Development
{
    public partial class ViewReceipt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("LogIn.aspx");
            }

            createReceipt();

        }
        public void createReceipt() {
            DBController dbCon = DBController.getInstance;
            string uid = Session["username"].ToString();
           List<Objects.Receipt> receipts = dbCon.getAllReceipt(uid);
          
            for (var i = receipts.Count; i-- > 0;)
            {
                System.Web.UI.HtmlControls.HtmlGenericControl createDiv =
                new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                createDiv.ID = "createDiv";
                receipt.Controls.Add(createDiv);
                string id = Convert.ToString(i);
                createDiv.Style.Add("box-shadow", "0 4px 8px 0 rgba(0, 0, 0, 0.2)");
                createDiv.Style.Add("opacity", "0.8");
                createDiv.Style.Add("border-radius", "8px");
                 





                createDiv.Style.Add("padding", "30px");
                createDiv.Style.Add("background-color", "#BDBDBD");
                createDiv.Style.Add(HtmlTextWriterStyle.MarginBottom, "15px");





                System.Web.UI.HtmlControls.HtmlGenericControl innerDiv =
                new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                innerDiv.ID = "innerDiv";
                createDiv.Controls.Add(innerDiv);
                innerDiv.InnerHtml = "Date: " + receipts[i].Date;
                createDiv.Style.Add("padding", "6px");
                createDiv.Style.Add("font-family", "'Roboto',sans-serif");

                System.Web.UI.HtmlControls.HtmlGenericControl innerDiv1 =
                new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                innerDiv1.ID = "innerDiv1";
                createDiv.Controls.Add(innerDiv1);
                innerDiv1.InnerHtml =  receipts[i].RecieptText;
                createDiv.Style.Add("padding", "6px");
                createDiv.Style.Add("font-family", "'Roboto',sans-serif");


                System.Web.UI.HtmlControls.HtmlGenericControl innerDiv2 =
                new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                innerDiv2.ID = "innerDiv2";
                createDiv.Controls.Add(innerDiv2);
                innerDiv2.InnerHtml = "Miles: " + Math.Round(receipts[i].Miles,2) + "  Total: £"+receipts[i].Cost.ToString();
                createDiv.Style.Add("padding", "6px");
                createDiv.Style.Add("font-family", "'Roboto',sans-serif");


                System.Web.UI.HtmlControls.HtmlGenericControl innerDiv3 =
               new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                innerDiv3.ID = "innerDiv3";
                createDiv.Controls.Add(innerDiv3);
                innerDiv3.InnerHtml = "Write review";
                innerDiv3.Style.Add("font-family", "'Roboto',sans-serif");
                innerDiv3.Style.Add("border", " solid 2px #464646");
                innerDiv3.Style.Add("width", "90px");
                innerDiv3.Style.Add("padding", "5px");
                innerDiv3.Style.Add("margin-left", "80%");
                innerDiv3.Style.Add("color", "white");
                innerDiv3.Style.Add("background-color", "#464646");
                innerDiv3.Attributes.Add("onmouseup", "location.href='MakeReview.aspx'");
                createDiv.Style.Add(HtmlTextWriterStyle.MarginBottom, "20px");









            }
            

        }
}
}