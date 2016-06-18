using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interrail {

    public partial class TabelaUtilizadorForm : Form {

        public TabelaUtilizadorForm() {

            InitializeComponent();

        }

        private void TabelaUtilizador_Load(object sender, EventArgs e) {

            // TODO: This line of code loads data into the 'interrailDataSetUtilizador.Utilizador' table. You can move, or remove it, as needed.
            this.utilizadorTableAdapter.Fill(this.interrailDataSetUtilizador.Utilizador);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

    }

}
