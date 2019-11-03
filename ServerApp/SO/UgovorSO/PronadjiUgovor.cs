using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.UgovorSO
{
    public class PronadjiUgovor : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            List<Ugovor> lista= Sesija.Broker.dajSesiju().vratiSveZaUslovOpsti(odo).OfType<Ugovor>().ToList<Ugovor>();

            foreach (Ugovor u in lista)
            {
                u.Instruktor = Sesija.Broker.dajSesiju().vratiJedanZaID(u.Instruktor) as Instruktor;
                u.Korisnik = Sesija.Broker.dajSesiju().vratiJedanZaID(u.Korisnik) as Korisnik;

            }
            return lista;
        }
    }
}
