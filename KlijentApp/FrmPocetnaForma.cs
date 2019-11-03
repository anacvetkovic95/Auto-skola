using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlijentApp
{
    public partial class FrmPocetnaForma : Form
    {
        public FrmPocetnaForma()
        {
            InitializeComponent();
        }

        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmUnosUcenika().ShowDialog();
        }

        private void PocetnaForma_Load(object sender, EventArgs e)
        {
            this.Text = KontrolerKI.korisnik.ToString();
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPretragaUcenika().ShowDialog();
        }

        private void kreiranjeUgovoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmUnosUgovora().ShowDialog();
        }

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPretragaUgovora().ShowDialog();
        }
    }
}
