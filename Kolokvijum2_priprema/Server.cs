using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolokvijum2_priprema
{
    public class Server
    {
        Socket listener;
        public event Action Promena;
        private NetworkStream stream;
        private BinaryFormatter formatter;
        public Server()
        {
            listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listener.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9090));
            listener.Listen(2);
        }

        public void Start(Igra i, int brojIgraca, Form frmServer) {
            List<Igrac> igraci = new List<Igrac>();
            while(brojIgraca > 0) {
               
                Socket socket = listener.Accept();
                Igrac noviIgrac = new Igrac { serverskiSocketIgraca = socket };
                if (PrijavaIgraca(noviIgrac,igraci)) {
                    brojIgraca--;
                 
                }
            }
           // OdgovorServera odgovor = new OdgovorServera { Signal. };
           foreach(Igrac player in Sesija.Instance.listaPlayera) {
                OdgovorServera odgovor = new OdgovorServera { Signal = Signal.SpremnoZaPocetak };
                stream = new NetworkStream(player.serverskiSocketIgraca);
                formatter.Serialize(stream, odgovor);
            }
            Kontroller.Instance.PromenaVremenaPocetkIgre(i);
            MessageBox.Show("Igra moze da pocne.");
            ObradaRunde runda = new ObradaRunde(igraci, i, this);
            runda.ZapocniIgru();
        }

        internal void Stop()
        {
            listener.Close();
            foreach (Igrac i in Sesija.Instance.listaPlayera) {
                i.serverskiSocketIgraca.Close();
            }
            Environment.Exit(0);
        }

        internal void Kick(Igrac i)
        {
            foreach (Igrac player in Sesija.Instance.listaPlayera) {
                if (player.serverskiSocketIgraca == i.serverskiSocketIgraca) {
                    player.serverskiSocketIgraca.Close();
                    Sesija.Instance.listaPlayera.Remove(player);
                    IzmenjenRezultat();
                }
            }
        }

        // zahtev za prijavu

        private bool PrijavaIgraca(Igrac noviIgrac, List<Igrac> igraci)
        {
             stream = new NetworkStream(noviIgrac.serverskiSocketIgraca);
             formatter = new BinaryFormatter();
            ZahtevOdKlijenta zahtev = (ZahtevOdKlijenta)formatter.Deserialize(stream);
            // MessageBox.Show($"Poslato korisnicko ime {zahtev.KorisnickoIme}");
            noviIgrac.KorisnickoIme = zahtev.KorisnickoIme;
            OdgovorServera odgovor = new OdgovorServera();
            if (!igraci.Any(i => i.KorisnickoIme == noviIgrac.KorisnickoIme))
            {
                odgovor.Signal = Signal.Ok;
                igraci.Add(noviIgrac);
                Sesija.Instance.listaPlayera.Add(noviIgrac);
                IzmenjenRezultat();
                formatter.Serialize(stream, odgovor);
                return true;
            }
            else {
                odgovor.Signal = Signal.ImeZauzeto;
                formatter.Serialize(stream, odgovor);
                return false;
            }

        }

        public void IzmenjenRezultat() {
            Promena();
        }

    }
}
