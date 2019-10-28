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
    public partial class FrmMarkeAutomobila : Form
    {
        DBContext db = new DBContext();

        /// <summary>
        /// Konstruktor forme.
        /// </summary>
        public FrmMarkeAutomobila()
        {
            InitializeComponent();
            AutentikacijaUloge();
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
        /// Zatvara trenutnu formu i otvara formu za dodavanje nove marke automobila.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNoviUnos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDodajMarku formaDodajMarku = new FrmDodajMarku();
            formaDodajMarku.ShowDialog();            
            this.Close();
        }

        /// <summary>
        /// Zatvara trenutnu i otvara formu za ažuriranje marki automobila.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (dgvSveMarke.SelectedRows.Count == 1)
            {
                this.Hide();
                FrmAzuriranjeMarke forma = new FrmAzuriranjeMarke(DohvatiSelektiranuMarku());
                forma.ShowDialog();                
                this.Close();
            }
            else
            {
                MessageBox.Show("Morate selektirati samo jednu marku!");
            }
        }

        /// <summary>
        /// Briše selektiranu marku automobila iz baze podataka.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObriši_Click(object sender, EventArgs e)
        {
            if (dgvSveMarke.SelectedRows.Count == 1)
            {
                DialogResult poruka = MessageBox.Show($"Sigurno želite izbrisati ovu marku automobila?\r\nSvi modeli automobila ove marke će također biti izbrisani.", "Upozorenje!", MessageBoxButtons.YesNo);
                switch (poruka)
                {
                    case DialogResult.Yes:
                        ObrisiMarku();
                        MessageBox.Show("Brisanje uspješno!");
                        OsvjeziPrikaz();                    
                        break;

                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Morate selektirati samo jedan model automobila!");
            }
        }

        /// <summary>
        /// Popunjava Data Grid View sa svim markama automobila iz baze.
        /// </summary>
        private void OsvjeziPrikaz()
        {
            DBContext baza = new DBContext();

            var upit = from m in baza.MarkaAutomobila
                       select new { m.Id, m.Naziv, m.Drzava};
            dgvSveMarke.DataSource = upit.ToList();

            dgvSveMarke.Columns[0].HeaderText = "Šifra";
            dgvSveMarke.Columns[1].HeaderText = "Naziv";
            dgvSveMarke.Columns[2].HeaderText = "Država";

            comboBoxFilter.SelectedIndex = 0;
        }

        /// <summary>
        /// Briše selektiranu marku automobila u Data Grid View-u iz baze.
        /// </summary>
        private void ObrisiMarku()
        {
            if (dgvSveMarke.SelectedRows.Count == 1)
            {
                MarkaAutomobila selektiranaMarka = DohvatiSelektiranuMarku();

                db.MarkaAutomobila.Attach(selektiranaMarka);
                db.MarkaAutomobila.Remove(selektiranaMarka);
                db.SaveChanges();               
            }
            else
            {
                MessageBox.Show("Niste selektirali člana!");
            }          
        }

        /// <summary>
        /// Dohvaća selektiranu marku automobila iz baze u obliku objekta.
        /// </summary>
        /// <returns>Objekt tipa "MarkaAutomobila".</returns>
        public MarkaAutomobila DohvatiSelektiranuMarku()
        {
            var _id = (int) dgvSveMarke.SelectedRows[0].Cells[0].Value;
            var _naziv = (string)dgvSveMarke.SelectedRows[0].Cells[1].Value;
            var _drzava = (string)dgvSveMarke.SelectedRows[0].Cells[2].Value;

            MarkaAutomobila selektiranaMarka = new MarkaAutomobila()
            {
                Id = _id,
                Naziv = _naziv,
                Drzava = _drzava
            };

            return selektiranaMarka;
        }


        /// <summary>
        /// Provjerava ulogu logiranog korisnika i sakriva gumbe ovisno o pravima uloge.
        /// </summary>
        private void AutentikacijaUloge()
        {
            if (LoginPodaci.Uloga != 1 && LoginPodaci.Uloga != 2)
            {
                btnAzuriraj.Visible = false;
                btnNoviUnos.Visible = false;
                btnObriši.Visible = false;
            }
        }

        /// <summary>
        /// Poziva metodu za pretragu po ključnoj riječi ako je odabran filter.
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
        /// Poziva metodu za osvjezavanje prikaza DGV-a.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOsvjeziPrikaz_Click(object sender, EventArgs e)
        {
            OsvjeziPrikaz();
        }

        /// <summary>
        /// Ispisuje rezultate pretrage u DGV.
        /// </summary>
        /// <param name="odabraniFilter"></param>
        private void Trazi(string odabraniFilter)
        {
            if (odabraniFilter == "Sve" || odabraniFilter == "")
            {
                var upit = from m in db.MarkaAutomobila
                           where m.Naziv.ToString().Contains(txtBoxKljucnaRijec.Text) || m.Drzava.ToString().Contains(txtBoxKljucnaRijec.Text)
                           select new { m.Id, m.Naziv, m.Drzava };
                dgvSveMarke.DataSource = upit.ToList();               
            }
            else if (odabraniFilter == "Naziv")
            {
                var upit = from m in db.MarkaAutomobila
                           where m.Naziv.ToString().Contains(txtBoxKljucnaRijec.Text)
                           select new { m.Id, m.Naziv, m.Drzava };
                dgvSveMarke.DataSource = upit.ToList();
            }
            else if (odabraniFilter == "Država")
            {
                var upit = from m in db.MarkaAutomobila
                           where m.Drzava.ToString().Contains(txtBoxKljucnaRijec.Text)
                           select new { m.Id, m.Naziv, m.Drzava };
                dgvSveMarke.DataSource = upit.ToList();
            }
                
            dgvSveMarke.Columns[0].HeaderText = "Šifra";
            dgvSveMarke.Columns[1].HeaderText = "Naziv";
            dgvSveMarke.Columns[2].HeaderText = "Država";
        }
    }
}
