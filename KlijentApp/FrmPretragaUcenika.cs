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
    public partial class FrmPretragaUcenika : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public FrmPretragaUcenika()
        {
            InitializeComponent();
        }

        private void PretragaUcenika_Load(object sender, EventArgs e)
        {
            kki.pronadjiUcenike(txtFilter, dgvUcenici);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            kki.pronadjiUcenike(txtFilter, dgvUcenici);
        }

        private void dgvUcenici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvUcenici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (kki.ucitajUcenika(dgvUcenici)) new FrmDetaljiUcenika().ShowDialog();
            txtFilter_TextChanged(sender, e);
        }
    }
}
