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
    public partial class FrmAzuriranjeMarke : Form
    {
        DBContext db = new DBContext();

        public int ŠifraSelektiraneMarke { get; set; }
        public string NazivSelektiraneMarke { get; set; }
        public string DrzavaSelektiraneMarke { get; set; }

        public FrmAzuriranjeMarke(MarkaAutomobila selektiranaMarka)
        {
            InitializeComponent();

            this.ŠifraSelektiraneMarke = selektiranaMarka.Id;
            this.NazivSelektiraneMarke = selektiranaMarka.Naziv;
            this.DrzavaSelektiraneMarke = selektiranaMarka.Drzava;

            txtBoxSifra.Text = this.ŠifraSelektiraneMarke.ToString();
            txtBoxNaziv.Text = this.NazivSelektiraneMarke.ToString();
            txtBoxDrzava.Text = this.DrzavaSelektiraneMarke.ToString();
        }

        private void AzurirajMarku()
        {
            string errorPoruka = "";

            if (string.IsNullOrEmpty(txtBoxNaziv.Text))
            {
                errorPoruka = errorPoruka + $"Nije unesen naziv!\r\n";
            }
            if (string.IsNullOrEmpty(txtBoxDrzava.Text))
            {
                errorPoruka = errorPoruka + $"Nije unesena država!\r\n";
            }


            if (errorPoruka == "")
            {
                MarkaAutomobila selektiranaMarka = new MarkaAutomobila()
                {
                    Id = this.ŠifraSelektiraneMarke,
                    Naziv = this.NazivSelektiraneMarke,
                    Drzava = this.DrzavaSelektiraneMarke
                };

                var postojecaMarka = db.MarkaAutomobila.Find(selektiranaMarka.Id);
                postojecaMarka.Naziv = txtBoxNaziv.Text;
                postojecaMarka.Drzava = txtBoxDrzava.Text;
                db.SaveChanges();
                MessageBox.Show("Ažuriranje uspješno!");
                this.Hide();
                FrmMarkeAutomobila forma = new FrmMarkeAutomobila();
                forma.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(errorPoruka, "Greška kod unosa!");
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
                DialogResult porukaUpozorenjaBrisanjaClana = MessageBox.Show("Sigurno želite ažurirati selektiranog člana?", "Upozorenje!", MessageBoxButtons.YesNo);
                switch (porukaUpozorenjaBrisanjaClana)
                {
                    case DialogResult.Yes:
                        AzurirajMarku();
                        this.Hide();
                        FrmMarkeAutomobila forma = new FrmMarkeAutomobila();
                        forma.ShowDialog();
                        this.Close();
                        break;
                    case DialogResult.No:
                        break;
                }
            
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMarkeAutomobila forma = new FrmMarkeAutomobila();
            forma.ShowDialog();
            this.Close();
        }
    }
}
