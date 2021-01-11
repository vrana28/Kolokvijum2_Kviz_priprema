using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Igra
    {
        public int IgradId { get; set; }
        public string Naziv { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumVremeKraja { get; set; }
        public string Pobednik { get; set; }
        public List<Pitanje> ListaPitanja { get; set; }

        public override string ToString()
        {
            return $"{Naziv}";
        }
    }
}
