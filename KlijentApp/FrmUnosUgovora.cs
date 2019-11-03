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
    public partial class FrmUnosUgovora : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public FrmUnosUgovora()
        {
            InitializeComponent();
        }

        private void UnosUgovora_Load(object sender, EventArgs e)
        {
            kki.vratiSveInstruktore(cmbInstruktor);
            kki.vratiSveObuke(cmbObuka);
            kki.vratiSveUcenike(dgvUcenici);

        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            kki.kreirajUgovor(txtID, btnKreiraj, gbUcenik);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
           kki.zapamtiUgovor(txtNaziv, cmbInstruktor, cmbObuka, dgvUcenici);
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gbUcenik_Enter(object sender, EventArgs e)
        {

        }
    }
}
