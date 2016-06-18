namespace Interrail
{
    partial class ConsultarRegistosForm
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
            this.Utilizadores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Utilizadores
            // 
            this.Utilizadores.Location = new System.Drawing.Point(43, 30);
            this.Utilizadores.Name = "Utilizadores";
            this.Utilizadores.Size = new System.Drawing.Size(122, 58);
            this.Utilizadores.TabIndex = 0;
            this.Utilizadores.Text = "Utilizadores";
            this.Utilizadores.UseVisualStyleBackColor = true;
            this.Utilizadores.Click += new System.EventHandler(this.Utilizadores_Click);
            // 
            // ConsultarRegistosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 342);
            this.Controls.Add(this.Utilizadores);
            this.Name = "ConsultarRegistosForm";
            this.Text = "Consultar Registos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Utilizadores;
    }
}