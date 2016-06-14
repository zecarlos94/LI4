using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interrail
{
    public partial class Maps : System.Web.UI.Page
    {
        private string email;

        protected void Page_Load(object sender, EventArgs e)
        {
            email = Request.QueryString["id"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string link = "http://maps.google.com/maps?q=";
            string street = streetBox.Text;
            string city = cityBox.Text;
            string zip = ZipBox.Text;
            string country = countryBox.Text;
           
            StringBuilder queryAdress = new StringBuilder();
            queryAdress.Append(link);
            if (street != string.Empty)
            {
                queryAdress.Append(street + ",+");
            }
            if (city != string.Empty)
            {
                queryAdress.Append(city + ",+");
            }
            if (zip != string.Empty)
            {
                queryAdress.Append(zip + ",+");
            }
            if (country != string.Empty)
            {
                queryAdress.Append(country + ",+");
            }

            Response.Redirect(queryAdress.ToString());
                      
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = "~/UserPage.aspx?id=" + email;
            Response.Redirect(res);
        }
    }
}