using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Interrail.classes;

namespace Interrail
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (EmailBox.Text != "" && PasswordBox.Text != "")
            {
                TravellingAssistant ta = new TravellingAssistant();
                int res = ta.verificarLogin(EmailBox.Text, PasswordBox.Text);

                if(res == 0) ErrorLabel.Text = "Invalid email or password!";
                else Response.Redirect("~/Home.aspx"); // Mais tarde irá para a página do utilizador
            }
            else ErrorLabel.Text = "There are fields to fill!";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Home.aspx");
        }
    }
}