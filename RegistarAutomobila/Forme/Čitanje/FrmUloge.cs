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
        /// Konstruktor forme.
        /// </summary>
        public FrmUloge()
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
        /// Zatvara trenutnu formu i otvara formu za dodavanje nove uloge.
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
        /// Zatvara trenutnu formu, otvara formu za ažuriranje uloga (FrmAzuriranjeUloge) i prosljeđuje
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
                MessageBox.Show("Morate selektirati samo jednu ulogu!");
            }
        }

        /// <summary>
        /// Briše selektiranu ulogu sa Data Grid View-a iz baze podataka.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObriši_Click(object sender, EventArgs e)
        {
            if (dgvUloge.SelectedRows.Count == 1)
            {
                DialogResult poruka = MessageBox.Show($"Sigurno želite izbrisati ovu ulogu?", "Upozorenje!", MessageBoxButtons.YesNo);
                switch (poruka)
                {
                    case DialogResult.Yes:
                        string errorPoruka = ProvjeraUnosa();
                        if (errorPoruka == "")
                        {
                            ObrisiUlogu();
                            MessageBox.Show("Brisanje uspješno!");
                            OsvjeziPrikaz();                         
                        }
                        else
                        {
                            MessageBox.Show(errorPoruka);
                        }
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Morate selektirati samo jednu ulogu!");
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
                Uloga selektiranaUloga = DohvatiSelektiranuUlogu();

                db.Uloga.Attach(selektiranaUloga);
                db.Uloga.Remove(selektiranaUloga);
                db.SaveChanges();                                                 
        }

        /// <summary>
        /// Provjerava da li postoje korisnici sa ulogom koja se želi obrisati.
        /// Ako postoje, vraća poruku obavještenja.
        /// </summary>
        /// <returns>Poruka za ERROR messagebox.</returns>
        private string ProvjeraUnosa()
        {
            string errorPoruka = "";

            Uloga selektiranaUloga = DohvatiSelektiranuUlogu();


            // Provjerava da li već postoje korisnici s tom ulogom.

            int idSelektiraneUloge = selektiranaUloga.Id;

            var upit = from k in db.Korisnik
                       join u in db.Uloga on k.UlogaId equals idSelektiraneUloge
                       select new { k.Korime };

            if (upit.Count() > 0)
            {
                errorPoruka = "Ova uloga je dodjeljena postojećim članovima.\r\nPrije nego se uloga obriše, članovima se mora dodjeliti neka druga uloga.";
            }

            return errorPoruka;
        }
    }
}
