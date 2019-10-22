using RegistarAutomobila.Forme;
using RegistarAutomobila.Modeli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistarAutomobila
{
    public partial class FrmGlavniIzbornik : Form
    {
        public FrmGlavniIzbornik()
        {
            InitializeComponent();
            lblLogiraniKorisnik.Text = LoginPodaci.Korime;

            if (LoginPodaci.Uloga != 1) //Ako korisnik nije administrator
            {
                btnKorisnici.Visible = false;
                btnUloge.Visible = false;
            }
        }

        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {            
            this.Hide();
            FrmPrijava formaPrijava = new FrmPrijava();
            formaPrijava.ShowDialog();
            this.Close();
        }

        private void btnModeliAutomobila_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmModeliAutomobila formaModeli = new FrmModeliAutomobila();
            formaModeli.ShowDialog();
            this.Close();
        }

        private void btnMarkeAutomobila_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMarkeAutomobila formaMarke = new FrmMarkeAutomobila();
            formaMarke.ShowDialog();
            this.Close();
        }

        private void btnKorisnici_Click(object sender, EventArgs e)
        {            
            this.Hide();
            FrmUpravljanjeKorisnika formaKorisnici = new FrmUpravljanjeKorisnika();
            formaKorisnici.ShowDialog();
            this.Close();
        }

        private void btnUloge_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUloge formaUloge = new FrmUloge();
            formaUloge.ShowDialog();
            this.Close();
        }
    }
}
