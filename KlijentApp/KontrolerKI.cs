using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;


namespace KlijentApp
{
    public class KontrolerKI
    {
        static Komunikacija komunikacija;
        public static Korisnik korisnik;
        static Ucenik ucenik;
        static Ugovor ugovor;
        static List<Ucenik> listaUcenika;
        static List<Ugovor> listaUgovora;

        public KontrolerKI()
        {
        }

        public static string poveziSeNaServer()
        {
            komunikacija = new Komunikacija();
            if( komunikacija.poveziSeNaServer())
            {
                return "Klijent je povezan na server!";
            }
            else return "Klijent nije povezan na server!";
        }

        internal void popuniPolja(TextBox txtIme, TextBox txtPrezime, TextBox txtDatumRodjenja, TextBox txtKontakt, TextBox txtEmail)
        {
            txtIme.Text = ucenik.Ime;
            txtPrezime.Text = ucenik.Prezime;
            txtDatumRodjenja.Text = Convert.ToString(ucenik.DatumRodjenja);
            txtKontakt.Text = ucenik.Kontakt;
            txtEmail.Text = ucenik.Email;
            
        }

        internal bool prijaviKorisnika(TextBox txtKorisnickoIme, TextBox txtLozinka)
        {
            korisnik = new Korisnik();
            korisnik.KorisnickoIme=txtKorisnickoIme.Text;
            korisnik.Lozinka = txtLozinka.Text;

            korisnik = komunikacija.prijaviKorisnika(korisnik) as Korisnik;

            if (korisnik == null)
            {
                MessageBox.Show("Sistem ne moze da pronadje korisnika!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je pronasao korisnika!");
                return true;
            }
        }

        internal void kreirajUcenika(TextBox txtID, Button btnKreiraj, GroupBox gbUcenik)
        {
            ucenik = komunikacija.kreirajUcenika() as Ucenik;

            if (ucenik == null)
            {
                MessageBox.Show("Sistem ne moze da kreira ucenika!");
                btnKreiraj.Enabled = true;
                gbUcenik.Enabled = false;
            }
            else
            {
                txtID.Text = ucenik.Id.ToString();
                btnKreiraj.Enabled = false;
                gbUcenik.Enabled = true;
            }
        }

        internal bool zapamtiUcenika(TextBox txtIme, TextBox txtPrezime, TextBox txtDatumRodjenja, TextBox txtKontakt, TextBox txtEmail)
        {
            ucenik.Ime = txtIme.Text;
            if (ucenik.Ime == "")
            {
                MessageBox.Show("Niste uneli ime!");
                txtIme.Focus();
                return false;
            }

            ucenik.Prezime = txtPrezime.Text;
            if (ucenik.Prezime == "")
            {
                MessageBox.Show("Niste uneli prezime!");
                txtPrezime.Focus();
                return false;
            }

            try
            {
                ucenik.DatumRodjenja = DateTime.ParseExact(txtDatumRodjenja.Text, "dd.MM.yyyy", null);
            }
            catch (Exception)
            {

                MessageBox.Show("Nije dobar datum!");
                return false;
            }

           
            ucenik.Kontakt = txtKontakt.Text;
            if (ucenik.Kontakt == "")
            {
                MessageBox.Show("Niste uneli kontakt!");
                txtKontakt.Focus();
                return false;
            }

            ucenik.Email = txtEmail.Text;
            if (ucenik.Email == "")
            {
                MessageBox.Show("Niste uneli email!");
                txtKontakt.Focus();
                return false;
            }


            Object rez = komunikacija.zapamtiUcenika(ucenik);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti ucenika!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio ucenika!");
                return true;
            }

        }

        internal void pronadjiUcenike(TextBox txtFilter, DataGridView dgvUcenici)
        {
            ucenik = new Ucenik();
            ucenik.USLOVI = " Ime like '" + txtFilter.Text + "%' or Prezime like '" + txtFilter.Text + "%'";

            List<Ucenik> lista = komunikacija.pronadjiUcenike(ucenik) as List<Ucenik>;

            dgvUcenici.DataSource = lista;
            if (lista == null)
            {
                MessageBox.Show("Sistem ne moze da pronadje ucenike!");
                return;
            }
            if (lista.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da pronadje uucenike za kriterijum!");
                return;
            }
            // MessageBox.Show("Sistem je pronasao ucenike!");

        }

        internal bool ucitajUcenika(DataGridView dgvUcenici)
        {
            try
            {
                ucenik = dgvUcenici.CurrentRow.DataBoundItem as Ucenik;
                ucenik = komunikacija.ucitajUcenika(ucenik) as Ucenik;
                if (ucenik == null)
                {
                    MessageBox.Show("Sistem ne moze da ucita ucenika!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je ucitao ucenika!");
                    return true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali ucenika!");
                return false;
            }
        }

        internal bool obrisiUcenika()
        {
            Object rez = komunikacija.obrisiUcenika(ucenik);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da obrise ucenika!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je obrisao ucenika!");
                return true;
            }
        }

        internal void vratiSveInstruktore(ComboBox cmbInstruktor)
        {
            cmbInstruktor.DataSource = komunikacija.vratiSveInstruktore();
        }

        internal void vratiSveObuke(ComboBox cmbObuka)
        {
            cmbObuka.DataSource = komunikacija.vratiSveObuke();
        }

        internal void kreirajUgovor(TextBox txtID, Button btnKreiraj, GroupBox gbUcenik)
        {
            ugovor = komunikacija.kreirajUgovor() as Ugovor;

            if (ugovor == null)
            {
                MessageBox.Show("Sistem ne može da kreira ugovor!");
                btnKreiraj.Enabled = true;
                gbUcenik.Enabled = false;
            }
            else
            {
                txtID.Text = ugovor.SifraUgovora.ToString();
                btnKreiraj.Enabled = false;
                gbUcenik.Enabled = true;
            }
        }

        internal void vratiSveUcenike(DataGridView dgvUcenici)
        {
            List<Ucenik> listaUcenika = komunikacija.vratiSveUcenike() as List<Ucenik>;
            dgvUcenici.DataSource = listaUcenika;
        }
        
        internal void zapamtiUgovor(TextBox naziv, ComboBox instruktori, ComboBox obuke, DataGridView ucenici)
        {
            
            ugovor.Naziv = naziv.Text;

            if(ugovor.Naziv == "")
            {
                MessageBox.Show("Niste uneli naziv ugovora!");
                naziv.Focus();
                return;
            }

            ugovor.Instruktor = instruktori.SelectedItem as Instruktor;

            if(ugovor.Instruktor == null)
            {
                MessageBox.Show("Niste izabrali instruktora!");
                return;
            }

            ugovor.Obuka = obuke.SelectedItem as Obuka;

            if (ugovor.Obuka == null)
            {
                MessageBox.Show("Niste izabrali obuku!");
                return;
            }

            
            ugovor.Korisnik = korisnik;
            ugovor.Ucenici = new List<SpisakUcenika>();
            List<Ucenik> listaUcenika = (List<Ucenik>) ucenici.DataSource;
            foreach (Ucenik u in listaUcenika)
            {
                
                if (u.Odabran == true)
                {
                    int redniBroj = ugovor.Ucenici.Count + 1;
                    SpisakUcenika su = new SpisakUcenika();
                    su.Ugovor.SifraUgovora = ugovor.SifraUgovora;
                    su.RBr = redniBroj;
                    su.Ucenik.Id = u.Id;
                    ugovor.Ucenici.Add(su);
                }
            }

            Object rezultat = komunikacija.zapamtiUgovor(ugovor);

            if(rezultat == null)
            {
                MessageBox.Show("Ugovor nije zapamćen!");
                return;
            }
            else
            {
                MessageBox.Show("Ugovor je zapamćen!");
            }
        }
        
        internal void pronadjiUgovor(TextBox txtFilter, DataGridView dgvUgovori)
        {
            ugovor = new Ugovor();
            ugovor.USLOVI = " Naziv like '" + txtFilter.Text + "%'";

            List<Ugovor> lista = komunikacija.pronadjiUgovor(ugovor) as List<Ugovor>;

            dgvUgovori.DataSource = lista;
            if (lista == null)
            {
                MessageBox.Show("Sistem ne moze da pronadje ugovore!");
                return;
            }
            if (lista.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da pronadje ugovore za kriterijum!");
                return;
            }
            // MessageBox.Show("Sistem je pronasao ucenike!");

        }

        internal bool ucitajUgovor(DataGridView dgvUgovori)
        {
            try
            {
                ugovor = dgvUgovori.CurrentRow.DataBoundItem as Ugovor;
                //ugovor = komunikacija.ucitajUgovor(ugovor) as Ugovor;
                if (ugovor == null)
                {
                    MessageBox.Show("Sistem ne moze da ucita ugovor!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je ucitao ugovor!");
                    return true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali ugovor!");
                return false;
            }
        }

        internal void popuniPoljaUgovora(TextBox txtNaziv, ComboBox cmbInstruktor,ComboBox cmbObuka, DataGridView dgvUcenici)
        {
            List<Ucenik> lista=komunikacija.vratiSveUcenike() as List<Ucenik>;
            txtNaziv.Text = ugovor.Naziv.ToString();
            cmbInstruktor.DataSource = komunikacija.vratiSveInstruktore();
            cmbInstruktor.Text = ugovor.Instruktor.ToString();
            cmbObuka.DataSource = komunikacija.vratiSveObuke();
            cmbObuka.Text = ugovor.Obuka.ToString();

            SpisakUcenika spisak = new SpisakUcenika();
            spisak.USLOVI = "SifraUgovora="+ugovor.SifraUgovora;

            ugovor.Ucenici = komunikacija.ucitajSpisakUcenika(spisak) as List<SpisakUcenika>;

            foreach(Ucenik u in lista)
            {
               foreach(SpisakUcenika su in ugovor.Ucenici)
                {
                    if (u.Id==su.Ucenik.Id)
                    {
                        u.Odabran = true;
                    }
                }
            }

            dgvUcenici.DataSource = lista;
        }

        internal bool obrisiUgovor()
        {
            Object rez = komunikacija.obrisiUgovor(ugovor);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da obrise ugovor!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je obrisao ugovor!");
                return true;
            }
        }

        public static void kraj()
        {
            try
            {
                komunikacija.kraj();
            }
            catch (Exception)
            {


            }
        }
    }
}
