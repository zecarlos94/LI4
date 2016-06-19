﻿using System;
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
        private string email;

        string sql_id_local;
        string sql_local;
        string sql_data;

        public string getLocal(int id) {

            SqlConnection con = new SqlConnection(@"Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=Interrail;Integrated Security=True");
            SqlCommand cmmd;
            string localizacao = null;
            
            cmmd = new SqlCommand("SELECT * FROM Local WHERE Id = @Id", con);
            cmmd.Parameters.AddWithValue("@Id", id);
            con.Open();
            SqlDataReader local = cmmd.ExecuteReader();
            local.Read();
            localizacao = local.GetString(3) + ", " + local.GetString(4);
            con.Close();
            
            return localizacao;
        }

        public void insertLocais(int id) {
            SqlCommand cmmmd;
            SqlDataReader tasks;
            SqlConnection connn = new SqlConnection(@"Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=Interrail;Integrated Security=True");

            email = Request.QueryString["id"];
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
            cmmmd = new SqlCommand("SELECT * FROM Tarefa WHERE fk_Agenda = @Id", connn);
            cmmmd.Parameters.AddWithValue("@Id", id);

            connn.Open();

            tasks = cmmmd.ExecuteReader();

            while (tasks.Read())
            {


                string designacao = tasks.GetString(1);
                DateTime dataTarefa = tasks.GetDateTime(2);
                DateTime horafim = dataTarefa;
                horafim.AddHours(2);
                Event myEvent = new Event
                {

                    Summary = designacao,
                    Location = getLocal((int)tasks.GetValue(5)),
                    Start = new EventDateTime()
                    {
                        DateTime = dataTarefa

                    },
                    End = new EventDateTime()
                    {
                        DateTime = horafim
                    },
                    Attendees = new List<EventAttendee>()
                  {
                    new EventAttendee() { Email = "travellingassistantproject@gmail.com" }
                   }
                };

                Event recurringEvent1 = service.Events.Insert(myEvent, "primary").Execute();
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlDataReader reader;
            SqlConnection conn = new SqlConnection(@"Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=Interrail;Integrated Security=True");
            SqlCommand cmd;
                email = Request.QueryString["id"];
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
            request.TimeMin = new DateTime(1900, 1, 1, 0, 0, 0);
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 10;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;


            // List events.
            Events events = request.Execute();
            if (events.Items != null && events.Items.Count > 0)
            {
                foreach (var eventItem in events.Items)
                {
                    service.Events.Delete("primary", eventItem.Id).Execute();
                }
            }



            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            cmd = new SqlCommand("SELECT Id FROM Agenda WHERE fk_Utilizador = @Email", conn);
            cmd.Parameters.AddWithValue("@Email", email);



            SqlDataReader tarefas = cmd.ExecuteReader();

            while (tarefas.Read()) {
                insertLocais((int) tarefas.GetValue(0));

            }



        }



        protected void ButtonMes_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Home.aspx");
        }

        protected void ButtonDia_Click(object sender, EventArgs e)
        {
            string res = "~/Login.aspx";
            Response.Redirect(res);
        }

        protected void Label1_Click(object sender, EventArgs e)
        {
            string res = "~/UserPage.aspx?id=" + email;
            Response.Redirect(res);
        }
    }
}





