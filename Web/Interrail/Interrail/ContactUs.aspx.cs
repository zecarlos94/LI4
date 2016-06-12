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
                TravellingAssistant ta = new TravellingAssistant();
                int res = ta.verificarEmail(EmailBox.Text);

                if (res == 0) ErrorLabel.Text = "Email not registered!";
                else {
                    MailMessage mailMessage = new MailMessage();
                    mailMessage.To.Add("travellingAssistantProject@gmail.com");
                    mailMessage.From = new MailAddress(EmailBox.Text);
                    mailMessage.Subject = SubjectBox.Text;
                    mailMessage.Body = MessageBox.Text;
                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                    smtpClient.EnableSsl = true;
                    smtpClient.Send(mailMessage);
                    Response.Redirect("~/Home.aspx");
                }
            }
            else ErrorLabel.Text = "There are fields to fill!";
        }
    }
}