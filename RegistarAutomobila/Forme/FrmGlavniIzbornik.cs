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
        /// <summary>
        /// Konstruktor forme.
        /// </summary>
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

        /// <summary>
        /// Zatvara trenutnu formu i vraća se na formu za prijavu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrijava formaPrijava = new FrmPrijava();
            formaPrijava.ShowDialog();           
            this.Close();
        }

        /// <summary>
        /// Otvara formu za Modele automobila.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModeliAutomobila_Click(object sender, EventArgs e)
        {            
            FrmModeliAutomobila formaModeli = new FrmModeliAutomobila();
            formaModeli.ShowDialog();            
        }

        /// <summary>
        /// Otvara formu za Marke automobila.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMarkeAutomobila_Click(object sender, EventArgs e)
        {            
            FrmMarkeAutomobila formaMarke = new FrmMarkeAutomobila();
            formaMarke.ShowDialog();
        }

        /// <summary>
        /// Otvara formu za upravljanje korisnicima.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKorisnici_Click(object sender, EventArgs e)
        {                       
            FrmUpravljanjeKorisnika formaKorisnici = new FrmUpravljanjeKorisnika();
            formaKorisnici.ShowDialog();
        }

        /// <summary>
        /// Otvara formu za upravljanje ulogama korisnika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUloge_Click(object sender, EventArgs e)
        {            
            FrmUloge formaUloge = new FrmUloge();
            formaUloge.ShowDialog();
        }
    }
}
