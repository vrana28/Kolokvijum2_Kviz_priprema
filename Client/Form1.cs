using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel2.Enabled = false;

        }

        public TextBox TxtKorisnickoIme { get => txtKorisnickoIme; }

        public Panel panelBrojJedan { get => panel1; }
        public Panel panelBrojDva { get => panel2; }

        private void btnPrijavi_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtKorisnickoIme.Text)) {
                MessageBox.Show("Niste uneli korisnicko ime.");
                return;
            }
            try
            {
                Communication.Instance.Connect(this);
                ProcitajPitanja();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void ProcitajPitanja() {
            OdgovorServera odgovor = Communication.Instance.VratiPitanje();
            if (odgovor.Pobednik == null)
            {
                txtPitanje.Text = odgovor.TeksPitanja;
            }
            else {
                MessageBox.Show(odgovor.Pobednik);
            }
        }

        private void btnPosaljiOdgovor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOdgovor.Text)) {
                MessageBox.Show("Niste uneli nista ");
                return;
            }

            try
            {
                Communication.Instance.SendOdgovor(txtOdgovor.Text);
                OdgovorServera odgovor = (OdgovorServera)Communication.Instance.RezultatPoslatogOdgovora();
                txtPorukaServera.Text = odgovor.Poruka;
                txtUkupnoPoena.Text = odgovor.Poeni.ToString();
                ProcitajPitanja();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
