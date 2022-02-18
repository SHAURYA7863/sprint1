using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shaurya
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            Response.Redirect("test1.aspx");
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            Response.Redirect("test3.aspx");
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            Response.Redirect("test4.aspx");
        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            Response.Redirect("test5.aspx");
        }
    }
}