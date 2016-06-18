using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interrail
{
    public partial class Unfiltered : System.Web.UI.Page
    {
        string sql_unfiltered;
        string email;

        protected void Page_Load(object sender, EventArgs e)
        {
            string[] res = Request.QueryString["id"].Split('/');
            sql_unfiltered = res[0];
            email = res[1];
            if (!this.IsPostBack)
            {
                //ddlImages.DataSource = GetData("select id " + sql_unfiltered);
                ddlImages.DataSource = GetData("SELECT E.Id " + sql_unfiltered + ";");
                ddlImages.DataValueField = "Id";
                //ddlImages.DataValueField = "id";
                ddlImages.DataBind();
            }
        }



        public DataTable GetData(string query)
        {
            DataTable dt = new DataTable();

            string constr = @"Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=Interrail;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(dt);
                    }
                }
                return dt;
            }
        }

        protected void FetchImage(object sender, EventArgs e)
        {
            string id = ddlImages.SelectedItem.Value;
            Image1.Visible = id != "0";
            if (id != "0")
            {
                Object img = GetData("SELECT E.Imagem " + sql_unfiltered + " WHERE E.Id = " + id).Rows[0]["Imagem"];
                string aux = img.ToString();
                if(aux != "")
                {
                    byte[] bytes = (byte[]) img;
                    //byte[] bytes = (byte[])GetData("select img "+ sql_unfiltered + " where id=" + id).Rows[0]["img"];
                    string new_url = Convert.ToBase64String(bytes, 0, bytes.Length);
                    Image1.ImageUrl = "data:image/png;base64," + new_url;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = "~/Album.aspx?id=" + email;
            Response.Redirect(res);
        }
    }
}