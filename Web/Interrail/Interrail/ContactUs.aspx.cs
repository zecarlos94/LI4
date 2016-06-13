using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using Interrail.classes;

namespace Interrail
{
    public partial class ContactUs : System.Web.UI.Page
    {
        private TravellingAssistant ta = new TravellingAssistant();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Home.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (EmailBox.Text != "" && SubjectBox.Text != "" && MessageBox.Text != "")
            {
                int res = ta.verificarEmail(EmailBox.Text);

                if (res == 0) ErrorLabel.Text = "Email not registered!";
                else {
                    /**string msg = EmailBox.Text + ";" + SubjectBox.Text + ": " + MessageBox.Text;
                    string result = "~/Home.aspx?id=" + msg;*/
                    string msg = SubjectBox.Text + ": " + MessageBox.Text;
                    ta.putMessage(EmailBox.Text, msg);
                    Response.Redirect("~/Home.aspx");
                }
            }
            else ErrorLabel.Text = "There are fields to fill!";
        }
    }
}