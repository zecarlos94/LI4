using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Interrail.classes
{
    public class Section
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private int id;
        private string titulo;
        private DateTime data;
        private List<SubSection> subSections = new List<SubSection>();

        public Section(int id, string titulo, DateTime data)
        {
            this.id = id;
            this.titulo = titulo;
            this.data = data;

            con = new SqlConnection(@"Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=Interrail;Integrated Security=True");
            {
                cmd = new SqlCommand("SELECT * FROM Entrada WHERE fk_Tarefa = @Id", con);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    byte[] image = null;
                    byte[] audio = null;
                    byte[] text = null;

                    Object a = reader["Imagem"];
                    string s = a.ToString();
                    if (s != "")
                    {
                        image = (byte[]) a;
                    }

                    Object c = reader["FicheiroAudio"];
                    string s3 = c.ToString();
                    if (s3 != "")
                    {
                        audio = (byte[]) c;
                    }

                    Object b = reader["FicheiroTexto"];
                    string s2 = b.ToString();
                    if(s2 != "")
                    {
                        text = (byte[]) b;
                    }

                    string entradaTitle = reader.GetString(4);
                    string coord = reader["Coordenadas"].ToString();
                    DateTime entradaData = reader.GetDateTime(6);

                    SubSection ss = new SubSection(image, audio, text, entradaTitle, coord, entradaData);
                    this.subSections.Add(ss);
                }
            }
        }

        public string getTitulo()
        {
            return this.titulo;
        }

        public DateTime getData()
        {
            return this.data;
        }

        public List<SubSection> getSubSections()
        {
            return this.subSections;
        }
    }
}