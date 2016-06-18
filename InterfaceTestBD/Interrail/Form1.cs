using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Interrail {

    public partial class Database : Form
    {

        private SqlConnection con;
        private SqlCommand cmd;

        public Database()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AdicionarUtilizador_Click(object sender, EventArgs e)
        {

            AdicionarUtilizadorForm addUser = new AdicionarUtilizadorForm();
            addUser.Show();

        }

        private void ConsultarRegistos_Click(object sender, EventArgs e)
        {

            ConsultarRegistosForm cr = new ConsultarRegistosForm();
            cr.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=Interrail;Integrated Security=True");
            {
                byte [] txt = System.IO.File.ReadAllBytes("C:\\Users\\Tiago\\Desktop\\example.txt");

                cmd = new SqlCommand("INSERT INTO Entrada (Id, Imagem, FicheiroAudio, FicheiroTexto, Nome, Coordenadas, Data, fk_Tarefa) VALUES (1, null, null, @Text, 'Entrada c/imagem',  geography::STGeomFromText('LINESTRING(52 22.22, 4 53.37)', 4326), convert(datetime,'18-06-12 10:34:09 PM', 5), 1)", con);
                cmd.Parameters.AddWithValue("@Text", txt);

                con.Open();
                try
                {

                    cmd.ExecuteNonQuery();

                }
                catch (SqlException) { }
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=Interrail;Integrated Security=True");
            {
                byte [] music = System.IO.File.ReadAllBytes("C:\\Users\\Tiago\\Desktop\\example.mp3");

                cmd = new SqlCommand("INSERT INTO Entrada (Id, Imagem, FicheiroAudio, FicheiroTexto, Nome, Coordenadas, Data, fk_Tarefa) VALUES (1, null, @Audio, null, 'Entrada c/imagem',  geography::STGeomFromText('LINESTRING(52 22.22, 4 53.37)', 4326), convert(datetime,'18-06-12 10:34:09 PM', 5), 1)", con);
                cmd.Parameters.AddWithValue("@Audio", music);

                con.Open();
                try
                {

                    cmd.ExecuteNonQuery();

                }
                catch (SqlException) { }
                con.Close();
            }
        }
    }

}
