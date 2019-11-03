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
    public class Ucenik:OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return ime+" "+prezime;
        }

        int id;
        String ime;
        String prezime;
        DateTime datumRodjenja;
        String kontakt;
        String email;
        bool odabran;

        [Browsable(false)]
        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        [DisplayName("Datum rođenja")]
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public string Kontakt { get => kontakt; set => kontakt = value; }
        public string Email { get => email; set => email = value; }

        #region ODO
        [Browsable(false)]
        public string Tabela
        {
            get
            {
                return "Ucenik";
            }
        }
        [Browsable(false)]
        public string ID
        {
            get
            {
                return "ID";
            }
        }
        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return " ID=" + Id;
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
                return "(ID) values (" + Id + ")";
            }
        }
        [Browsable(false)]
        public string Update
        {
            get
            {
                return " Ime='" + Ime + "', Prezime='" + Prezime + "', DatumRodjenja='" + DatumRodjenja +"', Kontakt='" + Kontakt + "', Email='" + Email + "'";
            }
        }

        public bool Odabran { get => odabran; set => odabran = value; }

        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            Ucenik u = new Ucenik();
            u.Id = Convert.ToInt32(red["ID"]);
            u.Ime = red["Ime"].ToString();
            u.Prezime = red["Prezime"].ToString();
            u.DatumRodjenja = Convert.ToDateTime(red["DatumRodjenja"]);
            u.Kontakt = red["Kontakt"].ToString();
            u.Email = red["Email"].ToString();
            return u;
        }
        #endregion
    }
}
