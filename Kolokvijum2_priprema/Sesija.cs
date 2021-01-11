using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokvijum2_priprema
{
    public class Sesija
    {
        private static Sesija instance;

        public Sesija()
        {
            
        }

        public List<Igrac> listaPlayera { get; set; } = new List<Igrac>();

        public static Sesija Instance {

            get {
                if (instance == null) instance = new Sesija();
                return instance;
            }

        }

    }
}
