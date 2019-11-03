using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.UgovorSO
{
    class VratiSveObuke : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Obuka o = new Obuka();
            o.USLOVI = " DatumOD is null";
            Sesija.Broker.dajSesiju().deleteVise(o);

            return Sesija.Broker.dajSesiju().vratiSve(odo).OfType<Obuka>().ToList<Obuka>();
        }

        
    }
}
