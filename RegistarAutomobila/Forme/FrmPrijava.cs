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

namespace RegistarAutomobila.Forme
{
    public partial class FrmPrijava : Form
    {
        /// <summary>
        /// Konstruktor forme.
        /// </summary>
        public FrmPrijava()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Poziva metode za provjeru unesenih korisničkih podataka i dohvaća ulogu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            bool provjeraUnosa = ProvjeriPodatkeZaPrijavu(txtBoxKorime.Text, txtBoxLozinka.Text);
            int? uloga = DohvatiUlogu(txtBoxKorime.Text, txtBoxLozinka.Text);

            // Ako je korisnik administrator
            if (provjeraUnosa == true && uloga == 1)
            {
                MessageBox.Show("Dobrodošli administratore!");

                LoginPodaci.Id = DohvatiId(txtBoxKorime.Text, txtBoxLozinka.Text);
                LoginPodaci.Korime = DohvatiKorime(txtBoxKorime.Text, txtBoxLozinka.Text);
                LoginPodaci.Uloga = uloga;

                this.Hide();
                FrmGlavniIzbornik glavniIzbornik = new FrmGlavniIzbornik();
                glavniIzbornik.ShowDialog();                
                this.Close();
            }
            else if (provjeraUnosa == true && uloga == null)
            {
                MessageBox.Show("Vaš korisnički račun nema dodjeljenu ulogu!\r\nObratite se administratoru za pomoć!");
                OsvjeziPrikaz();
            }
            // Ako je korisnik bilo koja druga uloga
            else if (provjeraUnosa == true)
            {
                MessageBox.Show("Dobrodošli korisniče!");

                LoginPodaci.Id = DohvatiId(txtBoxKorime.Text, txtBoxLozinka.Text);
                LoginPodaci.Korime = txtBoxKorime.Text;
                LoginPodaci.Uloga = DohvatiUlogu(txtBoxKorime.Text, txtBoxLozinka.Text);

                this.Hide();
                FrmGlavniIzbornik glavniIzbornik = new FrmGlavniIzbornik();
                glavniIzbornik.ShowDialog();               
                this.Close();
            }
            else if (provjeraUnosa == false)
            {
                MessageBox.Show("Uneseni su krivi podaci. Pokušajte ponovno!");
                OsvjeziPrikaz();
            }
        }

        /// <summary>
        /// Provjerava ispravnost unesenih podataka kod prijave korisnika.
        /// </summary>
        /// <param name="_korime">Uneseno korisničko ime.</param>
        /// <param name="_lozinka">Unesena lozinka.</param>
        /// <returns>"True" ako je provjera uspješna, "False" ako nije.</returns>
        public bool ProvjeriPodatkeZaPrijavu(string _korime, string _lozinka)
        {
            bool provjera = false;

            DBContext baza = new DBContext();

            List<Korisnik> listaSvihKorisnika = new List<Korisnik>();
            listaSvihKorisnika = baza.Korisnik.ToList();

            foreach (Korisnik k in listaSvihKorisnika)
            {
                if (_korime == k.Korime && _lozinka == k.Lozinka)
                {
                    provjera = true;
                }
            }

            return provjera;
        }

        /// <summary>
        /// Dohvaća ulogu prijavljenog korisnika.
        /// </summary>
        /// <param name="_korime">Uneseno korisničko ime.</param>
        /// <param name="_lozinka">Unesena lozinka.</param>
        /// <returns>
        /// Šifru uloge korisnika(int?) (ako korisnik postoji).
        /// Broj 0(int?) ako korisnik ne postoji.</returns>
        public int? DohvatiUlogu(string _korime, string _lozinka)
        {
            DBContext baza = new DBContext();


            List<Korisnik> listaSvihKorisnika = new List<Korisnik>();
            listaSvihKorisnika = baza.Korisnik.ToList();

            int? uloga = 0;
            foreach (Korisnik k in listaSvihKorisnika)
            {
                if (_korime == k.Korime && _lozinka == k.Lozinka)
                {
                    uloga = k.UlogaId;
                }
            }
            return uloga;
        }

        /// <summary>
        /// Dohvaća šifru (ID) prijavljenog korisnika.
        /// </summary>
        /// <param name="_korime">Uneseno korisničko ime.</param>
        /// <param name="_lozinka">Unesena lozinka.</param>
        /// <returns>
        /// ID(int?) prijavljenog korisnika.
        /// Broj 0(int?) ako korisnik ne postoji.
        /// </returns>
        public int? DohvatiId(string _korime, string _lozinka)
        {
            int? sifraKorisnika = 0;
            DBContext baza = new DBContext();
            List<Korisnik> listaSvihKorisnika = new List<Korisnik>();
            listaSvihKorisnika = baza.Korisnik.ToList();

            foreach (Korisnik k in listaSvihKorisnika)
            {
                if (_korime == k.Korime && _lozinka == k.Lozinka)
                {
                    sifraKorisnika = k.UlogaId;
                }
            }
            return sifraKorisnika;
        }

        /// <summary>
        /// Dohvaća korisničko ime prijavljenog korisnika.
        /// </summary>
        /// <param name="_korime">Uneseno korisničko ime.</param>
        /// <param name="_lozinka">Unesena lozinka.</param>
        /// <returns>Korime (string) prijavljenog korisnika.</returns>
        public string DohvatiKorime(string _korime, string _lozinka)
        {
            string korime = "";
            DBContext baza = new DBContext();
            List<Korisnik> listaSvihKorisnika = new List<Korisnik>();
            listaSvihKorisnika = baza.Korisnik.ToList();

            foreach (Korisnik k in listaSvihKorisnika)
            {
                if (_korime == k.Korime && _lozinka == k.Lozinka)
                {
                    korime = k.Korime;
                }
            }
            return korime;
        }

        /// <summary>
        /// Osvježava prikaz textboxova na prijavi (stavlja prazne vrijednosti).
        /// </summary>
        public void OsvjeziPrikaz()
        {
            txtBoxKorime.Text = "";
            txtBoxLozinka.Text = "";
        }
    }
}
