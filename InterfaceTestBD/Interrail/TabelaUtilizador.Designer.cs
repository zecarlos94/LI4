namespace Interrail
{
    partial class TabelaUtilizadorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.interrailDataSetUtilizador = new Interrail.InterrailDataSetUtilizador();
            this.utilizadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizadorTableAdapter = new Interrail.InterrailDataSetUtilizadorTableAdapters.UtilizadorTableAdapter();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primeiroNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apelidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interrailDataSetUtilizador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.primeiroNomeDataGridViewTextBoxColumn,
            this.apelidoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.utilizadorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(443, 229);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // interrailDataSetUtilizador
            // 
            this.interrailDataSetUtilizador.DataSetName = "InterrailDataSetUtilizador";
            this.interrailDataSetUtilizador.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilizadorBindingSource
            // 
            this.utilizadorBindingSource.DataMember = "Utilizador";
            this.utilizadorBindingSource.DataSource = this.interrailDataSetUtilizador;
            // 
            // utilizadorTableAdapter
            // 
            this.utilizadorTableAdapter.ClearBeforeFill = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // primeiroNomeDataGridViewTextBoxColumn
            // 
            this.primeiroNomeDataGridViewTextBoxColumn.DataPropertyName = "PrimeiroNome";
            this.primeiroNomeDataGridViewTextBoxColumn.HeaderText = "PrimeiroNome";
            this.primeiroNomeDataGridViewTextBoxColumn.Name = "primeiroNomeDataGridViewTextBoxColumn";
            // 
            // apelidoDataGridViewTextBoxColumn
            // 
            this.apelidoDataGridViewTextBoxColumn.DataPropertyName = "Apelido";
            this.apelidoDataGridViewTextBoxColumn.HeaderText = "Apelido";
            this.apelidoDataGridViewTextBoxColumn.Name = "apelidoDataGridViewTextBoxColumn";
            // 
            // TabelaUtilizadorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 338);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TabelaUtilizadorForm";
            this.Text = "Tabela \"Utilizador\"";
            this.Load += new System.EventHandler(this.TabelaUtilizador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interrailDataSetUtilizador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private InterrailDataSetUtilizador interrailDataSetUtilizador;
        private System.Windows.Forms.BindingSource utilizadorBindingSource;
        private InterrailDataSetUtilizadorTableAdapters.UtilizadorTableAdapter utilizadorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primeiroNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apelidoDataGridViewTextBoxColumn;
    }
}