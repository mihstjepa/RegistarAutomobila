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

namespace RegistarAutomobila.Forme.Dodavanje
{
    public partial class FrmDodajModel : Form
    {
        DBContext db = new DBContext();

        public FrmDodajModel()
        {
            InitializeComponent();
            OsvjeziPrikaz();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {           
            FrmModeliAutomobila forma = new FrmModeliAutomobila();
            forma.ShowDialog();
            this.Hide();
            this.Close();
        }

        /// <summary>
        /// Postavlja textboxove za unos na null ("") i poziva metodu za popunjavanje ComboBox-a
        /// za odabir marke automobila.
        /// </summary>
        private void OsvjeziPrikaz()
        {
            txtBoxNaziv.Text = "";
            txtBoxGodinaProizvodnje.Text = "";
            txtBoxCijena.Text = "";
            txtBoxSnagaMotora.Text = "";
            PopuniComboBoxMarka();
        }

        /// <summary>
        /// Popunjuje Combo Box za odabir marke automobila odgovarajućim nazivima.
        /// </summary>
        private void PopuniComboBoxMarka()
        {
            List<string> listaMarki = new List<string>();

            var upit = from m in db.MarkaAutomobila
                       select new { m.Naziv };

            foreach (var item in upit)
            {
                listaMarki.Add(item.Naziv);
            }
            comboBoxOdabirMarke.DataSource = listaMarki;
        }

        /// <summary>
        /// Provodi validaciju unesenih podataka za dodavanje novog modela automobila u bazu.
        /// </summary>
        /// <returns>Poruku za ERROR messagebox.</returns>
        private string ProvjeraUnosa()
        {
            string poruka = "";
            int godinaProizvodnje;
            decimal cijena;
            int snagaMotora;

            // Naziv
            if (String.IsNullOrEmpty(txtBoxNaziv.Text))
            {
                poruka = poruka + $"Nije unesen naziv!\r\n";
            }

            // Godina proizvodnje
            if (String.IsNullOrEmpty(txtBoxGodinaProizvodnje.Text))
            {
                poruka = poruka + $"Nije unesena godina proizvodnje!\r\n";
            }
            if (!int.TryParse(txtBoxGodinaProizvodnje.Text, out godinaProizvodnje))
            {
                poruka = poruka + $"Godina proizvodnje mora biti cijeli broj!\r\n";
            }

            // Cijena
            if (String.IsNullOrEmpty(txtBoxCijena.Text))
            {
                poruka = poruka + $"Nije unesena cijena!\r\n";
            }
            if (!decimal.TryParse(txtBoxCijena.Text, out cijena))
            {
                poruka = poruka + $"Cijena mora biti decimalan broj u formatu 0.00!\r\n";
            }

            // Snaga motora
            if (String.IsNullOrEmpty(txtBoxSnagaMotora.Text))
            {
                poruka = poruka + $"Nije unesena snaga motora!\r\n";
            }
            if (!int.TryParse(txtBoxSnagaMotora.Text, out snagaMotora))
            {
                poruka = poruka + $"Snaga motora mora biti cijeli broj!\r\n";
            }

            return poruka;
        }

        /// <summary>
        /// Dohvaća Id selektirane marke automobila iz ComboBox-a na temelju
        /// naziva koji je u njemu odabran. Id se kasnije koristi za
        /// unos novog modela automobila.
        /// </summary>
        /// <returns>Id selektirane marke automobila.</returns>
        private int DohvatiIdMarke()
        {
            int idMarke = 0;
            string selektiraniNazivMarke = comboBoxOdabirMarke.SelectedItem.ToString();

            var upit = from m in db.MarkaAutomobila
                       select new { m.Id, m.Naziv };

            foreach (var item in upit)
            {
                if (item.Naziv == selektiraniNazivMarke)
                {
                    idMarke = item.Id;
                }
            }

            return idMarke;
        }

        /// <summary>
        /// Poziva metode za validaciju unosa i spremanje novog korisnika u bazu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click_1(object sender, EventArgs e)
        {
            string poruka = ProvjeraUnosa();
            if (poruka != "")
            {
                MessageBox.Show(poruka);
                OsvjeziPrikaz();
            }
            else
            {
                SpremiNoviModel();
                MessageBox.Show("Uspješan unos!");

                FrmModeliAutomobila forma = new FrmModeliAutomobila();
                forma.ShowDialog();
                this.Hide();
                this.Close();
            }
        }

        private void SpremiNoviModel()
        {
            ModelAutomobila noviModel = new ModelAutomobila()
            {
                Naziv = txtBoxNaziv.Text,
                GodinaProizvodnje = int.Parse(txtBoxGodinaProizvodnje.Text),
                SnagaMotora = int.Parse(txtBoxSnagaMotora.Text),
                Cijena = decimal.Parse(txtBoxCijena.Text),
                MarkaAutomobilaId = DohvatiIdMarke(),
                KorisnikId = LoginPodaci.Id
            };

            db.ModelAutomobila.Add(noviModel);
            db.SaveChanges();
        }
    }
}
