namespace KlijentApp
{
    partial class FmrDetaljiUgovora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrDetaljiUgovora));
            this.gbUcenik = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.cmbObuka = new System.Windows.Forms.ComboBox();
            this.cmbInstruktor = new System.Windows.Forms.ComboBox();
            this.dgvUcenici = new System.Windows.Forms.DataGridView();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUcenik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenici)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUcenik
            // 
            this.gbUcenik.Controls.Add(this.btnObrisi);
            this.gbUcenik.Controls.Add(this.txtNaziv);
            this.gbUcenik.Controls.Add(this.cmbObuka);
            this.gbUcenik.Controls.Add(this.cmbInstruktor);
            this.gbUcenik.Controls.Add(this.dgvUcenici);
            this.gbUcenik.Controls.Add(this.btnIzmeni);
            this.gbUcenik.Controls.Add(this.label6);
            this.gbUcenik.Controls.Add(this.label3);
            this.gbUcenik.Controls.Add(this.label1);
            this.gbUcenik.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUcenik.ForeColor = System.Drawing.Color.Black;
            this.gbUcenik.Location = new System.Drawing.Point(18, 16);
            this.gbUcenik.Name = "gbUcenik";
            this.gbUcenik.Size = new System.Drawing.Size(1039, 524);
            this.gbUcenik.TabIndex = 9;
            this.gbUcenik.TabStop = false;
            this.gbUcenik.Text = "Podaci o ugovoru";
            this.gbUcenik.Enter += new System.EventHandler(this.gbUcenik_Enter);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.DimGray;
            this.btnObrisi.ForeColor = System.Drawing.Color.White;
            this.btnObrisi.Location = new System.Drawing.Point(758, 457);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(262, 52);
            this.btnObrisi.TabIndex = 17;
            this.btnObrisi.Text = "Obriši ugovor";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(166, 40);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(220, 28);
            this.txtNaziv.TabIndex = 16;
            // 
            // cmbObuka
            // 
            this.cmbObuka.FormattingEnabled = true;
            this.cmbObuka.Location = new System.Drawing.Point(166, 117);
            this.cmbObuka.Name = "cmbObuka";
            this.cmbObuka.Size = new System.Drawing.Size(554, 28);
            this.cmbObuka.TabIndex = 15;
            // 
            // cmbInstruktor
            // 
            this.cmbInstruktor.FormattingEnabled = true;
            this.cmbInstruktor.Location = new System.Drawing.Point(166, 78);
            this.cmbInstruktor.Name = "cmbInstruktor";
            this.cmbInstruktor.Size = new System.Drawing.Size(554, 28);
            this.cmbInstruktor.TabIndex = 14;
            // 
            // dgvUcenici
            // 
            this.dgvUcenici.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUcenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcenici.Location = new System.Drawing.Point(45, 173);
            this.dgvUcenici.Name = "dgvUcenici";
            this.dgvUcenici.RowTemplate.Height = 24;
            this.dgvUcenici.Size = new System.Drawing.Size(975, 264);
            this.dgvUcenici.TabIndex = 12;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.DimGray;
            this.btnIzmeni.ForeColor = System.Drawing.Color.White;
            this.btnIzmeni.Location = new System.Drawing.Point(45, 457);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(255, 52);
            this.btnIzmeni.TabIndex = 5;
            this.btnIzmeni.Text = "Izmeni ugovor";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(42, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Obuka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Naziv ugovora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Instuktor:";
            // 
            // FmrDetaljiUgovora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1080, 594);
            this.Controls.Add(this.gbUcenik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmrDetaljiUgovora";
            this.Text = "Detalji ugovora";
            this.Load += new System.EventHandler(this.FmrDetaljiUgovora_Load);
            this.gbUcenik.ResumeLayout(false);
            this.gbUcenik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUcenik;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ComboBox cmbObuka;
        private System.Windows.Forms.ComboBox cmbInstruktor;
        private System.Windows.Forms.DataGridView dgvUcenici;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisi;
    }
}