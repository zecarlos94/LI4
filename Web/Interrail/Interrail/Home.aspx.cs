using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Interrail.classes;

namespace Interrail
{
    public partial class Home : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            /**string message = Request.QueryString["id"];
            string[] words = message.Split(';');
            ta.putMessage(words[0], words[1]);*/
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Signup.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }

        protected void LinkButton5_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/ContactUs.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AboutUs.aspx");
        }

        protected void LinkButton3_Click1(object sender, EventArgs e)
        {
            string link = "http://google.pt/search?q=" + TextBox1.Text;
            Response.Redirect(link);
        }
    }
}
