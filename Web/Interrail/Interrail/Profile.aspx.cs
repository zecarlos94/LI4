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
    public partial class Profile : System.Web.UI.Page
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private TravellingAssistant ta = new TravellingAssistant();
        private Utilizador u;
        private string email;

        protected void Page_Load(object sender, EventArgs e)
        {
            email = Request.QueryString["id"];
            con = new SqlConnection(@"Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=Interrail;Integrated Security=True");
            {
                cmd = new SqlCommand("SELECT * FROM Utilizador WHERE Email = @Email", con);
                cmd.Parameters.AddWithValue("@Email", email);

                con.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string password = reader.GetString(1);
                    string firstName = reader.GetString(2);
                    string lastName = reader.GetString(3);

                    u = new Utilizador(email, password, firstName, lastName);
                    ta.setUtilizador(u);

                    FirstNameBox.Text = firstName;
                    LastNameBox.Text = lastName;
                    EmailBox.Text = email;
                    Password.Text = password;
                }
            }
        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            string res = "~/UserPage.aspx?id=" + email;
            Response.Redirect(res);
        }
    }
}