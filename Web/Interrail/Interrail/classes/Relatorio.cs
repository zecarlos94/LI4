using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Interrail.classes
{
    public class Relatorio
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private int id;
        private DateTime data;
        private string titulo;
        private string criador;
        private List<Section> sections;

        public Relatorio(int id)
        {
            this.id = id;
            con = new SqlConnection(@"Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=Interrail;Integrated Security=True");
            {
                cmd = new SqlCommand("SELECT * FROM Relatorio WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.data = reader.GetDateTime(1);
                    this.titulo = reader.GetString(2);
                    this.criador = reader.GetString(4);
                }
                getSections();
            }
        }

        public DateTime getData()
        {
            return this.data;
        }

        public string getTitulo()
        {
            return this.titulo;
        }

        public string getCriador()
        {
            return this.criador;
        }

        public void getSections()
        {
            con = new SqlConnection(@"Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=Interrail;Integrated Security=True");
            {
                cmd = new SqlCommand("SELECT * FROM Tarefa WHERE fk_Relatorio = @Id", con);
                cmd.Parameters.AddWithValue("@Id", this.id);

                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int idTarefa = (int) reader.GetValue(0);
                    string designacao = reader.GetString(1);
                    DateTime dataTarefa = reader.GetDateTime(2);

                    Section s = new Section(idTarefa, designacao, dataTarefa);

                    try
                    {
                        this.sections.Add(s);
                    }
                    catch(NullReferenceException) {}
                }
            }
        }
    }
}