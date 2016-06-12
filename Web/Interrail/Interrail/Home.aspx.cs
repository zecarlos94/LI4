using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Windows.Navigation;

namespace Interrail
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Signup.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            string query="http://google.pt/search?q="+TextBox1.Text;
            //Não reconhece no meu pc o .dll
            //Testar noutro pc
            //webBrowser1.Navigate(query);
        }


        protected void LinkButton5_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/ContactUs.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AboutUs.aspx");
        }
    }
}
