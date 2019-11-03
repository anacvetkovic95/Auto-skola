namespace KlijentApp
{
    partial class FrmPocetnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPocetnaForma));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ucenikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ugovorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeUgovoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Maroon;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ucenikToolStripMenuItem,
            this.ugovorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ucenikToolStripMenuItem
            // 
            this.ucenikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.pretragaToolStripMenuItem});
            this.ucenikToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucenikToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucenikToolStripMenuItem.Name = "ucenikToolStripMenuItem";
            this.ucenikToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.ucenikToolStripMenuItem.Text = "Učenik";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.unosToolStripMenuItem.Text = "Unos";
            this.unosToolStripMenuItem.Click += new System.EventHandler(this.unosToolStripMenuItem_Click);
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // ugovorToolStripMenuItem
            // 
            this.ugovorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreiranjeUgovoraToolStripMenuItem,
            this.pregledToolStripMenuItem});
            this.ugovorToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ugovorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ugovorToolStripMenuItem.Name = "ugovorToolStripMenuItem";
            this.ugovorToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.ugovorToolStripMenuItem.Text = "Ugovor";
            // 
            // kreiranjeUgovoraToolStripMenuItem
            // 
            this.kreiranjeUgovoraToolStripMenuItem.Name = "kreiranjeUgovoraToolStripMenuItem";
            this.kreiranjeUgovoraToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.kreiranjeUgovoraToolStripMenuItem.Text = "Kreiranje";
            this.kreiranjeUgovoraToolStripMenuItem.Click += new System.EventHandler(this.kreiranjeUgovoraToolStripMenuItem_Click);
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pregledToolStripMenuItem.Text = "Pregled";
            this.pregledToolStripMenuItem.Click += new System.EventHandler(this.pregledToolStripMenuItem_Click);
            // 
            // FrmPocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPocetnaForma";
            this.Text = "Početna forma";
            this.Load += new System.EventHandler(this.PocetnaForma_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ucenikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ugovorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeUgovoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
    }
}