using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Interrail.classes;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Interrail
{
    public partial class RoutesMap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string email, agenda;
            SqlCommand cmmmd;
            SqlDataReader tasks;
            SqlConnection connn = new SqlConnection(@"Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=Interrail;Integrated Security=True");

            email = Request.QueryString["id"];
            agenda = Request.QueryString["agenda"];
            cmmmd = new SqlCommand("SELECT Local FROM Tarefa WHERE fk_Agenda = @Id", connn);
            cmmmd.Parameters.AddWithValue("@Id", agenda);

            connn.Open();

            tasks = cmmmd.ExecuteReader();

            while (tasks.Read())
            {

                SqlCommand cmd;
                SqlDataReader locais;
                SqlConnection con = new SqlConnection(@"Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=Interrail;Integrated Security=True");
                
                cmd = new SqlCommand("SELECT Descricao, Coordenadas.ToString(), Cidade, Pais FROM Local WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Id", tasks.GetValue(0));

                con.Open();

                locais = cmd.ExecuteReader();
                string title = locais.GetString(0);
                string description = locais.GetString(2) + "," + locais.GetString(3);
                string coords = locais.GetString(1);
                string[] stringSeparators = new string[] { " " };
                string[] latLong = coords.Split(stringSeparators, StringSplitOptions.None);
                string lat = ((string)latLong[0]).Substring(7, latLong.Length - 7);
                string lon = ((string)latLong[1]).Substring(0, latLong.Length-1);
                double latitude = Convert.ToDouble(lat);
                double longitude = Convert.ToDouble(lon);
            }
        }
    }
}