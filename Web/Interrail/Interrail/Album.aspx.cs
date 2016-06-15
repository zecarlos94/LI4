using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Interrail
{
    public partial class Album : System.Web.UI.Page
    {
        DataTable dt;//save all results 
        SqlCommand command;
        SqlDataReader reader;
        SqlConnection conn = new SqlConnection(@"Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=Interrail;Integrated Security=True");
        int atualImage = 0;
        int imgsCount = 0;
        string sql_id_local;
        string sql_local;
        string sql_data;
        byte[] bytes;//retrieved binary from Database
        string email;

        protected void Page_Load(object sender, EventArgs e)
        {
            email = Request.QueryString["id"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
 
            sql_id_local = "select L.Id from dbo.Local as L where L.Descricao like '" + cityBox.Text + "' ;" ;
            sql_local= "select Imagem from dbo.Local as L inner join  dbo.Tarefa as T on " +
               sql_id_local
               + "= T.fk_Local inner join dbo.Entrada as E on T.Id = E.fk_Tarefa where L.Coordenadas.STEquals(E.Coordenadas) = 1; ";
            sql_data= "select Imagem from dbo.Tarefa as T inner join dbo.Entrada as E on T.Id = E.fk_Tarefa where '" + dateBox.Text + "' = CAST( E.Data as date); ";
            //select CAST('2000-03-30 12:00:23' as date);

            if(conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            if (cityBox.Text != string.Empty)
            {
                command = new SqlCommand(sql_local, conn);
            }

            else if (dateBox.Text != string.Empty)
            {
                command = new SqlCommand(sql_data, conn);
            }

            reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                //load all results from query
                using (dt = new DataTable())
                {
                    dt.Load(reader);
                    imgsCount=dt.Rows.Count;//total number of imgs
                }

                //Display first result
                bytes = (byte[])(reader[2 + atualImage]);
                atualImage++;
                if (bytes != null)
                {
                    string new_url = Convert.ToBase64String(bytes, 0, bytes.Length);
                    Image1.ImageUrl = "data:image/png;base64, " + new_url;
                }                             
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //load previous image if is not the first
            if (atualImage != 0)
            {
                bytes = (byte[])(reader[2 + atualImage - 1]);
                atualImage--;
                if (bytes != null)
                {
                    string new_url = Convert.ToBase64String(bytes, 0, bytes.Length);
                    Image1.ImageUrl = "data:image/png;base64, " + new_url;
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //load next image
            if (atualImage < imgsCount)
            {
                bytes = (byte[])(reader[2 + atualImage]);
                atualImage++;
                if (bytes != null)
                {
                    string new_url = Convert.ToBase64String(bytes, 0, bytes.Length);
                    Image1.ImageUrl = "data:image/png;base64, " + new_url;
                }
            }

        }
       
        protected void Button4_Click(object sender, EventArgs e)
        {
            string res = "~/UserPage.aspx?id=" + email;
            Response.Redirect(res);
        }

    }
}