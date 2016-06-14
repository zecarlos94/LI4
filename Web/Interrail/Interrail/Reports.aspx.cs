using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interrail
{
    public partial class Reports : System.Web.UI.Page
    {

        private string email;
        private Boolean filterLocal = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            email = Request.QueryString["id"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string res = "~/UserPage.aspx?id=" + email;
            Response.Redirect(res);
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            filterLocal = true;
        }
    }
}