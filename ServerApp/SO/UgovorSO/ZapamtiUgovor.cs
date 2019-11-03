using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.UgovorSO
{
    public class ZapamtiUgovor : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Ugovor u = odo as Ugovor;

            Sesija.Broker.dajSesiju().updateJedan(u);

            Sesija.Broker.dajSesiju().deleteVise(new SpisakUcenika { Ugovor = u, USLOVI = $"SifraUgovora = {u.SifraUgovora}" });
            foreach (SpisakUcenika su in u.Ucenici)
            {

                Sesija.Broker.dajSesiju().insert(su);

            }

            return true;
        }
    }
}
