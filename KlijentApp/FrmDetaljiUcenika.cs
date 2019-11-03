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
    public partial class FrmDetaljiUcenika : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public FrmDetaljiUcenika()
        {
            InitializeComponent();
        }

        private void gbDob_Enter(object sender, EventArgs e)
        {

        }

        private void DetaljiUcenika_Load(object sender, EventArgs e)
        {
            kki.popuniPolja(txtIme, txtPrezime, txtDatumRodjenja,txtKontakt,txtEmail);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (kki.zapamtiUcenika(txtIme, txtPrezime, txtDatumRodjenja,txtKontakt,txtEmail)) this.Close();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if(kki.obrisiUcenika()) this.Close();
        }
    }
}
