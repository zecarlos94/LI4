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

        protected void Page_Load(object sender, EventArgs e)
        {
            sql_unfiltered = Request.QueryString["id"];
            if (!this.IsPostBack)
            {
                ddlImages.DataSource = GetData("select id " + sql_unfiltered);
                //ddlImages.DataSource = GetData("select E.Id" + sql_unfiltered);
                //ddlImages.DataValueField = "Id";
                ddlImages.DataValueField = "id";
                ddlImages.DataBind();
            }
        }



        private DataTable GetData(string query)
        {
            DataTable dt = new DataTable();

            string constr = "Data Source=DESKTOP-S7U3MP8\\SQLEXPRESS;Initial Catalog=ImageGallery;Integrated Security=True";
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
                //byte[] bytes = (byte[])GetData("select E.Imagem " + sql_unfiltered + " where id=" + id).Rows[0]["Imagem"];
                byte[] bytes = (byte[])GetData("select img "+ sql_unfiltered + " where id=" + id).Rows[0]["img"];
                string new_url = Convert.ToBase64String(bytes, 0, bytes.Length);
                Image1.ImageUrl = "data:image/png;base64," + new_url;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = "~/Album.aspx";
            Response.Redirect(res);
        }
    }
}