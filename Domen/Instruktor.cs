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
    public class Instruktor : OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return ime + " " + prezime;
        }

        int instruktorID;
        String ime;
        String prezime;
        DateTime datumRodjenja;
        String kontakt;

        public int InstruktorID { get => instruktorID; set => instruktorID = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public string Kontakt { get => kontakt; set => kontakt = value; }

        #region ODO
        [Browsable(false)]
        public string Tabela
        {
            get
            {
                return "Instruktor";
            }
        }
        [Browsable(false)]
        public string ID
        {
            get
            {
                return "InstruktorID";
            }
        }
        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return " InstruktorID=" + InstruktorID;
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
                return "(InstruktorID) values (" + InstruktorID + ")";
            }
        }
        [Browsable(false)]
        public string Update
        {
            get
            {
                return " Ime='" + Ime + "', Prezime='" + Prezime + "', DatumRodjenja='" + DatumRodjenja + "', Kontakt='" + Kontakt + "'";
            }
        }

        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {

            Instruktor i = new Instruktor();
            i.InstruktorID = Convert.ToInt32(red["InstruktorID"]);
            i.Ime = Convert.ToString(red["Ime"]);
            i.Prezime = Convert.ToString(red["Prezime"]);
            i.datumRodjenja = Convert.ToDateTime(red["DatumRodjenja"]);
            i.Kontakt = Convert.ToString(red["Kontakt"]);

            return i;
        }

        
        #endregion
    }
}
