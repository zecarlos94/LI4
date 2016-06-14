using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Interrail
{
    public partial class Reports : System.Web.UI.Page
    {

        private SqlConnection con;
        private SqlCommand cmd;
        private string email;

        protected void Page_Load(object sender, EventArgs e)
        {
            email = Request.QueryString["id"];
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string res = "~/UserPage.aspx?id=" + email;
            Response.Redirect(res);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (ReportList.Items.Count == 0) ErrorLabel.Text = "There is no report selected!";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ReportList.Items.Clear();

            if(LocalCheck.Checked == false)
            {
                con = new SqlConnection(@"Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=Interrail;Integrated Security=True");
                {
                    cmd = new SqlCommand("SELECT Id, Titulo, Data, fk_Utilizador FROM Relatorio WHERE Tipo = 0", con);

                    con.Open();
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string id = reader.GetValue(0).ToString();
                        string title = reader.GetString(1);
                        string date = reader.GetDateTime(2).ToString();
                        string utilizador = reader.GetString(3);

                        string line = id + "# Title: " + title + " / Date: " + date + " / Writer email: " + utilizador;
                        ReportList.Items.Add(new ListItem(line));
                    }
                }
            }
        }
    }
}