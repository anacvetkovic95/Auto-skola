using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.UgovorSO
{
    public class UcitajUgovor : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            //Ugovor ug = odo as Ugovor;

            //ug.Instruktor = Sesija.Broker.dajSesiju().vratiJedanZaID(ug.Instruktor) as Instruktor;
            //ug.Korisnik = Sesija.Broker.dajSesiju().vratiJedanZaID(ug.Korisnik) as Korisnik;

            //return ug;
            return Sesija.Broker.dajSesiju().vratiJedanZaID(odo) as Ugovor;
            //Raspored r = odo as Raspored;

            //r.Projekcija = Sesija.Broker.dajSesiju().vratiJedanZaID(r.Projekcija) as Projekcija;
            //r.Projekcija.Film = Sesija.Broker.dajSesiju().vratiJedanZaID(r.Projekcija.Film) as Film;
            //r.AkreditovaniNovinar = Sesija.Broker.dajSesiju().vratiJedanZaID(r.AkreditovaniNovinar) as AkreditovaniNovinar;
            //r.AkreditovaniNovinar.MedijskaKuca = Sesija.Broker.dajSesiju().vratiJedanZaID(r.AkreditovaniNovinar.MedijskaKuca) as MedijskaKuca;
            //r.AngazovaniStudent = Sesija.Broker.dajSesiju().vratiJedanZaID(r.AngazovaniStudent) as AngazovaniStudent;

            //return r;
        }
    }
}
