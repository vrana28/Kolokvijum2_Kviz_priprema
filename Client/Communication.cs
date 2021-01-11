using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public class Communication
    {
        private static Communication instance;
        Socket client;

        private NetworkStream stream;
        private BinaryFormatter formatter;

        public Communication()
        {
            
        }

        public static Communication Instance {
            get {
                if (instance == null) instance = new Communication();
                return instance;
            }
        }

        public void Connect(Form1 form1) {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.Connect("127.0.0.1", 9090);
            //MessageBox.Show("Povezan");
            stream = new NetworkStream(client);
            formatter = new BinaryFormatter();
            ZahtevOdKlijenta zahtev = new ZahtevOdKlijenta { KorisnickoIme = form1.TxtKorisnickoIme.Text };
            formatter.Serialize(stream, zahtev);
            OdgovorServera odgovor = (OdgovorServera)formatter.Deserialize(stream);
            if (odgovor.Signal == Signal.ImeZauzeto)
            {
                client.Close();
                MessageBox.Show("Navedeno ime postoji. Prekinuta veza sa serverom");
            }
            else {
                MessageBox.Show("Uspesno uspostavljena veza sa serverom");
                OdgovorServera odgovorZaPocetakIgre = (OdgovorServera) formatter.Deserialize(stream);
                if (odgovorZaPocetakIgre.Signal == Signal.SpremnoZaPocetak) {
                    form1.panelBrojDva.Enabled = true;
                }
            }

        }

        internal OdgovorServera RezultatPoslatogOdgovora()
        {
            return (OdgovorServera)formatter.Deserialize(stream);
        }

        internal OdgovorServera VratiPitanje()
        {
            return (OdgovorServera)formatter.Deserialize(stream);
        }

        internal void SendOdgovor(string text)
        {
            ZahtevOdKlijenta zahtev = new ZahtevOdKlijenta { Odgovor = text };
            formatter.Serialize(stream, zahtev);
        }
    }
}
