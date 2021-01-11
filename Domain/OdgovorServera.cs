using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class OdgovorServera
    {
        public string  Poruka { get; set; }
        public Signal Signal { get; set; }
        public double Poeni { get; set; }
        public string TeksPitanja { get; set; }
        public string Pobednik { get; set; }

    }

    public enum Signal { 
        Ok,
        ImeZauzeto,
        SpremnoZaPocetak,
        ImamoPobednika
    }

}
