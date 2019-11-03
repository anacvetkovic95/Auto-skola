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
    public partial class FrmLogin : Form
    {
        
        KontrolerKI kki = new KontrolerKI();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void PocetnaForma_Load(object sender, EventArgs e)
        {
            this.Text = KontrolerKI.poveziSeNaServer();
        }

        private void PocetnaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            KontrolerKI.kraj();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kki.prijaviKorisnika(txtKorisnickoIme,txtLozinka)) new FrmPocetnaForma().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtLozinka.UseSystemPasswordChar = !txtLozinka.UseSystemPasswordChar;
        }
    }
}
