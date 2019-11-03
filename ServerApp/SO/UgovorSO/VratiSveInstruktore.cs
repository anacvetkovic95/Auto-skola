using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.UgovorSO
{
    class VratiSveInstruktore : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Instruktor i = new Instruktor();
            i.USLOVI = " Ime is null";
            Sesija.Broker.dajSesiju().deleteVise(i);

            return Sesija.Broker.dajSesiju().vratiSve(odo).OfType<Instruktor>().ToList<Instruktor>();
            
        }
    }
}
