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
    public partial class Agenda : System.Web.UI.Page
    {
        
        static string ApplicationName = "Google Calendar API Quickstart";
        private TravellingAssistant ta = new TravellingAssistant();
        private Utilizador u;
        private SqlConnection con;
        private SqlCommand cmd;
        private string email;
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
            UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets
                {
                    ClientId = "398537552404-5qg321due18i3qpo5hsfs10c4563use2.apps.googleusercontent.com",
                    ClientSecret = "MdxNx6Ko_mL0k6w3ftTRAqyb",
                },
                new[] { CalendarService.Scope.Calendar },
                "user",
                CancellationToken.None).Result;

            // Create Google Calendar API service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            

           /* Event myEvent = new Event
            {
                Summary = "Appointment",
                Location = "Somewhere",
                Start = new EventDateTime()
                {
                    DateTime = new DateTime(2016, 6, 22, 10, 0, 0),
                    TimeZone = "America/Los_Angeles"
                },  
                End = new EventDateTime()
                {
                    DateTime = new DateTime(2016, 6, 22, 10, 30, 0),
                    TimeZone = "America/Los_Angeles"
                },
                Attendees = new List<EventAttendee>()
                 {
                   new EventAttendee() { Email = "travellingassistantproject@gmail.com" }
                  }
            };*/

          //  Event recurringEvent1 = service.Events.Insert(myEvent, "primary").Execute();

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
             new ClientSecrets
             {
                 ClientId = "398537552404-5qg321due18i3qpo5hsfs10c4563use2.apps.googleusercontent.com",
                 ClientSecret = "MdxNx6Ko_mL0k6w3ftTRAqyb",
             },
             new[] { CalendarService.Scope.Calendar },
             "user",
             CancellationToken.None).Result;

            // Create Google Calendar API service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.
            EventsResource.ListRequest request = service.Events.List("primary");
            request.TimeMin = new DateTime(2016, 6, 1, 10, 0, 0);
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 10;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            Events events = request.Execute();
            Label2.Text = Label2.Text + ("Upcoming events:");
            if (events.Items != null && events.Items.Count > 0)
            {
                foreach (var eventItem in events.Items)
                {
                    service.Events.Delete("primary", eventItem.Id).Execute();
                }
            }

            Response.Redirect("~/Agenda.aspx");
        }

        protected void ButtonMes_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Home.aspx");
        }

        protected void ButtonDia_Click(object sender, EventArgs e)
        {
            string res = "~/Login.aspx" ;
            Response.Redirect(res);
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Signup.aspx");
        }
    }
}