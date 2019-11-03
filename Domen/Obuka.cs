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
    public class Obuka : OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return sifraObuke.ToString();
        }
        int sifraObuke;
        DateTime datumOd;
        DateTime datumDo;

        public int SifraObuke { get => sifraObuke; set => sifraObuke = value; }
        public DateTime DatumOd { get => datumOd; set => datumOd = value; }
        public DateTime DatumDo { get => datumDo; set => datumDo = value; }

        #region ODO
        [Browsable(false)]
        public string Tabela
        {
            get
            {
                return "Obuka";
            }
        }
        [Browsable(false)]
        public string ID
        {
            get
            {
                return "SifraObuke";
            }
        }
        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return " SifraObuke=" + SifraObuke;
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
                return "(SifraObuke) values (" + SifraObuke + ")";
            }
        }
        [Browsable(false)]
        public string Update
        {
            get
            {
                return "DatumOd='" + DatumOd + "', DatumDo='" + DatumDo + "' ";
            }
        }

        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            Obuka o=new Obuka();
            o.SifraObuke = Convert.ToInt32(red["SifraObuke"]);
            o.DatumOd = Convert.ToDateTime(red["DatumOd"]);
            o.DatumDo = Convert.ToDateTime(red["DatumDo"]);

            return o;
        }
        #endregion
    }
}
