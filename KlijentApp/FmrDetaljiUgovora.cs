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
    public partial class FmrDetaljiUgovora : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public FmrDetaljiUgovora()
        {
            InitializeComponent();
        }

        private void FmrDetaljiUgovora_Load(object sender, EventArgs e)
        {
            kki.popuniPoljaUgovora(txtNaziv, cmbInstruktor, cmbObuka, dgvUcenici);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            kki.zapamtiUgovor(txtNaziv, cmbInstruktor, cmbObuka, dgvUcenici);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (kki.obrisiUgovor()) this.Close();
        }

        private void gbUcenik_Enter(object sender, EventArgs e)
        {

        }
    }
}
