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

    public partial class ConsultarRegistosForm : Form {

        public ConsultarRegistosForm() {

            InitializeComponent();

        }

        private void Utilizadores_Click(object sender, EventArgs e) {

            TabelaUtilizadorForm tu = new TabelaUtilizadorForm();
            tu.Show();

        }

    }

}
