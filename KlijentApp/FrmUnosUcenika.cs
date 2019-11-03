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
    public partial class FrmUnosUcenika : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public FrmUnosUcenika()
        {
            InitializeComponent();
        }

        private void UnosUcenika_Load(object sender, EventArgs e)
        {

        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            kki.kreirajUcenika(txtID, btnKreiraj, gbUcenik);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kki.zapamtiUcenika(txtIme, txtPrezime, txtDatumRodjenja,txtKontakt,txtEmail)) this.Close();
        }
    }
}
