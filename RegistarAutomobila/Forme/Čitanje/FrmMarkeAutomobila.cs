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

        public FrmMarkeAutomobila()
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
            FrmDodajMarku formaDodajMarku = new FrmDodajMarku();
            formaDodajMarku.ShowDialog();
            this.Close();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (dgvSveMarke.SelectedRows.Count == 1)
            {
                
                MarkaAutomobila selektiranaMarka = DohvatiSelektiranuMarku();
                this.Hide();
                FrmAzuriranjeMarke forma = new FrmAzuriranjeMarke(selektiranaMarka);
                forma.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Morate selektirati marku!");
            }
        }

        private void btnObriši_Click(object sender, EventArgs e)
        {
            DialogResult poruka = MessageBox.Show($"Sigurno želite izbrisati marku?", "Upozorenje!", MessageBoxButtons.YesNo);
            switch (poruka)
            {
                case DialogResult.Yes:
                    ObrisiMarku();                    
                    OsvjeziPrikaz();                    
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void OsvjeziPrikaz()
        {
            DBContext baza = new DBContext();

            var upit = from m in baza.MarkaAutomobila
                       select new { m.Id, m.Naziv, m.Drzava};
            dgvSveMarke.DataSource = upit.ToList();

            dgvSveMarke.Columns[0].HeaderText = "Šifra";
            dgvSveMarke.Columns[1].HeaderText = "Naziv";
            dgvSveMarke.Columns[2].HeaderText = "Država";
        }

        private void ObrisiMarku()
        {
            if (dgvSveMarke.SelectedRows.Count == 1)
            {
                MarkaAutomobila selektiranaMarka = DohvatiSelektiranuMarku();

                db.MarkaAutomobila.Attach(selektiranaMarka);
                db.MarkaAutomobila.Remove(selektiranaMarka);
                db.SaveChanges();
                MessageBox.Show("Brisanje uspješno!");
            }
            else
            {
                MessageBox.Show("Niste selektirali člana!");
            }
            
        }
        private void AzurirajMarku()
        {
        }

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
    }
}
