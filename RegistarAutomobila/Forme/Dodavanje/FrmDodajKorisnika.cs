﻿using RegistarAutomobila.Modeli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistarAutomobila.Forme.Dodavanje
{
    public partial class FrmDodajKorisnika : Form
    {
        DBContext db = new DBContext();

        /// <summary>
        /// Konstruktor za formu FrmDodajKorisnika.
        /// </summary>
        public FrmDodajKorisnika()
        {
            InitializeComponent();
            OsvjeziPrikaz();
        }

        /// <summary>
        /// Zatvara trenutnu formu (FrmDodajKorisnika) i otvara prethodnu (FrmUpravljanjeKorisnika).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUpravljanjeKorisnika forma = new FrmUpravljanjeKorisnika();
            forma.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Poziva metode za validaciju unosa i spremanje novog korisnika u bazu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string poruka = ProvjeraUnosa(txtBoxKorime.Text, txtBoxIme.Text, txtBoxPrezime.Text, txtBoxLozinka.Text, txtBoxPotvrdaLozinke.Text);

            if (poruka != "")
            {
                MessageBox.Show(poruka);
                OsvjeziPrikaz();
            }
            else
            {
                Korisnik noviKorisnik = new Korisnik()
                {
                    Korime = txtBoxKorime.Text,
                    Ime = txtBoxIme.Text,
                    Prezime = txtBoxPrezime.Text,
                    Lozinka = txtBoxLozinka.Text,
                    UlogaId = DohvatiSifruUloge()
                };

                db.Korisnik.Add(noviKorisnik);
                db.SaveChanges();
                MessageBox.Show("Uspješan unos!");
                OsvjeziPrikaz();
            }
        }

        /// <summary>
        /// Postavlja textboxove za unos na null ("") i poziva metodu za popunjavanje ComboBox-a
        /// za odabir uloga.
        /// </summary>
        private void OsvjeziPrikaz()
        {
            txtBoxKorime.Text = "";
            txtBoxIme.Text = "";
            txtBoxPrezime.Text = "";
            txtBoxLozinka.Text = "";
            txtBoxPotvrdaLozinke.Text = "";
            PopuniComboBoxUloga();
        }

        /// <summary>
        /// Puni ComboBox za odabir ulogama odgovarajućim nazivima uloga.
        /// </summary>
        private void PopuniComboBoxUloga()
        {
            List<string> listaUloga = new List<string>();

            var upit = from u in db.Uloga
                       select new { u.Naziv };

            foreach (var uloga in upit)
            {
                listaUloga.Add(uloga.Naziv);
            }

            comboBoxOdabirUloge.DataSource = listaUloga;
        }

        /// <summary>
        /// Provodi validaciju unesenih podataka za dodavanje nove uloge u bazu.
        /// </summary>
        /// <param name="_korime">Korisničko ime novog korisnika.</param>
        /// <param name="_ime">Ime novog korisnika.</param>
        /// <param name="_prezime">Prezime novog korisnika.</param>
        /// <param name="_lozinka">Lozinka novog korisnika.</param>
        /// <param name="_potvrdaLozinke">Potvrđena lozinka novog korisnika.</param>
        /// <returns>Poruka za ERROR messagebox.</returns>
        private string ProvjeraUnosa(string _korime, string _ime, string _prezime, string _lozinka, string _potvrdaLozinke)
        {
            string poruka = "";



            var upit = from k in db.Korisnik
                       select new { k.Korime };

            foreach (var k in upit)
            {
                if (k.Korime.ToString() == _korime)
                {
                    poruka = poruka + $"Uneseno korisničko ime je zauzeto!\r\n";
                }
            }
            if (String.IsNullOrEmpty(txtBoxKorime.Text))
            {
                poruka = poruka + $"Nije uneseno korisničko ime!\r\n";
            }
            if (String.IsNullOrEmpty(txtBoxIme.Text))
            {
                poruka = poruka + $"Nije uneseno ime!\r\n";
            }
            if (String.IsNullOrEmpty(txtBoxPrezime.Text))
            {
                poruka = poruka + $"Nije uneseno prezime!\r\n";
            }
            if (String.IsNullOrEmpty(txtBoxLozinka.Text))
            {
                poruka = poruka + $"Nije unesena lozinka!\r\n";
            }
            if (String.IsNullOrEmpty(txtBoxPotvrdaLozinke.Text))
            {
                poruka = poruka + $"Nije unesena potvrda lozinke!\r\n";
            }
            if (txtBoxLozinka.Text != txtBoxPotvrdaLozinke.Text)
            {
                poruka = poruka + $"Potvrđena lozinka nije ista kao prethodna!\r\n";
            }

            

            return poruka;
        }


        /// <summary>
        /// Dohvaća Id selektirane uloge iz ComboBox-a na temelju
        /// naziva koji je u njemu odabran. Id se kasnije koristi za
        /// unos novog korisnika.
        /// </summary>
        /// <returns>Šifra selektirane uloge.</returns>
        private int DohvatiSifruUloge()
        {
            int id = 0;

            string selektiraniNazivUloge = comboBoxOdabirUloge.SelectedItem.ToString();

            var upit = from u in db.Uloga
                       select new { u.Id, u.Naziv };

            foreach (var uloga in upit)
            {
                if (uloga.Naziv == selektiraniNazivUloge)
                {
                    id = uloga.Id;
                }
            }

            return id;
        }
    }
}
