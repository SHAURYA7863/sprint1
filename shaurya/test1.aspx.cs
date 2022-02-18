using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace shaurya
{
    public partial class test1 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            System.Web.UI.HtmlControls.HtmlGenericControl MasterBody = (System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("MasterBody");
            MasterBody.Attributes.Add("style", "background-color: green");

            string txt = Txt1.Text;
          
            lblResult.Text = txt.ToString();
        }
    }
}