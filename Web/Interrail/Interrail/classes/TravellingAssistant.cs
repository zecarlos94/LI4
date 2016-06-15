using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Configuration;

namespace Interrail.classes
{
    public class TravellingAssistant
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private Utilizador u;
        private List<Relatorio> relatorios;
        // Set de agendas
       
        public void setUtilizador(Utilizador u)
        {
            this.u = u;
        }

        public int verificarLogin(string email, string password)
        {
            con = new SqlConnection(@"Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=Interrail;Integrated Security=True");
            {
                cmd = new SqlCommand("SELECT * FROM Utilizador WHERE Email = @Email AND Password = @Password", con);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                con.Open();
                var reader = cmd.ExecuteReader();
                int action = 0;

                while (reader.Read())
                {
                    action++;
                }

                return action;
            }
        }

        public int verificarEmail(string email)
        {
            con = new SqlConnection(@"Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=Interrail;Integrated Security=True");
            {
                cmd = new SqlCommand("SELECT * FROM Utilizador WHERE Email = @Email", con);
                cmd.Parameters.AddWithValue("@Email", email);

                con.Open();
                var reader = cmd.ExecuteReader();
                int action = 0;

                while (reader.Read())
                {
                    action++;
                }

                return action;
            }
        }

        public int criarConta(string email, string password, string primeiroNome, string ultimoNome)
        {
            con = new SqlConnection(@"Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=Interrail;Integrated Security=True");
            {

                cmd = new SqlCommand("INSERT INTO Utilizador(Email, Password, PrimeiroNome, Apelido) VALUES(@Email, @Password, @PrimeiroNome, @Apelido)", con);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@PrimeiroNome", primeiroNome);
                cmd.Parameters.AddWithValue("@Apelido", ultimoNome);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    return 1;
                }
                con.Close();

                return 0;
            }
        }

        public void gerarRelatorio(int id)
        {
            Relatorio r = new Relatorio(id);

            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(Path.Combine("c:\\Users\\Tiago\\Desktop\\", r.getTitulo() + ".pdf"), FileMode.Create));
            doc.Open();

            Paragraph par = new Paragraph(r.getTitulo());

            doc.Add(par);
            doc.Close();
        }
    }
}