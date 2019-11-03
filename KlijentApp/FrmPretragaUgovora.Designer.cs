namespace KlijentApp
{
    partial class FrmPretragaUgovora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPretragaUgovora));
            this.dgvUgovori = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUgovori
            // 
            this.dgvUgovori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUgovori.Location = new System.Drawing.Point(12, 64);
            this.dgvUgovori.Name = "dgvUgovori";
            this.dgvUgovori.RowTemplate.Height = 24;
            this.dgvUgovori.Size = new System.Drawing.Size(776, 367);
            this.dgvUgovori.TabIndex = 5;
            this.dgvUgovori.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUgovori_CellContentClick);
            this.dgvUgovori.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUgovori_CellDoubleClick);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(131, 19);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(280, 22);
            this.txtFilter.TabIndex = 4;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(69, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter:";
            // 
            // FrmPretragaUgovora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(801, 496);
            this.Controls.Add(this.dgvUgovori);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPretragaUgovora";
            this.Text = "Pretraga ugovora";
            this.Load += new System.EventHandler(this.PretragaUgovora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUgovori;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
    }
}