using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Interrail.classes;

namespace Interrail
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Home.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (EmailBox.Text != "" && PasswordBox.Text != "" && FirstNameBox.Text != "" && LastNameBox.Text != "")
            {
                TravellingAssistant ta = new TravellingAssistant();
                int res = ta.criarConta(EmailBox.Text, PasswordBox.Text, FirstNameBox.Text, LastNameBox.Text);

                if(res == 0) Response.Redirect("~/Home.aspx"); // Mais tarde irá para a página do utilizador
                else ErrorLabel.Text = "Email already exists!";
            }
            else ErrorLabel.Text = "There are fields to fill!";
        }
    }
}