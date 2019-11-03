namespace ServerApp
{
    partial class ServerForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForma));
            this.btnZaustavi = new System.Windows.Forms.Button();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZaustavi
            // 
            this.btnZaustavi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnZaustavi.Enabled = false;
            this.btnZaustavi.Image = ((System.Drawing.Image)(resources.GetObject("btnZaustavi.Image")));
            this.btnZaustavi.Location = new System.Drawing.Point(477, 26);
            this.btnZaustavi.Margin = new System.Windows.Forms.Padding(4);
            this.btnZaustavi.Name = "btnZaustavi";
            this.btnZaustavi.Size = new System.Drawing.Size(260, 204);
            this.btnZaustavi.TabIndex = 1;
            this.btnZaustavi.UseVisualStyleBackColor = false;
            this.btnZaustavi.Click += new System.EventHandler(this.btnZaustavi_Click);
            // 
            // btnPokreni
            // 
            this.btnPokreni.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPokreni.Image = ((System.Drawing.Image)(resources.GetObject("btnPokreni.Image")));
            this.btnPokreni.Location = new System.Drawing.Point(94, 26);
            this.btnPokreni.Margin = new System.Windows.Forms.Padding(4);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(244, 204);
            this.btnPokreni.TabIndex = 0;
            this.btnPokreni.UseVisualStyleBackColor = false;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // ServerForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(832, 265);
            this.Controls.Add(this.btnZaustavi);
            this.Controls.Add(this.btnPokreni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ServerForma";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.ServerForma_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnZaustavi;
        private System.Windows.Forms.Button btnPokreni;
    }
}

