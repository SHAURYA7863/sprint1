using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shaurya
{
    public partial class test5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
             string txt = Txt1.Text;
             string reverseString = "";
             foreach (char c in txt)
             {
                 reverseString = c + reverseString;
             }
           
            lblResult.Text = reverseString.ToString();
        }
    }
}