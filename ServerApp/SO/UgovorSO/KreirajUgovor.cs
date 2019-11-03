using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.UgovorSO
{
    public class KreirajUgovor : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Ugovor u = new Ugovor();
            u.SifraUgovora = Sesija.Broker.dajSesiju().vratiSifru(odo);
            Sesija.Broker.dajSesiju().insert(u);
            return u;
        }
    }
}
