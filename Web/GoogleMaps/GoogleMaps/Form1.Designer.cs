namespace GoogleMaps
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.streetTB = new System.Windows.Forms.TextBox();
            this.cityTB = new System.Windows.Forms.TextBox();
            this.stateTB = new System.Windows.Forms.TextBox();
            this.zipTB = new System.Windows.Forms.TextBox();
            this.streetL = new System.Windows.Forms.Label();
            this.cityL = new System.Windows.Forms.Label();
            this.stateL = new System.Windows.Forms.Label();
            this.zipL = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.search);
            this.splitContainer1.Panel1.Controls.Add(this.zipL);
            this.splitContainer1.Panel1.Controls.Add(this.stateL);
            this.splitContainer1.Panel1.Controls.Add(this.cityL);
            this.splitContainer1.Panel1.Controls.Add(this.streetL);
            this.splitContainer1.Panel1.Controls.Add(this.zipTB);
            this.splitContainer1.Panel1.Controls.Add(this.stateTB);
            this.splitContainer1.Panel1.Controls.Add(this.cityTB);
            this.splitContainer1.Panel1.Controls.Add(this.streetTB);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(744, 397);
            this.splitContainer1.SplitterDistance = 199;
            this.splitContainer1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(541, 397);
            this.webBrowser1.TabIndex = 0;
            // 
            // streetTB
            // 
            this.streetTB.Location = new System.Drawing.Point(73, 25);
            this.streetTB.Name = "streetTB";
            this.streetTB.Size = new System.Drawing.Size(100, 20);
            this.streetTB.TabIndex = 0;
            // 
            // cityTB
            // 
            this.cityTB.Location = new System.Drawing.Point(73, 80);
            this.cityTB.Name = "cityTB";
            this.cityTB.Size = new System.Drawing.Size(100, 20);
            this.cityTB.TabIndex = 1;
            // 
            // stateTB
            // 
            this.stateTB.Location = new System.Drawing.Point(73, 137);
            this.stateTB.Name = "stateTB";
            this.stateTB.Size = new System.Drawing.Size(100, 20);
            this.stateTB.TabIndex = 2;
            // 
            // zipTB
            // 
            this.zipTB.Location = new System.Drawing.Point(73, 205);
            this.zipTB.Name = "zipTB";
            this.zipTB.Size = new System.Drawing.Size(100, 20);
            this.zipTB.TabIndex = 3;
            // 
            // streetL
            // 
            this.streetL.AutoSize = true;
            this.streetL.Location = new System.Drawing.Point(36, 31);
            this.streetL.Name = "streetL";
            this.streetL.Size = new System.Drawing.Size(35, 13);
            this.streetL.TabIndex = 4;
            this.streetL.Text = "Street";
            // 
            // cityL
            // 
            this.cityL.AutoSize = true;
            this.cityL.Location = new System.Drawing.Point(36, 87);
            this.cityL.Name = "cityL";
            this.cityL.Size = new System.Drawing.Size(24, 13);
            this.cityL.TabIndex = 5;
            this.cityL.Text = "City";
            // 
            // stateL
            // 
            this.stateL.AutoSize = true;
            this.stateL.Location = new System.Drawing.Point(39, 143);
            this.stateL.Name = "stateL";
            this.stateL.Size = new System.Drawing.Size(32, 13);
            this.stateL.TabIndex = 6;
            this.stateL.Text = "State";
            // 
            // zipL
            // 
            this.zipL.AutoSize = true;
            this.zipL.Location = new System.Drawing.Point(39, 211);
            this.zipL.Name = "zipL";
            this.zipL.Size = new System.Drawing.Size(22, 13);
            this.zipL.TabIndex = 7;
            this.zipL.Text = "Zip";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(73, 304);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 8;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 397);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label zipL;
        private System.Windows.Forms.Label stateL;
        private System.Windows.Forms.Label cityL;
        private System.Windows.Forms.Label streetL;
        private System.Windows.Forms.TextBox zipTB;
        private System.Windows.Forms.TextBox stateTB;
        private System.Windows.Forms.TextBox cityTB;
        private System.Windows.Forms.TextBox streetTB;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

