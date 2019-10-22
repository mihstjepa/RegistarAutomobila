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

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGlavniIzbornik formaGlavniIzbornik = new FrmGlavniIzbornik();
            formaGlavniIzbornik.ShowDialog();
            this.Close();
        }

        private void btnNoviUnos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDodajKorisnika forma = new FrmDodajKorisnika();
            forma.ShowDialog();
            this.Close();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Poziva metodu za brisanje korisnika "ObrisiKorisnika()" i osvježava prikaz DataGridView-a.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObriši_Click(object sender, EventArgs e)
        {
            DialogResult poruka = MessageBox.Show($"Sigurno želite izbrisati korisnika?", "Upozorenje!", MessageBoxButtons.YesNo);
            switch (poruka)
            {
                case DialogResult.Yes:
                    ObrisiKorisnika();
                    OsvjeziPrikaz();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        /// <summary>
        /// Prikazuje View iz baze sa svim informacijama korisnika i njihovim dodjeljenim ulogama.
        /// </summary>
        private void OsvjeziPrikaz()
        {
            var upit = from k in db.Korisnik
                       join u in db.Uloga on k.UlogaId equals u.Id
                       select new { k.Id, k.Korime, k.Ime, k.Prezime, k.Lozinka, u.Naziv };
            dgvSviKorisnici.DataSource = upit.ToList();

            dgvSviKorisnici.Columns[0].HeaderText = "Šifra";
            dgvSviKorisnici.Columns[1].HeaderText = "Korisničko ime";
            dgvSviKorisnici.Columns[2].HeaderText = "Ime";
            dgvSviKorisnici.Columns[3].HeaderText = "Prezime";
            dgvSviKorisnici.Columns[4].HeaderText = "Lozinka";
            dgvSviKorisnici.Columns[5].HeaderText = "Naziv uloge";
        }

        /// <summary>
        /// Dohvaća selektiranog korisnika u DataGridView-u kao objekt tipa "Korisnik".
        /// </summary>
        /// <returns></returns>
        private Korisnik DohvatiSelektiranogKorisnika()
        {
            var _id = (int)dgvSviKorisnici.SelectedRows[0].Cells[0].Value;
            var _korime = (string)dgvSviKorisnici.SelectedRows[0].Cells[1].Value;
            var _ime = (string)dgvSviKorisnici.SelectedRows[0].Cells[2].Value;
            var _prezime = (string)dgvSviKorisnici.SelectedRows[0].Cells[3].Value;
            var _lozinka = (string)dgvSviKorisnici.SelectedRows[0].Cells[4].Value;
            var _nazivUloge = (string)dgvSviKorisnici.SelectedRows[0].Cells[5].Value;
            int _ulogaId = 0;

            var upit = from u in db.Uloga
                       select new { u.Id, u.Naziv };

            foreach (var uloga in upit)
            {
                if (uloga.Naziv == _nazivUloge)
                {
                    _ulogaId = uloga.Id;
                }
            }

            if (_ulogaId != 0)
            {
                Korisnik selektiraniKorisnik = new Korisnik()
                {
                    Id = _id,
                    Korime = _korime,
                    Ime = _ime,
                    Prezime = _prezime,
                    Lozinka = _lozinka,
                    UlogaId = _ulogaId
                };

                return selektiraniKorisnik;
            }
            else
            {
                return null;
            }
            
        }

        /// <summary>
        /// Briše selektiranog korisnika (DataGridView) iz baze.
        /// </summary>
        private void ObrisiKorisnika()
        {
            if (dgvSviKorisnici.SelectedRows.Count == 1)
            {
                Korisnik selektiraniKorisnik = DohvatiSelektiranogKorisnika();

                db.Korisnik.Attach(selektiraniKorisnik);
                db.Korisnik.Remove(selektiraniKorisnik);
                db.SaveChanges();
                MessageBox.Show("Brisanje uspješno!");
            }
            else
            {
                MessageBox.Show("Niste selektirali korisnika!");
            }
        }
    }
}
