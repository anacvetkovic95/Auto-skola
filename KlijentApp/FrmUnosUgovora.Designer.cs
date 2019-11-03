namespace KlijentApp
{
    partial class FrmUnosUgovora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnosUgovora));
            this.gbUcenik = new System.Windows.Forms.GroupBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.cmbObuka = new System.Windows.Forms.ComboBox();
            this.cmbInstruktor = new System.Windows.Forms.ComboBox();
            this.dgvUcenici = new System.Windows.Forms.DataGridView();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbUcenik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenici)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUcenik
            // 
            this.gbUcenik.Controls.Add(this.txtNaziv);
            this.gbUcenik.Controls.Add(this.cmbObuka);
            this.gbUcenik.Controls.Add(this.cmbInstruktor);
            this.gbUcenik.Controls.Add(this.dgvUcenici);
            this.gbUcenik.Controls.Add(this.btnSacuvaj);
            this.gbUcenik.Controls.Add(this.label6);
            this.gbUcenik.Controls.Add(this.label3);
            this.gbUcenik.Controls.Add(this.label1);
            this.gbUcenik.Enabled = false;
            this.gbUcenik.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUcenik.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbUcenik.Location = new System.Drawing.Point(12, 45);
            this.gbUcenik.Name = "gbUcenik";
            this.gbUcenik.Size = new System.Drawing.Size(1039, 524);
            this.gbUcenik.TabIndex = 8;
            this.gbUcenik.TabStop = false;
            this.gbUcenik.Text = "Sačuvaj ugovor";
            this.gbUcenik.Enter += new System.EventHandler(this.gbUcenik_Enter);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(166, 40);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(220, 26);
            this.txtNaziv.TabIndex = 16;
            // 
            // cmbObuka
            // 
            this.cmbObuka.FormattingEnabled = true;
            this.cmbObuka.Location = new System.Drawing.Point(166, 117);
            this.cmbObuka.Name = "cmbObuka";
            this.cmbObuka.Size = new System.Drawing.Size(554, 26);
            this.cmbObuka.TabIndex = 15;
            // 
            // cmbInstruktor
            // 
            this.cmbInstruktor.FormattingEnabled = true;
            this.cmbInstruktor.Location = new System.Drawing.Point(166, 78);
            this.cmbInstruktor.Name = "cmbInstruktor";
            this.cmbInstruktor.Size = new System.Drawing.Size(554, 26);
            this.cmbInstruktor.TabIndex = 14;
            // 
            // dgvUcenici
            // 
            this.dgvUcenici.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvUcenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcenici.Location = new System.Drawing.Point(45, 173);
            this.dgvUcenici.Name = "dgvUcenici";
            this.dgvUcenici.RowTemplate.Height = 24;
            this.dgvUcenici.Size = new System.Drawing.Size(932, 264);
            this.dgvUcenici.TabIndex = 12;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.DimGray;
            this.btnSacuvaj.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSacuvaj.Location = new System.Drawing.Point(299, 463);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(400, 42);
            this.btnSacuvaj.TabIndex = 5;
            this.btnSacuvaj.Text = "Sačuvaj ugovor";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(42, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Obuka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(42, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Naziv ugovora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(42, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Instuktor:";
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.BackColor = System.Drawing.Color.DimGray;
            this.btnKreiraj.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreiraj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKreiraj.Location = new System.Drawing.Point(311, 12);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(174, 27);
            this.btnKreiraj.TabIndex = 7;
            this.btnKreiraj.Text = "Kreiraj ugovor";
            this.btnKreiraj.UseVisualStyleBackColor = false;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(152, 12);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 6;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(19, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Šifra ugovora:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmUnosUgovora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1064, 581);
            this.Controls.Add(this.gbUcenik);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUnosUgovora";
            this.Text = "Unos ugovora";
            this.Load += new System.EventHandler(this.UnosUgovora_Load);
            this.gbUcenik.ResumeLayout(false);
            this.gbUcenik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUcenik;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvUcenici;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ComboBox cmbObuka;
        private System.Windows.Forms.ComboBox cmbInstruktor;
    }
}