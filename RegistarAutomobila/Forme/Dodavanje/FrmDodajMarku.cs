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

                this.Hide();
                FrmMarkeAutomobila forma = new FrmMarkeAutomobila();
                forma.ShowDialog();                
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
            this.Hide();
            FrmMarkeAutomobila formaMarke = new FrmMarkeAutomobila();
            formaMarke.ShowDialog();           
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
            string errorPoruka = "";

            var upit = from m in db.MarkaAutomobila
                       select new { m.Naziv };

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
                    if (m.Naziv.ToString() == txtBoxNaziv.Text)
                    {
                        errorPoruka = errorPoruka + $"Već postoji marka automobila sa tim nazivom!\r\nUnesite neki drugi naziv!\r\n";
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
