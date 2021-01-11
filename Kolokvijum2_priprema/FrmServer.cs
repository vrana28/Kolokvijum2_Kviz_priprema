using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolokvijum2_priprema
{
    public partial class FrmServer : Form
    {
        private Server s = new Server();
        public FrmServer()
        {
            InitializeComponent();
            cmbIgra.DataSource = Kontroller.Instance.VratiSveIgre();
            
        }

        public DateTime VremePocetka { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Igra i = (Igra)cmbIgra.SelectedItem;
            if (string.IsNullOrEmpty(txtBrojIgraca.Text)) {
                MessageBox.Show("Niste uneli sva polja");
                return;
            }
            //int brojIgraca = int.Parse(txtBrojIgraca.Text);
            if (!int.TryParse(txtBrojIgraca.Text, out int brojIgraca) || brojIgraca<2 || brojIgraca>4) {
                MessageBox.Show("Broj igraca nije dobar.");
                return;
            }
            lbl1.Text = "Server je pokrenut.";
            s.Promena += OsveziDgv;
            new Thread(() => { s.Start(i, brojIgraca,this); }).Start();
            dgvIgraci.DataSource = Sesija.Instance.listaPlayera;
        }

        private void OsveziDgv()
        {
            dgvIgraci.Invoke(new Action(() => dgvIgraci.DataSource = Sesija.Instance.listaPlayera.ToList()));
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            s.Stop();
        }

        private void btnKick_Click(object sender, EventArgs e)
        {
            if (dgvIgraci.RowCount > 0)
            {
                DataGridViewRow row = dgvIgraci.SelectedRows[0];
                Igrac i = (Igrac)row.DataBoundItem;
                s.Kick(i);
            }
            else {
                MessageBox.Show("Morate da izaberete playera.");
            }
        }
    }
}
