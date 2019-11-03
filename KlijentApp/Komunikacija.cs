using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domen;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace KlijentApp
{
    public class Komunikacija
    {
        TcpClient klijent;
        BinaryFormatter formater;
        NetworkStream tok;

        public bool poveziSeNaServer()
        {
            try
            {
                klijent = new TcpClient("localhost", 10000);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public void kraj()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.Kraj;
            formater.Serialize(tok, transfer);
        }

        public Object prijaviKorisnika(Korisnik k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PrijavaKorisnika;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object kreirajUcenika()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajUcenika;
            transfer.TransferObjekat = new Ucenik();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object zapamtiUcenika(Ucenik u)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiUcenika;
            transfer.TransferObjekat = u;

            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object pronadjiUcenike(Ucenik u)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PronadjiUcenike;
            transfer.TransferObjekat = u;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object ucitajUcenika(Ucenik u)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajUcenika;
            transfer.TransferObjekat = u;

            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object obrisiUcenika(Ucenik u)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiUcenika;
            transfer.TransferObjekat = u;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object vratiSveInstruktore()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSveInsturktore;
            transfer.TransferObjekat = new Instruktor();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object vratiSveObuke()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSveObuke;
            transfer.TransferObjekat = new Obuka();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object vratiSveUcenike()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSveUcenike;
            transfer.TransferObjekat = new Ucenik();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object kreirajUgovor()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajUgovor;
            transfer.TransferObjekat = new Ugovor();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object zapamtiUgovor(Ugovor u)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiUgovor;
            transfer.TransferObjekat = u;

            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }
        
        public Object pronadjiUgovor(Ugovor ug)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PronadjiUgovor;
            transfer.TransferObjekat = ug;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object ucitajUgovor(Ugovor ug)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajUgovor;
            transfer.TransferObjekat = ug;

            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object ucitajSpisakUcenika(SpisakUcenika su)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajSpisakUcenika;
            transfer.TransferObjekat = su;

            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object obrisiUgovor(Ugovor u)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiUgovor;
            transfer.TransferObjekat = u;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }
    }
}
