using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.UgovorSO
{
    class VratiSveUcenike : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Ucenik u = new Ucenik();
            u.USLOVI = " Ime is null";
            Sesija.Broker.dajSesiju().deleteVise(u);

            return Sesija.Broker.dajSesiju().vratiSve(odo).OfType<Ucenik>().ToList<Ucenik>();
        }
    }
}
