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
using ServerApp.SO.Login;
using ServerApp.SO.UcenikSO;
using ServerApp.SO.UgovorSO;

namespace ServerApp
{
    class NitiKlijenta
    {
        private NetworkStream tok;
        BinaryFormatter formater;

        public NitiKlijenta(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            ThreadStart nitDelegat = obradiZahtev;
            new Thread(nitDelegat).Start();
        }

        void obradiZahtev()
        {
            try
            {
                int operacija = 0;
                while (operacija != (int)Operacije.Kraj)
                {
                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;

                    switch (transfer.Operacija)
                    {

                        case Operacije.PrijavaKorisnika:
                            PrijavaKorisnika pk = new SO.Login.PrijavaKorisnika();
                            transfer.Rezultat = pk.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.KreirajUcenika:
                            KreirajUcenika kd = new KreirajUcenika();
                            transfer.Rezultat = kd.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ZapamtiUcenika:
                            ZapamtiUcenika zu = new ZapamtiUcenika();
                            transfer.Rezultat = zu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PronadjiUcenike:
                            PronadjiUcenike pd = new PronadjiUcenike();
                            transfer.Rezultat = pd.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UcitajUcenika:
                            UcitajUcenika ud = new UcitajUcenika();
                            transfer.Rezultat = ud.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ObrisiUcenika:
                            ObrisiUcenika od = new ObrisiUcenika();
                            transfer.Rezultat = od.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.VratiSveInsturktore:
                            VratiSveInstruktore vsi = new VratiSveInstruktore();
                            transfer.Rezultat = vsi.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.VratiSveObuke:
                            VratiSveObuke vso = new VratiSveObuke();
                            transfer.Rezultat = vso.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.VratiSveUcenike:
                            VratiSveUcenike vsu = new VratiSveUcenike();
                            transfer.Rezultat = vsu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.KreirajUgovor:
                            KreirajUgovor ku = new KreirajUgovor();
                            transfer.Rezultat = ku.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ZapamtiUgovor:
                            ZapamtiUgovor zug = new ZapamtiUgovor();
                            transfer.Rezultat = zug.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PronadjiUgovor:
                            PronadjiUgovor pug = new PronadjiUgovor();
                            transfer.Rezultat = pug.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UcitajUgovor:
                            UcitajUgovor ucug = new UcitajUgovor();
                            transfer.Rezultat = ucug.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.UcitajSpisakUcenika:
                            UcitajSpisakUcenika usu = new UcitajSpisakUcenika();
                            transfer.Rezultat = usu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ObrisiUgovor:
                            ObrisiUgovor oug = new ObrisiUgovor();
                            transfer.Rezultat = oug.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.Kraj:
                            operacija = 1;
                            Server.listaTokovaKlijenata.Remove(tok);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {
                try
                {
                    Server.listaTokovaKlijenata.Remove(tok);
                }
                catch (Exception)
                {

                   
                }
               
            }
        }
    }
}
