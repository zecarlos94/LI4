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
        //string email;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            // email = Request.QueryString["id"];

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (cityBox.Text!=string.Empty) {
                string sql_local = "from dbo.Local as L inner join  dbo.Tarefa as T on (select L.Id from dbo.Local as L where L.Descricao like '" + cityBox.Text
                + "') = T.fk_Local inner join dbo.Entrada as E on T.Id = E.fk_Tarefa where L.Coordenadas.STEquals(E.Coordenadas) = 1 ";

                /*
                Por exemplo,
                select E.Id,E.Imagem from dbo.Local as L inner join  dbo.Tarefa as T 
	                on (select L.Id from dbo.Local as L where L.Descricao like 'Braga') = T.fk_Local 
	                inner join dbo.Entrada as E on T.Id = E.fk_Tarefa where L.Coordenadas.STEquals(E.Coordenadas) = 1
                */

                string res = "~/FilterCity.aspx?id=" + sql_local;
                Response.Redirect(res);
            }
            else if (dateBox.Text!=string.Empty) {
                string sql_data="from dbo.Tarefa as T inner join dbo.Entrada as E on T.Id = E.fk_Tarefa where '" + dateBox.Text + "' = CAST( E.Data as date) ";
                string res = "~/FilterDate.aspx?id=" + sql_data;
                Response.Redirect(res);
            }
            else {
                //string sql_all_id = "from dbo.Tarefa as T inner join dbo.Entrada as E on T.Id = E.fk_Tarefa;";
                string sql_all_id = "from Test ";
                string res = "~/Unfiltered.aspx?id=" + sql_all_id;
                Response.Redirect(res);
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //string res = "~/UserPage.aspx?id=" + email;
            //Response.Redirect(res);
        }

    }
}