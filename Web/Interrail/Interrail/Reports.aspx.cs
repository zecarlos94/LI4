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
    public partial class Reports : System.Web.UI.Page
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private TravellingAssistant ta = new TravellingAssistant();
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
            if (ReportList.Items.Count == 0 || ReportList.GetSelectedIndices().Count() == 0) ErrorLabel.Text = "There are no reports selected!";
            else
            {
                string[] words = ReportList.SelectedItem.ToString().Split('#');
                int reportId = int.Parse(words[0]);
                this.ta.gerarRelatorio(reportId);
                ErrorLabel.Text = "Report generated!";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ReportList.Items.Clear();

            con = new SqlConnection(@"Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=Interrail;Integrated Security=True");
            {
                if (LocalCheck.Checked == false) cmd = new SqlCommand("SELECT Id, Titulo, Data, fk_Utilizador FROM Relatorio WHERE Tipo = 0", con);
                else
                {
                    cmd = new SqlCommand("SELECT Relatorio.Id, Relatorio.Titulo, Relatorio.Data, Relatorio.fk_Utilizador FROM Relatorio INNER JOIN Tarefa AS T ON T.fk_Relatorio = Relatorio.Id INNER JOIN Local AS L ON T.fk_Local = L.Id WHERE Relatorio.Tipo = 0 AND L.Descricao LIKE @Local", con);
                    cmd.Parameters.AddWithValue("@Local", LocalBox.Text);
                }

                con.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader.GetValue(0).ToString();
                    string title = reader.GetString(1);
                    string date = reader.GetDateTime(2).ToString();
                    string utilizador = reader.GetString(3);

                    string line = id + "# TITLE: " + title + " / DATE: " + date + " / WRITER EMAIL: " + utilizador;
                    ReportList.Items.Add(new ListItem(line));
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ReportList.Items.Clear();

            con = new SqlConnection(@"Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=Interrail;Integrated Security=True");
            {
                if (LocalCheck.Checked == false)
                {
                    cmd = new SqlCommand("SELECT Id, Titulo, Data, fk_Utilizador FROM Relatorio WHERE fk_Utilizador = @Email", con);
                    cmd.Parameters.AddWithValue("@Email", email);
                }
                else
                {
                    cmd = new SqlCommand("SELECT Relatorio.Id, Relatorio.Titulo, Relatorio.Data FROM Relatorio INNER JOIN Tarefa AS T ON T.fk_Relatorio = Relatorio.Id INNER JOIN Local AS L ON T.fk_Local = L.Id WHERE Relatorio.fk_Utilizador = @Email AND L.Descricao LIKE @Local", con);
                    cmd.Parameters.AddWithValue("@Local", LocalBox.Text);
                    cmd.Parameters.AddWithValue("@Email", email);
                }

                con.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader.GetValue(0).ToString();
                    string title = reader.GetString(1);
                    string date = reader.GetDateTime(2).ToString();

                    string line = id + "# TITLE: " + title + " / DATE: " + date;
                    ReportList.Items.Add(new ListItem(line));
                }
            }
        }
    }
}