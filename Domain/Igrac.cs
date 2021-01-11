using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domain
{
    public class Igrac
    {
        public string KorisnickoIme{  get; set; }
       [Browsable(false)]
        public Socket serverskiSocketIgraca{ get; set; }
        public double BrojPoena { get; set; }
        public int BrojTacnihOdgovora { get; set; }
        public int BrojNetacnihOdgovora { get; set; }
        public Form FrmIgrac{ get; set; }

    }
}
