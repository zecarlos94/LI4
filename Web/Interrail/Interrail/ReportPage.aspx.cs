using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interrail
{
    public partial class ReportPage : System.Web.UI.Page
    {
        private string email;

        protected void Page_Load(object sender, EventArgs e)
        {
            string response = Request.QueryString["id"];
            string[] words = response.Split('/');
            int reportId = int.Parse(words[0]);
            email = words[1];
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string response = "~/Reports.aspx?id=" + email;
            Response.Redirect(response);
        }
    }
}