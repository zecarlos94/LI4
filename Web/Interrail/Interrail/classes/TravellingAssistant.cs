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
        private List<Relatorio> relatorios = new List<Relatorio>();
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

            // Title
            string title = r.getTitulo();
            title = title.Replace(Environment.NewLine, String.Empty).Replace("  ", String.Empty);
            Font titleFont = FontFactory.GetFont("arial", 30f, Font.BOLD);
            titleFont.Color = BaseColor.BLACK;
            Chunk beginningReport = new Chunk(title, titleFont);
            Phrase p1 = new Phrase(beginningReport);
            Paragraph par = new Paragraph();
            par.Alignment = Element.ALIGN_CENTER;
            par.Add(p1);
            doc.Add(par);

            // Email
            string email = "Creator email: " + r.getCriador();
            email = email.Replace(Environment.NewLine, String.Empty).Replace("  ", String.Empty);
            Font emailFont = FontFactory.GetFont("arial", 10f);
            emailFont.Color = BaseColor.BLACK;
            Chunk beginningReportEmail = new Chunk(email, emailFont);
            Phrase p2 = new Phrase(beginningReportEmail);
            Paragraph par2 = new Paragraph();
            par2.Alignment = Element.ALIGN_CENTER;
            par2.Add(p2);
            doc.Add(par2);

            // Data
            string data = r.getData().ToString();
            data = data.Replace(Environment.NewLine, String.Empty).Replace("  ", String.Empty);
            Font dataFont = FontFactory.GetFont("arial", 10f);
            dataFont.Color = BaseColor.BLACK;
            Chunk beginningReportData = new Chunk(data, dataFont);
            Phrase p3 = new Phrase(beginningReportData);
            Paragraph par3 = new Paragraph();
            par3.Alignment = Element.ALIGN_CENTER;
            par3.Add(p3);
            doc.Add(par3);

            // Sections
            List<Section> sections = r.getSections();
            try
            {
                int section = 1;
                foreach (Section s in sections)
                {
                    doc.Add(new Chunk("\n"));
                    doc.Add(new Chunk("\n"));

                    // Title and Data
                    string titleSection = section.ToString() + ". " + s.getTitulo() + " (" + s.getData() + ")";
                    titleSection = titleSection.Replace(Environment.NewLine, String.Empty).Replace("  ", String.Empty);
                    Font titleSectionFont = FontFactory.GetFont("arial", 20f, Font.BOLD);
                    titleSectionFont.Color = BaseColor.BLACK;
                    Chunk beginningReportSection = new Chunk(titleSection, titleSectionFont);
                    Phrase p4 = new Phrase(beginningReportSection);
                    Paragraph par6 = new Paragraph();
                    par6.Add(p4);
                    doc.Add(par6);

                    // SubSections
                    List<SubSection> subSections = s.getSubSections();
                    int subSection = 1;
                    foreach(SubSection ss in subSections)
                    {
                        doc.Add(new Chunk("\n"));
                        doc.Add(new Chunk("\n"));

                        // Title and Data
                        string titleSubSection = section.ToString() + "." + subSection.ToString() + ". " + ss.getTitulo() + " (" + ss.getData() + ")";
                        titleSubSection = titleSubSection.Replace(Environment.NewLine, String.Empty).Replace("  ", String.Empty);
                        Font titleSubSectionFont = FontFactory.GetFont("arial", 14f, Font.BOLD);
                        titleSubSectionFont.Color = BaseColor.BLACK;
                        Chunk beginningReportSubSection = new Chunk(titleSubSection, titleSubSectionFont);
                        Phrase p5 = new Phrase(beginningReportSubSection);
                        Paragraph par7 = new Paragraph();
                        par7.Add(p5);
                        doc.Add(par7);

                        // Coordinates
                        string coordSubSection = ss.getCoordinates();
                        coordSubSection = coordSubSection.Replace(Environment.NewLine, String.Empty).Replace("  ", String.Empty);
                        Font coordSubSectionFont = FontFactory.GetFont("arial", 10f, Font.BOLD);
                        coordSubSectionFont.Color = BaseColor.BLACK;
                        Chunk beginningReportCoordSubSection = new Chunk(coordSubSection, coordSubSectionFont);
                        Phrase p6 = new Phrase(beginningReportCoordSubSection);
                        Paragraph par8 = new Paragraph();
                        par8.Add(p6);
                        doc.Add(par8);

                        // Text...

                        // Image
                        byte[] imageData = ss.getImage();
                        if(imageData != null)
                        {
                            Image img = Image.GetInstance(imageData);
                            img.ScaleToFit(doc.PageSize.Width, doc.PageSize.Height);
                            doc.Add(img);
                        }
                    }

                    section++;
                }
            }
            catch(NullReferenceException) { }

            doc.Close();
        }
    }
}