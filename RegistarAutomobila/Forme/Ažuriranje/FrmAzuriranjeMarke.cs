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

        /// <summary>
        /// Konstruktor forme.
        /// </summary>
        /// <param name="selektiranaMarka"></param>
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

        /// <summary>
        /// Ako su uneseni novi podaci za postojeću marku automobila,
        /// onda sprema te podatke u bazu.
        /// </summary>
        private void AzurirajMarku()
        {
            MarkaAutomobila selektiranaMarka = new MarkaAutomobila()
            {
                Id = this.ŠifraSelektiraneMarke,
                Naziv = this.NazivSelektiraneMarke,
                Drzava = this.DrzavaSelektiraneMarke
            };

            var postojecaMarka = db.MarkaAutomobila.Find(selektiranaMarka.Id);

            /// AKO SU PRISUTNE PROMJENE ODREĐENIH TEXTBOX-OVA
            if (postojecaMarka.Naziv != txtBoxNaziv.Text)
            {
                postojecaMarka.Naziv = txtBoxNaziv.Text;
            }
            if (postojecaMarka.Drzava != txtBoxDrzava.Text)
            {
                postojecaMarka.Drzava = txtBoxDrzava.Text;
            }
            db.SaveChanges();               
        }

        /// <summary>
        /// Poziva metode za validaciju unesenih podataka i ažuriranje marki automobila u bazi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e)
        {
                DialogResult porukaUpozorenja = MessageBox.Show("Sigurno želite ažurirati selektiranu marku?", "Upozorenje!", MessageBoxButtons.YesNo);
                switch (porukaUpozorenja)
                {
                    case DialogResult.Yes:
                    string errorPoruka = ProvjeraUnosa();

                    if (errorPoruka == "")
                    {
                        AzurirajMarku();
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
                    break;

                case DialogResult.No:
                        break;
                }          
        }

        /// <summary>
        /// Zatvara trenutnu formu i otvara glavnu formu za Marke automobila.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMarkeAutomobila forma = new FrmMarkeAutomobila();
            forma.ShowDialog();           
            this.Close();
        }

        /// <summary>
        /// Provodi validaciju unseneih podataka za ažuriranje
        /// postojeće marke automobila.
        /// </summary>
        /// <returns>Poruke za ERROR messagebox.</returns>
        private string ProvjeraUnosa()
        {
            string errorPoruka = "";

            var upit = from m in db.MarkaAutomobila
                       select new { m.Id, m.Naziv };


            //  NAZIV           
            if (string.IsNullOrEmpty(txtBoxNaziv.Text))
            {
                errorPoruka = errorPoruka + $"Nije unesen naziv!\r\n";
            }
            else if (txtBoxNaziv.Text.Length > 50)
            {
                errorPoruka = errorPoruka + $"Naziv smije imati maksimalno 50 znakova!\r\n";
            }
            else
            {
                foreach (var m in upit)
                {
                    if (m.Naziv.ToString() == txtBoxNaziv.Text && m.Id != this.ŠifraSelektiraneMarke)
                    {
                        errorPoruka = errorPoruka + $"Već postoji marka automobila sa tim nazivom!\r\n";
                    }
                }
            }


            //  DRŽAVA
            if (string.IsNullOrEmpty(txtBoxDrzava.Text))
            {
                errorPoruka = errorPoruka + $"Nije unesena država!\r\n";
            }
            else if (txtBoxDrzava.Text.Length > 50)
            {
                errorPoruka = errorPoruka + $"Država smije imati maksimalno 50 znakova!\r\n";
            }

            return errorPoruka;
        }
    }
}
