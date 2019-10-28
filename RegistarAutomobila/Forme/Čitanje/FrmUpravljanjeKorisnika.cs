using RegistarAutomobila.Forme.Ažuriranje;
using RegistarAutomobila.Forme.Dodavanje;
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
    public partial class FrmUpravljanjeKorisnika : Form
    {
        DBContext db = new DBContext();

        /// <summary>
        /// Konstruktor forme.
        /// </summary>
        public FrmUpravljanjeKorisnika()
        {
            InitializeComponent();
            OsvjeziPrikaz();
        }

        /// <summary>
        /// Zatvara trenutnu formu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNatrag_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        /// <summary>
        /// Zatvara trenutnu formu i otvara formu za unos novih korisnika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNoviUnos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDodajKorisnika forma = new FrmDodajKorisnika();
            forma.ShowDialog();           
            this.Close();
        }

        /// <summary>
        /// Zatvara trenutnu formu i otvara formu za ažuriranje korisnika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAzuriranjeKorisnika forma = new FrmAzuriranjeKorisnika(DohvatiSelektiranogKorisnika());
            forma.ShowDialog();            
            this.Close();
        }

        /// <summary>
        /// Poziva metodu za brisanje korisnika i osvježava prikaz DataGridView-a.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObriši_Click(object sender, EventArgs e)
        {
            if (dgvSviKorisnici.SelectedRows.Count == 1)
            {
                DialogResult poruka = MessageBox.Show($"Sigurno želite izbrisati ovog korisnika?", "Upozorenje!", MessageBoxButtons.YesNo);
                switch (poruka)
                {
                    case DialogResult.Yes:
                        ObrisiKorisnika();
                        MessageBox.Show("Brisanje uspješno!");
                        OsvjeziPrikaz();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Morate selektirati samo jednog korisnika!");
            }
            
        }

        /// <summary>
        /// Prikazuje View iz baze sa svim informacijama korisnika i njihovim dodjeljenim ulogama
        /// te postavlja početnu vrijednost ComboBox-a za odabir filtera.
        /// </summary>
        private void OsvjeziPrikaz()
        {
            var upit = from k in db.Korisnik
                       join u in db.Uloga 
                       on k.UlogaId equals u.Id into nazivUloge         //LEFT JOIN na Uloga.Id
                       from u in nazivUloge.DefaultIfEmpty()
                       select new { k.Id, k.Korime, k.Ime, k.Prezime, k.Lozinka, u.Naziv };
            dgvSviKorisnici.DataSource = upit.ToList();

            dgvSviKorisnici.Columns[0].HeaderText = "Šifra";
            dgvSviKorisnici.Columns[1].HeaderText = "Korisničko ime";
            dgvSviKorisnici.Columns[2].HeaderText = "Ime";
            dgvSviKorisnici.Columns[3].HeaderText = "Prezime";
            dgvSviKorisnici.Columns[4].HeaderText = "Lozinka";
            dgvSviKorisnici.Columns[5].HeaderText = "Naziv uloge";

            comboBoxFilter.SelectedIndex = 0;
        }

        /// <summary>
        /// Dohvaća selektiranog korisnika u DataGridView-u.
        /// </summary>
        /// <returns>Objekt klase Korisnik.</returns>
        private Korisnik DohvatiSelektiranogKorisnika()
        {
            int _id = (int)dgvSviKorisnici.SelectedRows[0].Cells[0].Value;
            Korisnik selektiraniKorisnik = db.Korisnik.Find(_id);

            return selektiraniKorisnik;
        }

        /// <summary>
        /// Briše selektiranog korisnika (DataGridView) iz baze.
        /// </summary>
        private void ObrisiKorisnika()
        {
                Korisnik selektiraniKorisnik = DohvatiSelektiranogKorisnika();

                db.Korisnik.Attach(selektiraniKorisnik);
                db.Korisnik.Remove(selektiraniKorisnik);
                db.SaveChanges();
        }

        /// <summary>
        /// Poziva metode za pretragu korisnika po ključnoj riječi ukoliko
        /// je odabran filter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTrazi_Click(object sender, EventArgs e)
        {
            if (comboBoxFilter.SelectedItem.ToString() != null)
            {
                Trazi(comboBoxFilter.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Morate odabrati filter za pretragu!");
            }
        }

        /// <summary>
        /// Poziva metodu za osvježavanje prikaza u DGV-u.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOsvjeziPrikaz_Click(object sender, EventArgs e)
        {
            OsvjeziPrikaz();
        }

        /// <summary>
        /// Ispisuje rezultate pretrage po ključnoj riječi u DGV
        /// ovisno o odabranom filteru.
        /// </summary>
        /// <param name="odabraniFilter"></param>
        private void Trazi(string odabraniFilter)
        {
            if (odabraniFilter == "Sve" || odabraniFilter == "")
            {
                var upit = from k in db.Korisnik
                           join u in db.Uloga
                           on k.UlogaId equals u.Id into nazivUloge         //LEFT JOIN na Uloga.Id
                           from u in nazivUloge.DefaultIfEmpty()
                           where k.Ime.Contains(txtBoxKljucnaRijec.Text)
                           || k.Prezime.Contains(txtBoxKljucnaRijec.Text)
                           || k.Korime.Contains(txtBoxKljucnaRijec.Text)
                           || u.Naziv.Contains(txtBoxKljucnaRijec.Text)
                           select new { k.Id, k.Korime, k.Ime, k.Prezime, k.Lozinka, u.Naziv };

                dgvSviKorisnici.DataSource = upit.ToList();
            }
            else if (odabraniFilter == "Korisničko ime")
            {
                var upit = from k in db.Korisnik
                           join u in db.Uloga
                           on k.UlogaId equals u.Id into nazivUloge         //LEFT JOIN na Uloga.Id
                           from u in nazivUloge.DefaultIfEmpty()
                           where k.Korime.Contains(txtBoxKljucnaRijec.Text)
                           select new { k.Id, k.Korime, k.Ime, k.Prezime, k.Lozinka, u.Naziv };
                dgvSviKorisnici.DataSource = upit.ToList();
            }
            else if (odabraniFilter == "Ime")
            {
                var upit = from k in db.Korisnik
                           join u in db.Uloga
                           on k.UlogaId equals u.Id into nazivUloge         //LEFT JOIN na Uloga.Id
                           from u in nazivUloge.DefaultIfEmpty()
                           where k.Ime.Contains(txtBoxKljucnaRijec.Text)
                           select new { k.Id, k.Korime, k.Ime, k.Prezime, k.Lozinka, u.Naziv };
                dgvSviKorisnici.DataSource = upit.ToList();
            }
            else if (odabraniFilter == "Prezime")
            {
                var upit = from k in db.Korisnik
                           join u in db.Uloga
                           on k.UlogaId equals u.Id into nazivUloge         //LEFT JOIN na Uloga.Id
                           from u in nazivUloge.DefaultIfEmpty()
                           where k.Prezime.Contains(txtBoxKljucnaRijec.Text)
                           select new { k.Id, k.Korime, k.Ime, k.Prezime, k.Lozinka, u.Naziv };
                dgvSviKorisnici.DataSource = upit.ToList();
            }
            else if (odabraniFilter == "Naziv uloge")
            {
                var upit = from k in db.Korisnik
                           join u in db.Uloga
                           on k.UlogaId equals u.Id into nazivUloge         //LEFT JOIN na Uloga.Id
                           from u in nazivUloge.DefaultIfEmpty()
                           where u.Naziv.Contains(txtBoxKljucnaRijec.Text)
                           select new { k.Id, k.Korime, k.Ime, k.Prezime, k.Lozinka, u.Naziv };
                dgvSviKorisnici.DataSource = upit.ToList();
            }
            

            

            dgvSviKorisnici.Columns[0].HeaderText = "Šifra";
            dgvSviKorisnici.Columns[1].HeaderText = "Korisničko ime";
            dgvSviKorisnici.Columns[2].HeaderText = "Ime";
            dgvSviKorisnici.Columns[3].HeaderText = "Prezime";
            dgvSviKorisnici.Columns[4].HeaderText = "Lozinka";
            dgvSviKorisnici.Columns[5].HeaderText = "Naziv uloge";
        }

        

        private void FrmUpravljanjeKorisnika_Load(object sender, EventArgs e)
        {

        }
    }
}
