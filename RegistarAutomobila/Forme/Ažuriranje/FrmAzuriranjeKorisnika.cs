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

namespace RegistarAutomobila.Forme.Ažuriranje
{
    public partial class FrmAzuriranjeKorisnika : Form
    {
        DBContext db = new DBContext();

        //Atributi selektiranog korisnika za Placeholdere
        public int Id { get; set; }
        public string Korime { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Lozinka { get; set; }
        public int? UlogaId { get; set; }

        /// <summary>
        /// Konstruktor forme koji puni placeholder atribute.
        /// </summary>
        /// <param name="selektiraniKorisnik">Korisnik selektiran u Data Grid View-u
        /// na glavnom formi za upravljanje korisnicima.</param>
        public FrmAzuriranjeKorisnika(Korisnik selektiraniKorisnik)
        {
            InitializeComponent();

            this.Id = selektiraniKorisnik.Id;
            this.Korime = selektiraniKorisnik.Korime;
            this.Ime = selektiraniKorisnik.Ime;
            this.Prezime = selektiraniKorisnik.Prezime;
            this.Lozinka = selektiraniKorisnik.Lozinka;
            this.UlogaId = selektiraniKorisnik.UlogaId;

            OsvjeziPrikaz();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUpravljanjeKorisnika forma = new FrmUpravljanjeKorisnika();
            forma.ShowDialog();           
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            DialogResult porukaUpozorenja = MessageBox.Show("Sigurno želite ažurirati ovog korisnika?", "Upozorenje!", MessageBoxButtons.YesNo);
            switch (porukaUpozorenja)
            {
                case DialogResult.Yes:
                    string errorPoruka = ProvjeraUnosa();

                    if (errorPoruka == "")
                    {
                        AzurirajKorisnika();
                        MessageBox.Show("Ažuriranje uspješno!");

                        this.Hide();
                        FrmUpravljanjeKorisnika forma = new FrmUpravljanjeKorisnika();
                        forma.ShowDialog();                       
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(errorPoruka, "Greška kod unosa!");
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void PopuniComboBoxUloga()
        {
            List<string> listaUloga = new List<string>();

            var upit = from u in db.Uloga
                       select new { u.Id, u.Naziv };

            foreach (var uloga in upit)
            {
                listaUloga.Add(uloga.Naziv);
            }

            comboBoxOdabirUloge.DataSource = listaUloga;

            // Postavljanje inicijalne vrijednosti
            foreach (var item in upit)
            {
                if (item.Id == this.UlogaId)
                {
                    comboBoxOdabirUloge.Text = item.Naziv;
                }
            }
        }

        /// <summary>
        /// Dohvaća Id selektirane uloge iz ComboBox-a na temelju
        /// naziva koji je u njemu odabran. Id se kasnije koristi za
        /// unos novog korisnika.
        /// </summary>
        /// <returns>Šifra selektirane uloge.</returns>
        private int DohvatiSifruUlogeIzComboBoxa()
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

        /// <summary>
        /// Provodi validaciju unesenih podataka za ažuriranje korisnika u bazi.
        /// </summary>
        /// <returns>Poruka za ERROR messagebox.</returns>
        private string ProvjeraUnosa()
        {
            string poruka = "";



            var upit = from k in db.Korisnik
                       select new { k.Id, k.Korime };


            //  KORISNIČKO IME           
            
            if (String.IsNullOrEmpty(txtBoxKorime.Text))
            {
                poruka = poruka + $"Nije uneseno korisničko ime!\r\n";
            }
            else if (txtBoxKorime.Text.Length > 50)
            {
                poruka = poruka + $"Korisničko ime smije imati maksimalno 50 znakova!\r\n";
            }
            else
            {
                foreach (var k in upit)
                {
                    //  Ako je korisničko ime zauzeto (osim ako je to isto korisničko ime koje je selektirano)
                    if (k.Korime.ToString() == txtBoxKorime.Text && k.Id != this.Id)
                    {
                        poruka = poruka + $"Uneseno korisničko ime je zauzeto!\r\n";
                    }
                }
            }
            


            //  IME
            if (String.IsNullOrEmpty(txtBoxIme.Text))
            {
                poruka = poruka + $"Nije uneseno ime!\r\n";
            }
            else if (txtBoxIme.Text.Length > 50)
            {
                poruka = poruka + $"Ime smije imati maksimalno 50 znakova!\r\n";
            }

            //  PREZIME
            if (String.IsNullOrEmpty(txtBoxPrezime.Text))
            {
                poruka = poruka + $"Nije uneseno prezime!\r\n";
            }
            else if (txtBoxPrezime.Text.Length > 50)
            {
                poruka = poruka + $"Prezime smije imati maksimalno 50 znakova!\r\n";
            }

            //  LOZINKA
            if (String.IsNullOrEmpty(txtBoxLozinka.Text))
            {
                poruka = poruka + $"Nije unesena lozinka!\r\n";
            }
            else if (txtBoxLozinka.Text.Length > 50)
            {
                poruka = poruka + $"Lozinka smije imati maksimalno 50 znakova!\r\n";
            }

            return poruka;
        }

        private void OsvjeziPrikaz()
        {
            txtBoxSifra.Text = this.Id.ToString();
            txtBoxKorime.Text = this.Korime.ToString();
            txtBoxIme.Text = this.Ime.ToString();
            txtBoxPrezime.Text = this.Prezime.ToString();
            txtBoxLozinka.Text = this.Lozinka.ToString();
            PopuniComboBoxUloga();
        }

        private void AzurirajKorisnika()
        {
            var postojeciKorisnik = db.Korisnik.Find(this.Id);

            //  AKO SU PRISUTNE PROMJENE U TEXTBOX-OVIMA
            if (postojeciKorisnik.Korime != txtBoxKorime.Text)
            {
                postojeciKorisnik.Korime = txtBoxKorime.Text;
            }
            if (postojeciKorisnik.Ime != txtBoxIme.Text)
            {
                postojeciKorisnik.Ime = txtBoxIme.Text;
            }
            if (postojeciKorisnik.Prezime != txtBoxPrezime.Text)
            {
                postojeciKorisnik.Prezime = txtBoxPrezime.Text;
            }
            if (postojeciKorisnik.Lozinka != txtBoxLozinka.Text)
            {
                postojeciKorisnik.Lozinka = txtBoxLozinka.Text;
            }
            if (postojeciKorisnik.UlogaId != DohvatiSifruUlogeIzComboBoxa())
            {
                postojeciKorisnik.UlogaId = DohvatiSifruUlogeIzComboBoxa();
            }

            db.SaveChanges();
        }
    }
}
