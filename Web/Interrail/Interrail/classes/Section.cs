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
                    byte[] image = (byte[]) reader["Imagem"];
                    string entradaTitle = reader.GetString(4);
                    string coord = reader["Coordenadas"].ToString();
                    DateTime entradaData = reader.GetDateTime(6);

                    SubSection ss = new SubSection(image, entradaTitle, coord, entradaData);
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