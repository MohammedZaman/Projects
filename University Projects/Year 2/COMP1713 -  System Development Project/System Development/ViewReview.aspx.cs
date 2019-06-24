using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Systems_Development
{
    public partial class ViewReview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

            createReceipt();

        }


        public string getstars(int starnum) {
            string star ="";
            for (int i = 0; i < starnum; i++) {
                star += "&#x2605;";
            }
            return star;
        }
        public void createReceipt()
        {
            DBController dbCon = DBController.getInstance;
            List<Objects.Review> review = dbCon.getAllReviews();

            for (var i = review.Count; i-- > 0;)
            {
                System.Web.UI.HtmlControls.HtmlGenericControl createDiv =
                new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                createDiv.ID = "createDiv";
                reviews.Controls.Add(createDiv);
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
                innerDiv.InnerHtml = "User: " + review[i].CustomerUsername1 + "                          "+ getstars(int.Parse(review[i].Star)); 
                createDiv.Style.Add("padding", "6px");
                createDiv.Style.Add("font-family", "'Roboto',sans-serif");
                createDiv.Style.Add(HtmlTextWriterStyle.MarginBottom, "15px");



                System.Web.UI.HtmlControls.HtmlGenericControl innerDiv2 =
                new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                innerDiv2.ID = "innerDiv2";
                createDiv.Controls.Add(innerDiv2);
                innerDiv2.InnerHtml = review[i].ReviewText;
                createDiv.Style.Add("padding", "6px");
                createDiv.Style.Add("font-family", "'Roboto',sans-serif");


            }


        }
    }
}