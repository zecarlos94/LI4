using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interrail {

    public partial class AdicionarUtilizadorForm : Form
    {

        private SqlConnection con;
        private SqlCommand cmd;

        public AdicionarUtilizadorForm()
        {

            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdicionarButton_Click(object sender, EventArgs e)
        {

            int action = 0;

            con = new SqlConnection(@"Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=Interrail;Integrated Security=True");
            {

                if (EmailBox.Text != "" && PasswordBox.Text != "" && NomeBox.Text != "" && ApelidoBox.Text != "")
                {

                    cmd = new SqlCommand("INSERT INTO Utilizador(Email, Password, PrimeiroNome, Apelido) VALUES(@Email, @Password, @PrimeiroNome, @Apelido)", con);
                    cmd.Parameters.AddWithValue("@Email", EmailBox.Text);
                    cmd.Parameters.AddWithValue("@Password", PasswordBox.Text);
                    cmd.Parameters.AddWithValue("@PrimeiroNome", NomeBox.Text);
                    cmd.Parameters.AddWithValue("@Apelido", ApelidoBox.Text);

                    con.Open();
                    try
                    {

                        cmd.ExecuteNonQuery();

                    }
                    catch (SqlException)
                    {

                        MessageBox.Show("O email inserido já está registado! Por favor, introduza outro!", "Erro", MessageBoxButtons.OK);
                        action--;

                    }
                    con.Close();

                    action++;

                }
                else MessageBox.Show("Existem espaços por preencher!", "Erro", MessageBoxButtons.OK);

            }

            if (action == 1) this.Close();

        }

        private void LimparButton_Click(object sender, EventArgs e)
        {

            EmailBox.Text = "";
            PasswordBox.Text = "";
            NomeBox.Text = "";
            ApelidoBox.Text = "";

        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {

            int action = 0;

            con = new SqlConnection(@"Data Source=TIAGO-PC\TIAGOSERVER;Initial Catalog=Interrail;Integrated Security=True");
            {

                if (EmailBox.Text != "" && PasswordBox.Text != "")
                {

                    cmd = new SqlCommand("DELETE FROM Utilizador WHERE Email = @Email AND Password = @Password", con);
                    cmd.Parameters.AddWithValue("@Email", EmailBox.Text);
                    cmd.Parameters.AddWithValue("@Password", PasswordBox.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    action++;

                }
                else MessageBox.Show("Existem espaços por preencher!", "Erro", MessageBoxButtons.OK);

            }

            if (action == 1) this.Close();

        }

    }

}
