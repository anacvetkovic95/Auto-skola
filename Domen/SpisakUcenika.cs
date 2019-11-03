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
    public class SpisakUcenika : OpstiDomenskiObjekat
    {

        public Ugovor Ugovor { get; set; } = new Ugovor();
        public int RBr { get; set; }
        public Ucenik Ucenik { get; set; } = new Ucenik();

        #region ODO
        [Browsable(false)]
        public string Tabela
        {
            get
            {
                return "SpisakUcenika";
            }
        }
        [Browsable(false)]
        public string ID
        {
            get
            {
                return null;
            }
        }
        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return " SifraUgovora=" + Ugovor.SifraUgovora + " and UcenikID=" + Ucenik.ID;
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
                return "values (" + Ugovor.SifraUgovora + "," + RBr + "," + Ucenik.Id + ")";
            }
        }
        [Browsable(false)]
        public string Update
        {
            get
            {
                return "RedniBr="+RBr+"";
            }
        }


        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            SpisakUcenika su = new SpisakUcenika();
            su.Ugovor = new Domen.Ugovor();
            su.Ugovor.SifraUgovora = Convert.ToInt32(red["SifraUgovora"]);
            su.RBr =Convert.ToInt32(red["RedniBr"]); 
            su.Ucenik = new Domen.Ucenik();
            su.Ucenik.Id = Convert.ToInt32(red["UcenikID"]);

            return su;
        }
        #endregion
    }
}
