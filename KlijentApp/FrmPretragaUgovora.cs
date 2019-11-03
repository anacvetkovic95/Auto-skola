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
    public partial class FrmPretragaUgovora : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public FrmPretragaUgovora()
        {
            InitializeComponent();
            dgvUgovori.Refresh();
            
        }

        private void PretragaUgovora_Load(object sender, EventArgs e)
        {
            kki.pronadjiUgovor(txtFilter, dgvUgovori);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            kki.pronadjiUgovor(txtFilter, dgvUgovori);
        }

        private void dgvUgovori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUgovori_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (kki.ucitajUgovor(dgvUgovori)) new FmrDetaljiUgovora().ShowDialog();
        }
        

       
    }
}
