namespace KlijentApp
{
    partial class FrmDetaljiUcenika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetaljiUcenika));
            this.gbUcenik = new System.Windows.Forms.GroupBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.txtDatumRodjenja = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.gbUcenik.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUcenik
            // 
            this.gbUcenik.Controls.Add(this.txtPrezime);
            this.gbUcenik.Controls.Add(this.txtEmail);
            this.gbUcenik.Controls.Add(this.txtKontakt);
            this.gbUcenik.Controls.Add(this.txtDatumRodjenja);
            this.gbUcenik.Controls.Add(this.txtIme);
            this.gbUcenik.Controls.Add(this.label4);
            this.gbUcenik.Controls.Add(this.label5);
            this.gbUcenik.Controls.Add(this.label6);
            this.gbUcenik.Controls.Add(this.label3);
            this.gbUcenik.Controls.Add(this.label1);
            this.gbUcenik.Controls.Add(this.btnObrisi);
            this.gbUcenik.Controls.Add(this.btnIzmeni);
            this.gbUcenik.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUcenik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbUcenik.Location = new System.Drawing.Point(13, 13);
            this.gbUcenik.Margin = new System.Windows.Forms.Padding(4);
            this.gbUcenik.Name = "gbUcenik";
            this.gbUcenik.Padding = new System.Windows.Forms.Padding(4);
            this.gbUcenik.Size = new System.Drawing.Size(528, 459);
            this.gbUcenik.TabIndex = 5;
            this.gbUcenik.TabStop = false;
            this.gbUcenik.Text = "Podaci o učeniku";
            this.gbUcenik.Enter += new System.EventHandler(this.gbDob_Enter);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(201, 98);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(277, 26);
            this.txtPrezime.TabIndex = 24;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(201, 214);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(277, 26);
            this.txtEmail.TabIndex = 23;
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(201, 174);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(277, 26);
            this.txtKontakt.TabIndex = 22;
            // 
            // txtDatumRodjenja
            // 
            this.txtDatumRodjenja.Location = new System.Drawing.Point(201, 137);
            this.txtDatumRodjenja.Name = "txtDatumRodjenja";
            this.txtDatumRodjenja.Size = new System.Drawing.Size(277, 26);
            this.txtDatumRodjenja.TabIndex = 21;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(201, 56);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(277, 26);
            this.txtIme.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kontakt:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Datum rođenja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Prezime:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.DimGray;
            this.btnObrisi.Location = new System.Drawing.Point(42, 362);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(436, 52);
            this.btnObrisi.TabIndex = 10;
            this.btnObrisi.Text = "Obriši učenika";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.DimGray;
            this.btnIzmeni.Location = new System.Drawing.Point(42, 291);
            this.btnIzmeni.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(436, 52);
            this.btnIzmeni.TabIndex = 4;
            this.btnIzmeni.Text = "Izmeni učenika";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // FrmDetaljiUcenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(555, 490);
            this.Controls.Add(this.gbUcenik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDetaljiUcenika";
            this.Text = "Detalji učenika";
            this.Load += new System.EventHandler(this.DetaljiUcenika_Load);
            this.gbUcenik.ResumeLayout(false);
            this.gbUcenik.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUcenik;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.TextBox txtDatumRodjenja;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}