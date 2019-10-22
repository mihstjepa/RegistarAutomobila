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
    public partial class FrmUloge : Form
    {
        DBContext db = new DBContext();

        /// <summary>
        /// Konstruktor forme FrmUloge.
        /// </summary>
        public FrmUloge()
        {
            InitializeComponent();
            OsvjeziPrikaz();
        }

        /// <summary>
        /// Zatvara trenutnu formu (FrmUloge) i otvara prethodnu (FrmGlavniIzbornik)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGlavniIzbornik formaGlavniIzbornik = new FrmGlavniIzbornik();
            formaGlavniIzbornik.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Zatvara trenutnu formu (FrmUloge) i otvara formu za dodavanje nove uloge (FrmDodavanjeUloge).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNoviUnos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDodajUlogu forma = new FrmDodajUlogu();
            forma.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Otvara formu za ažuriranje uloga (FrmAzuriranjeUloge) i prosljeđuje
        /// joj selektiranu ulogu iz dgvUloge.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (dgvUloge.SelectedRows.Count == 1)
            {
                Uloga selektiranaUloga = DohvatiSelektiranuUlogu();
                this.Hide();
                FrmAzuriranjeUloge forma = new FrmAzuriranjeUloge(selektiranaUloga);
                forma.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Morate selektirati ulogu!");
            }
        }

        /// <summary>
        /// Briše selektiranu ulogu (dgvUloge) iz baze podataka (tablica "Uloga").
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObriši_Click(object sender, EventArgs e)
        {
            DialogResult poruka = MessageBox.Show($"Sigurno želite izbrisati ovu ulogu?", "Upozorenje!", MessageBoxButtons.YesNo);
            switch (poruka)
            {
                case DialogResult.Yes:
                    ObrisiUlogu();
                    OsvjeziPrikaz();
                    break;
                case DialogResult.No:
                    break;
            }
        }


        /// <summary>
        /// Puni dgvUloge sa svim ulogama iz baze.
        /// </summary>
        private void OsvjeziPrikaz()
        {
            var upit = from u in db.Uloga
                       select new { u.Id, u.Naziv };
            dgvUloge.DataSource = upit.ToList();

            dgvUloge.Columns[0].HeaderText = "Šifra";
            dgvUloge.Columns[1].HeaderText = "Naziv";
        }

        /// <summary>
        /// Dohvaća selektiranu ulogu iz dgvUloge.
        /// </summary>
        /// <returns>Objekt tipa "Uloga".</returns>
        private Uloga DohvatiSelektiranuUlogu()
        {
            var _id = (int)dgvUloge.SelectedRows[0].Cells[0].Value;
            var _naziv = (string)dgvUloge.SelectedRows[0].Cells[1].Value;

            Uloga selektiranaUloga = new Uloga()
            {
                Id = _id,
                Naziv = _naziv
            };

            return selektiranaUloga;
        }

        /// <summary>
        /// Briše selektiranu ulogu iz dgvUloge u bazi (tablica Uloga).
        /// </summary>
        private void ObrisiUlogu()
        {
            if (dgvUloge.SelectedRows.Count == 1)
            {
                Uloga selektiranaUloga = DohvatiSelektiranuUlogu();
                int idSelektiraneUloge = selektiranaUloga.Id;

                var upit = from k in db.Korisnik
                           join u in db.Uloga on k.UlogaId equals idSelektiraneUloge
                           select new { k.Korime};

                // Provjerava da li postoje korisnici s tom ulogom.
                if (upit.Count() > 0)
                {
                    MessageBox.Show("Ova uloga je dodjeljena postojećim članovima. Prije nego se uloga obriše, članovima se mora dodjeliti neka druga uloga.");
                }
                else
                {
                    db.Uloga.Attach(selektiranaUloga);
                    db.Uloga.Remove(selektiranaUloga);
                    db.SaveChanges();
                    MessageBox.Show("Brisanje uspješno!");
                }               
            }
            else
            {
                MessageBox.Show("Niste selektirali člana!");
            }
        }
    }
}
