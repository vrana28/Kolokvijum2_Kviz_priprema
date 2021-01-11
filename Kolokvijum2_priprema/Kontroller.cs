using BrokerBaze;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokvijum2_priprema
{
    public class Kontroller
    {
        private static Kontroller instance;
        private Broker broker = new Broker();
        public Kontroller()
        {

        }

        public static Kontroller Instance {
            get {
                if (instance == null) instance = new Kontroller();
                return instance;
            }
        }

        internal List<Igra> VratiSveIgre()
        {
            try
            {
                
                broker.OpenConnection();
                return broker.VratiSveIgre();
               
            }
            
            finally
            {
                broker.Closeconnection();
            }
        }

        internal List<Pitanje> VratiSvaPitanja(Igra igra)
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiSvaPitanja(igra);
            }
            finally
            {
                broker.Closeconnection();    
            }
        }

        internal void PromenaVremenaPocetkIgre(Igra i)
        {
            i.DatumPocetka = DateTime.Now;
        }
    }
}
