﻿namespace Interrail
{
    partial class Database
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
            this.GerirUtilizadorButton = new System.Windows.Forms.Button();
            this.ConsultarRegistos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GerirUtilizadorButton
            // 
            this.GerirUtilizadorButton.Location = new System.Drawing.Point(41, 34);
            this.GerirUtilizadorButton.Name = "GerirUtilizadorButton";
            this.GerirUtilizadorButton.Size = new System.Drawing.Size(162, 60);
            this.GerirUtilizadorButton.TabIndex = 0;
            this.GerirUtilizadorButton.Text = "Gerir Utilizadores";
            this.GerirUtilizadorButton.UseVisualStyleBackColor = true;
            this.GerirUtilizadorButton.Click += new System.EventHandler(this.AdicionarUtilizador_Click);
            // 
            // ConsultarRegistos
            // 
            this.ConsultarRegistos.Location = new System.Drawing.Point(41, 153);
            this.ConsultarRegistos.Name = "ConsultarRegistos";
            this.ConsultarRegistos.Size = new System.Drawing.Size(162, 59);
            this.ConsultarRegistos.TabIndex = 1;
            this.ConsultarRegistos.Text = "Consultar Registos";
            this.ConsultarRegistos.UseVisualStyleBackColor = true;
            this.ConsultarRegistos.Click += new System.EventHandler(this.ConsultarRegistos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Adicionar Local";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 59);
            this.button2.TabIndex = 3;
            this.button2.Text = "Insert Text";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 66);
            this.button3.TabIndex = 4;
            this.button3.Text = "Insert Music";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 375);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ConsultarRegistos);
            this.Controls.Add(this.GerirUtilizadorButton);
            this.Name = "Database";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GerirUtilizadorButton;
        private System.Windows.Forms.Button ConsultarRegistos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

