using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.UcenikSO
{
    public class UcitajUcenika : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            return Sesija.Broker.dajSesiju().vratiJedanZaID(odo) as Ucenik;
        }
    }
}
