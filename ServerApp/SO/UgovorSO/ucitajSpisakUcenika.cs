using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.UgovorSO
{
    public class UcitajSpisakUcenika : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            SpisakUcenika su = odo as SpisakUcenika;
            List<SpisakUcenika> lista = new List<SpisakUcenika>();
            lista = Sesija.Broker.dajSesiju().vratiSveZaUslovOpsti(odo).OfType<SpisakUcenika>().ToList<SpisakUcenika>();
            return lista;
        }
    }
}
