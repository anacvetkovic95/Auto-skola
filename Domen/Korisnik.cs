using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Korisnik:OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return ime + " " + prezime;
        }

        int korisnikID;
        String ime;
        String prezime;
        String korisnickoIme;
        String lozinka;


        public int KorisnikID { get => korisnikID; set => korisnikID = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }

        #region ODO
        [Browsable(false)]
        public string Tabela
        {
            get
            {
                return "Korisnik";
            }
        }
        [Browsable(false)]
        public string ID
        {
            get
            {
                return "KorisnikID";
            }
        }
        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return " KorisnikID=" + KorisnikID;
            }
        }

        public string USLOVI;

        [Browsable(false)]
        public string UslovOpsti
        {
            get
            {
                if (USLOVI == null) return " KorisnickoIme='" + korisnickoIme + "'";
                else return USLOVI;
            }
        }
        [Browsable(false)]
        public string Insert
        {
            get
            {
                return "(KorisnikID) values (" + KorisnikID + ")";
            }
        }
        [Browsable(false)]
        public string Update
        {
            get
            {
                return " Ime='" + Ime + "', Prezime='" + Prezime + "', KorisnickoIme='" + KorisnickoIme + "', Lozinka='" + Lozinka + "'";
            }
        }

        

        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            Korisnik k = new Korisnik();
            k.KorisnikID = Convert.ToInt32(red["KorisnikID"]);
            k.Ime = Convert.ToString(red["Ime"]);
            k.Prezime = Convert.ToString(red["Prezime"]);
            k.KorisnickoIme = Convert.ToString(red["KorisnickoIme"]);
            k.Lozinka = Convert.ToString(red["Lozinka"]);

            return k;
        }

        
        #endregion
    }
}
