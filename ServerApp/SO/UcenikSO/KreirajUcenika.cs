using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.UcenikSO
{
    public class KreirajUcenika : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Ucenik u = new Ucenik();
            u.Id = Sesija.Broker.dajSesiju().vratiSifru(odo);
            Sesija.Broker.dajSesiju().insert(u);

            return u;
        }
    }
}
