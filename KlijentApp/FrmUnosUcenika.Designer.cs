namespace KlijentApp
{
    partial class FrmUnosUcenika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnosUcenika));
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.gbUcenik = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.gbUcenik.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(89, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(142, 47);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 2;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.BackColor = System.Drawing.Color.DimGray;
            this.btnKreiraj.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreiraj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKreiraj.Location = new System.Drawing.Point(301, 42);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(174, 27);
            this.btnKreiraj.TabIndex = 3;
            this.btnKreiraj.Text = "Kreiraj učenika";
            this.btnKreiraj.UseVisualStyleBackColor = false;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // gbUcenik
            // 
            this.gbUcenik.Controls.Add(this.button1);
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
            this.gbUcenik.Enabled = false;
            this.gbUcenik.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUcenik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbUcenik.Location = new System.Drawing.Point(30, 109);
            this.gbUcenik.Name = "gbUcenik";
            this.gbUcenik.Size = new System.Drawing.Size(509, 313);
            this.gbUcenik.TabIndex = 4;
            this.gbUcenik.TabStop = false;
            this.gbUcenik.Text = "Sačuvaj učenika";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(45, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sačuvaj učenika";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(204, 82);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(241, 26);
            this.txtPrezime.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(204, 198);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 26);
            this.txtEmail.TabIndex = 13;
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(204, 158);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(241, 26);
            this.txtKontakt.TabIndex = 12;
            // 
            // txtDatumRodjenja
            // 
            this.txtDatumRodjenja.Location = new System.Drawing.Point(204, 121);
            this.txtDatumRodjenja.Name = "txtDatumRodjenja";
            this.txtDatumRodjenja.Size = new System.Drawing.Size(241, 26);
            this.txtDatumRodjenja.TabIndex = 11;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(204, 40);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(241, 26);
            this.txtIme.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(42, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(42, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kontakt:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(42, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Datum rođenja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(42, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(42, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prezime:";
            // 
            // FrmUnosUcenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(573, 472);
            this.Controls.Add(this.gbUcenik);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUnosUcenika";
            this.Text = "Unos učenika";
            this.Load += new System.EventHandler(this.UnosUcenika_Load);
            this.gbUcenik.ResumeLayout(false);
            this.gbUcenik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.GroupBox gbUcenik;
        private System.Windows.Forms.Button button1;
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