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
    public partial class FrmDodajMarku : Form
    {
        DBContext db = new DBContext();

        /// <summary>
        /// Konstruktor forme.
        /// </summary>
        public FrmDodajMarku()
        {
            InitializeComponent();
            OsvježiPrikaz();
        }

        /// <summary>
        /// Poziva metode za provjeru unesenih podataka i spremanje nove marke automobila u bazu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string poruka = ProvjeraUnosa();
            if (poruka != "")
            {
                MessageBox.Show(poruka);
                OsvježiPrikaz();
            }
            else
            {
                MarkaAutomobila novaMarka = new MarkaAutomobila()
                {
                    Naziv = txtBoxNaziv.Text,
                    Drzava = txtBoxDrzava.Text
                };

                db.MarkaAutomobila.Add(novaMarka);
                db.SaveChanges();
                MessageBox.Show("Uspješan unos!");

                FrmMarkeAutomobila forma = new FrmMarkeAutomobila();
                forma.ShowDialog();
                this.Hide();
                this.Close();
            }
        }

        /// <summary>
        /// Zatvara trenutnu formu i otvara glavnu formu za Marke automobila.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNatrag_Click(object sender, EventArgs e)
        {           
            FrmMarkeAutomobila formaMarke = new FrmMarkeAutomobila();
            formaMarke.ShowDialog();
            this.Hide();
            this.Close();
        }

        /// <summary>
        /// Postavlja vrijednost TextBox-ova na null ("").
        /// </summary>
        private void OsvježiPrikaz()
        {
            txtBoxDrzava.Text = "";
            txtBoxNaziv.Text = "";
        }

        /// <summary>
        /// Obavlja validaciju podataka za unos nove marke automobila.
        /// </summary>
        /// <param name="_naziv">Uneseni naziv marke.</param>
        /// <param name="_drzava">Unesena država porijekla marke.</param>
        /// <returns>Poruka za ERROR messagebox.</returns>
        private string ProvjeraUnosa()
        {
            string poruka = "";

            // Naziv
            if (String.IsNullOrEmpty(txtBoxNaziv.Text))
            {
                poruka = poruka + $"Nije unesen naziv...\r\n";
            }

            // Država
            if (String.IsNullOrEmpty(txtBoxDrzava.Text))
            {
                poruka = poruka + $"Nije unesena država...\r\n";
            }

            return poruka;
        }
    }
}
