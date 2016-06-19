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
        public void Page_Load(Object sender, EventArgs e)
        {
            string email = Request.QueryString["id"];
            string agenda = Request.QueryString["agenda"];
            string script = "LoadMap(" + email + "," + agenda + ")";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "unique_key",script, true);
        }

    }
}