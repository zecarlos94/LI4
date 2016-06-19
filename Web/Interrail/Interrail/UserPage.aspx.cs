﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Interrail.classes;

namespace Interrail
{
    public partial class UserPage : System.Web.UI.Page
    {
        private TravellingAssistant ta = new TravellingAssistant();
        private Utilizador u;
        private SqlConnection con;
        private SqlCommand cmd;
        private string email;

        protected void Page_Load(object sender, EventArgs e)
        {
            email = Request.QueryString["id"];
            con = new SqlConnection(@"Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=Interrail;Integrated Security=True");
            {
                cmd = new SqlCommand("SELECT * FROM Utilizador WHERE Email = @Email", con);
                cmd.Parameters.AddWithValue("@Email", email);

                con.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string password = reader.GetString(1);
                    string firstName = reader.GetString(2);
                    string lastName = reader.GetString(3);

                    u = new Utilizador(email, password, firstName, lastName);
                    ta.setUtilizador(u);

                    string labelText = "Welcome, " + firstName + " " + lastName;
                    Label1.Text = labelText;
                }
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Home.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = "~/Profile.aspx?id=" + email;
            Response.Redirect(res);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string res = "~/Maps.aspx?id=" + email;
            Response.Redirect(res);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string res = "~/Reports.aspx?id=" + email;
            Response.Redirect(res);
        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            string res = "~/Agenda.aspx?id=" + email;
            Response.Redirect(res);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = "~/Album.aspx?id=" + email;
            Response.Redirect(res);
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            email = Request.QueryString["id"];
            int agendaId = -1;
            con = new SqlConnection(@"Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=Interrail;Integrated Security=True");
            
                cmd = new SqlCommand("SELECT * FROM Agenda", con);

                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    
                    DateTime dataAgenda = reader.GetDateTime(2);

                    if (dataAgenda.Day == System.DateTime.Now.Day && dataAgenda.Month == System.DateTime.Now.Month && dataAgenda.Year == System.DateTime.Now.Year) {
                        agendaId = (int) reader.GetValue(0);
                    }
                }

            string res = "~/RouteMap.aspx?id=" + email + "&agenda="+ agendaId;
            Response.Redirect(res);
        }
    }
}