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
    public partial class FrmAzuriranjeModela : Form
    {
        DBContext db = new DBContext();

        public int Id { get; set; }
        public string Naziv { get; set; }
        public int GodinaProizvodnje { get; set; }
        public int SnagaMotora { get; set; }
        public decimal Cijena { get; set; }
        public int? MarkaAutomobilaId { get; set; }
        public int? KorisnikId { get; set; }



        public FrmAzuriranjeModela(ModelAutomobila selektiraniModel)
        {
            InitializeComponent();

            this.Id = selektiraniModel.Id;
            this.Naziv = selektiraniModel.Naziv;
            this.GodinaProizvodnje = selektiraniModel.GodinaProizvodnje;
            this.SnagaMotora = selektiraniModel.SnagaMotora;
            this.Cijena = selektiraniModel.Cijena;
            this.MarkaAutomobilaId = selektiraniModel.MarkaAutomobilaId;
            this.KorisnikId = selektiraniModel.KorisnikId;

            OsvjeziPrikaz();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            DialogResult porukaUpozorenja = MessageBox.Show("Sigurno želite ažurirati ovaj model automobila?", "Upozorenje!", MessageBoxButtons.YesNo);
            switch (porukaUpozorenja)
            {
                case DialogResult.Yes:
                    string errorPoruka = ProvjeraUnosa();

                    if (errorPoruka == "")
                    {
                        AzurirajModel();
                        MessageBox.Show("Ažuriranje uspješno!");

                        this.Hide();
                        FrmModeliAutomobila forma = new FrmModeliAutomobila();
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

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmModeliAutomobila forma = new FrmModeliAutomobila();
            forma.ShowDialog();            
            this.Close();
        }

        /// <summary>
        /// Popunjava Combo Box za odabir Marke automobila sa
        /// nazivima marki i postavlja default vrijednost Combo Boxa
        /// na naziv marke selektiranog modela automobila.
        /// </summary>
        private void PopuniComboBoxMarka()
        {
            List<string> listaMarki = new List<string>();

            var upit = from m in db.MarkaAutomobila
                       select new { m.Id, m.Naziv };

            foreach (var item in upit)
            {
                listaMarki.Add(item.Naziv);
            }
            comboBoxOdabirMarke.DataSource = listaMarki;


            // Postavljanje inicijalne vrijednosti
            foreach (var item in upit)
            {
                if (item.Id == this.MarkaAutomobilaId)
                {
                    comboBoxOdabirMarke.Text = item.Naziv;
                }
            }
        }

        /// <summary>
        /// Postavlja placeholdere na polja za ažuriranje Marke automobila
        /// i puni Combo Box za odabir marke automobila.
        /// </summary>
        private void OsvjeziPrikaz()
        {
            txtBoxSifra.Text = this.Id.ToString();
            txtBoxNaziv.Text = this.Naziv.ToString();
            txtBoxGodinaProizvodnje.Text = this.GodinaProizvodnje.ToString();
            txtBoxSnagaMotora.Text = this.SnagaMotora.ToString();
            txtBoxCijena.Text = this.Cijena.ToString();
            PopuniComboBoxMarka();
        }

        /// <summary>
        /// Provodi validaciju unesenih podataka za ažuriranje postojećeg
        /// modela automobila.
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
            else if (txtBoxNaziv.Text.Length > 50)
            {
                poruka = poruka + $"Naziv smije imati maksimalno 50 znakova!\r\n";
            }

            // Godina proizvodnje
            if (String.IsNullOrEmpty(txtBoxGodinaProizvodnje.Text))
            {
                poruka = poruka + $"Nije unesena godina proizvodnje!\r\n";
            }
            else if (!int.TryParse(txtBoxGodinaProizvodnje.Text, out godinaProizvodnje))
            {
                poruka = poruka + $"Godina proizvodnje mora biti cijeli broj!\r\n";
            }
            else if (txtBoxGodinaProizvodnje.Text.Length != 4)
            {
                poruka = poruka + $"Unesena godina mora imati točno 4 znamenke!\r\n";
            }

            // Cijena
            if (String.IsNullOrEmpty(txtBoxCijena.Text))
            {
                poruka = poruka + $"Nije unesena cijena!\r\n";
            }
            else if (!decimal.TryParse(txtBoxCijena.Text, out cijena))
            {
                poruka = poruka + $"Cijena mora biti decimalan broj u formatu 0.00!\r\n";
            }
            else if (decimal.Parse(txtBoxCijena.Text) > 999999999999999999)
            {
                poruka = poruka + $"Cijena mora biti manji iznos!\r\n";
            }

            // Snaga motora
            if (String.IsNullOrEmpty(txtBoxSnagaMotora.Text))
            {
                poruka = poruka + $"Nije unesena snaga motora!\r\n";
            }
            else if (!int.TryParse(txtBoxSnagaMotora.Text, out snagaMotora))
            {
                poruka = poruka + $"Snaga motora mora biti cijeli broj!\r\n";
            }
            else if (int.Parse(txtBoxSnagaMotora.Text) > 10000)
            {
                poruka = poruka + $"Snaga motora mora biti manji broj!\r\n";
            }

            return poruka;
        }

        /// <summary>
        /// Sprema ažurirane promjene nad postojećim modelom automobila
        /// u bazi podataka.
        /// </summary>
        private void AzurirajModel()
        {
            
                var postojeciModel = db.ModelAutomobila.Find(this.Id);


                // AKO SU PRISUTNE PROMJENE ODREĐENIH TEXTBOX-OVA
                if (postojeciModel.Naziv != txtBoxNaziv.Text)
                {
                    postojeciModel.Naziv = txtBoxNaziv.Text;
                }
                if (postojeciModel.GodinaProizvodnje != int.Parse(txtBoxGodinaProizvodnje.Text))
                {
                    postojeciModel.GodinaProizvodnje = int.Parse(txtBoxGodinaProizvodnje.Text);
                }
                if (postojeciModel.SnagaMotora != int.Parse(txtBoxSnagaMotora.Text))
                {
                    postojeciModel.SnagaMotora = int.Parse(txtBoxSnagaMotora.Text);
                }
                if (postojeciModel.Cijena != decimal.Parse(txtBoxCijena.Text))
                {
                    postojeciModel.Cijena = decimal.Parse(txtBoxCijena.Text);
                }
                if (postojeciModel.MarkaAutomobilaId != DohvatiMarkuIzComboBoxa().Id)
                {
                    postojeciModel.MarkaAutomobilaId = DohvatiMarkuIzComboBoxa().Id;
                }
                postojeciModel.KorisnikId = LoginPodaci.Id;

                db.SaveChanges();
        }

        /// <summary>
        /// Dohvaća selektiranu marku automobila u DGV-u.
        /// </summary>
        /// <returns>Instancu objekta tipa MarkaAutomobila.</returns>
        private MarkaAutomobila DohvatiMarkuIzComboBoxa()
        {
            MarkaAutomobila selektiranaMarka = new MarkaAutomobila();

            var upit = from m in db.MarkaAutomobila
                       select new { m.Id, m.Naziv, m.Drzava };

            foreach (var item in upit)
            {
                if (item.Naziv == comboBoxOdabirMarke.SelectedItem.ToString())
                {
                    selektiranaMarka.Id = item.Id;
                    selektiranaMarka.Naziv = item.Naziv;
                    selektiranaMarka.Drzava = item.Drzava;
                }
            }

            return selektiranaMarka;
        }
    }
}
