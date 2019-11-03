using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;

namespace Domen
{
    
    [Serializable]
    public class Ugovor:OpstiDomenskiObjekat
    {
        public Ugovor()
        {
            ucenici = new List<SpisakUcenika>();
        }
        public override string ToString()
        {
            return Naziv;
        }

        int sifraUgovora;
        String naziv;
        Instruktor instruktor;
        Obuka obuka;
        
        Korisnik korisnik;
        List<SpisakUcenika> ucenici;

        [Browsable(false)]
        public int SifraUgovora { get => sifraUgovora; set => sifraUgovora = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public Instruktor Instruktor { get => instruktor; set => instruktor = value; }
        public Obuka Obuka { get => obuka; set => obuka = value; }
        public Korisnik Korisnik { get => korisnik; set => korisnik = value; }
        public List<SpisakUcenika> Ucenici { get => ucenici; set => ucenici = value; }



        #region ODO
        [Browsable(false)]
        public string Tabela
        {
            get
            {
                return "Ugovor";
            }
        }
        [Browsable(false)]
        public string ID
        {
            get
            {
                return "SifraUgovora";
            }
        }
        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return " SifraUgovora=" + SifraUgovora;
            }
        }

        public string USLOVI;

        [Browsable(false)]
        public string UslovOpsti
        {
            get
            {
                return USLOVI;
            }
        }
        [Browsable(false)]
        public string Insert
        {
            get
            {
                return "(SifraUgovora) values (" + SifraUgovora + ")";
            }
        }
        [Browsable(false)]
        public string Update
        {
            get
            {
                return " SifraUgovora=" + SifraUgovora + ", Naziv='" + Naziv + "', InstruktorID=" + instruktor.InstruktorID + ", ObukaID=" + obuka.SifraObuke + ", KorisnikID=" + korisnik.KorisnikID+"";
            }
        }

        

        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            Ugovor u = new Ugovor();
            u.SifraUgovora = Convert.ToInt32(red["SifraUgovora"]);
            u.Naziv = Convert.ToString(red["Naziv"]);
            u.Instruktor = new Instruktor();
            u.Instruktor.InstruktorID = Convert.ToInt32(red["InstruktorID"]);
            u.Obuka = new Obuka();
            u.Obuka.SifraObuke = Convert.ToInt32(red["ObukaID"]);
            u.Korisnik = new Korisnik();
            u.Korisnik.KorisnikID = Convert.ToInt32(red["KorisnikID"]);

            return u;
        }


        #endregion
    }
}
