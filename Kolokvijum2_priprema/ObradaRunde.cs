using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolokvijum2_priprema
{
    public class ObradaRunde
    {
        private List<Igrac> listaIgraca;
        private Igra igra;
        private Server server;
        //private OdgovorServera odgovorNaPitanje = new OdgovorServera();

        public ObradaRunde(List<Igrac> listaIgraca, Igra igra, Server server)
        {
            this.listaIgraca = listaIgraca;
            this.igra = igra;
            this.server = server;
        }

        internal void ZapocniIgru()
        {
            igra.ListaPitanja= Kontroller.Instance.VratiSvaPitanja(igra);
            List<Thread> threads = new List<Thread>();
            foreach (Igrac i in listaIgraca) {
                Thread thread = new Thread(()=> { IgraZaJednogIgraca(i); }); // kao ni ovaj
                threads.Add(thread);
                thread.Start();
            }
            threads.ForEach(t => t.Join()); // ovaj deo mi nije jasan
            ProglasiPobednika(listaIgraca, igra);
        }

        private void IgraZaJednogIgraca(Igrac i)
        {
            try
            {
                NetworkStream stream = new NetworkStream(i.serverskiSocketIgraca);
                BinaryFormatter formatter = new BinaryFormatter();
                foreach (Pitanje p in igra.ListaPitanja) {
                    OdgovorServera odgovor = new OdgovorServera { TeksPitanja = p.PitanjeTekst };
                    formatter.Serialize(stream, odgovor);
                    ZahtevOdKlijenta poruka = (ZahtevOdKlijenta)formatter.Deserialize(stream);
                    OdgovorServera odg = new OdgovorServera();
                    bool tacanOdogovor = (poruka.Odgovor == p.TacanOdgovor);
                    if (tacanOdogovor && !p.Odgovoreno)
                    {
                        i.BrojPoena += p.BrojPoena;
                        odg.Poeni = i.BrojPoena;
                        i.BrojTacnihOdgovora++;
                        p.Odgovoreno = true;
                        p.Odgvorio = i.KorisnickoIme;
                        odg.Poruka = $"Tacan odgovor ({p.BrojPoena})";
                    }
                    else if (tacanOdogovor && p.Odgovoreno)
                    {
                        odg.Poruka = $"Tacan odgovor, ali je prvo odgovorio {p.Odgvorio} ({0})";
                        odg.Poeni = i.BrojPoena;
                    }
                    else {
                        i.BrojPoena -= p.BrojPoena * 0.1;
                        odg.Poeni = i.BrojPoena;
                        i.BrojNetacnihOdgovora++;
                        odg.Poruka = $"Netacan odgovor ({p.BrojPoena*-0.1})";
                    }
                    server.IzmenjenRezultat();
                    formatter.Serialize(stream, odg);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProglasiPobednika(List<Igrac> listaIgraca,Igra igra)
        {
            double max = 0;
            max = listaIgraca.Max(m => m.BrojPoena);
            Igrac pobednik = new Igrac();
            foreach (Igrac igrac in listaIgraca) {
                if (igrac.BrojPoena == max) {
                    pobednik = igrac;
                    break;
                }
            }
            igra.DatumVremeKraja = DateTime.Now;
            OdgovorServera odgovor = new OdgovorServera();
            odgovor.Pobednik = $"Pobednik je {pobednik.KorisnickoIme} sa {pobednik.BrojPoena} poena";
            odgovor.Signal = Signal.ImamoPobednika;
            foreach (Igrac klijent in listaIgraca) {
                NetworkStream stream = new NetworkStream(klijent.serverskiSocketIgraca);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, odgovor);
                
            }
        }

        //private void ProveriTacnostPoruke(ZahtevOdKlijenta poruka, Igrac i, Pitanje p)
        //{
        //    if (poruka == null )
        //    {
        //        i.BrojPoena += 0;
        //        odgovorNaPitanje.Poeni = i.BrojPoena;
        //        odgovorNaPitanje.Poruka = "Nista nista osvojili u ovoj rundi";
        //    }
        //    else if (poruka.Odgovor == p.TacanOdgovor && !p.Odgovoreno)
        //    {
        //        i.BrojPoena += p.BrojPoena;
        //        i.BrojTacnihOdgovora++;
        //        p.Odgvorio = i.KorisnickoIme;
        //        odgovorNaPitanje.Poeni = i.BrojPoena;
        //        odgovorNaPitanje.Poruka = "Tacan odgovor";
        //    }
        //    else if (poruka.Odgovor == p.TacanOdgovor && p.Odgovoreno)
        //    {
        //        i.BrojPoena += 0;
        //        //i.BrojTacnihOdgovora++;
        //        odgovorNaPitanje.Poeni = i.BrojPoena;
        //        odgovorNaPitanje.Poruka = $"Tacan odgovor, al na njega je prvo odgovorio {p.Odgvorio}";
        //    }

        //    else {
        //        i.BrojPoena -= 0.1 * p.BrojPoena;
        //        i.BrojNetacnihOdgovora++;
        //        odgovorNaPitanje.Poeni = i.BrojPoena;
        //        odgovorNaPitanje.Poruka = "Netacan odgovor";
        //    }
        //}
    }
}
