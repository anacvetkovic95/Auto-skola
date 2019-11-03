using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Operacije { Kraj=1,
        PrijavaKorisnika=2,
        KreirajUcenika=3,
        ZapamtiUcenika=4,
        PronadjiUcenike=5,
        UcitajUcenika=6,
        ObrisiUcenika=7,
        VratiSveInsturktore=8,
        VratiSveObuke=9,
        KreirajUgovor=10,
        VratiSveUcenike=11,
        ZapamtiUgovor=12,
        PronadjiUgovor=13,
        UcitajUgovor=14,
        UcitajSpisakUcenika = 15,
        ObrisiUgovor=16
    }
    [Serializable]
    public class TransferKlasa
    {
        public Operacije Operacija;
        public Object TransferObjekat;
        public Object Rezultat;
    }
}
