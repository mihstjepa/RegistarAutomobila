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
        public FrmDodajMarku()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string poruka = ProvjeraUnosa(txtBoxNaziv.Text, txtBoxDrzava.Text);

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
                OsvježiPrikaz();
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMarkeAutomobila formaMarke = new FrmMarkeAutomobila();
            formaMarke.ShowDialog();
            this.Close();
        }

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
        private string ProvjeraUnosa(string _naziv, string _drzava)
        {
            string poruka = "";

            if (String.IsNullOrEmpty(txtBoxNaziv.Text))
            {
                poruka = poruka + $"Nije unesen naziv...\r\n";
            }
            if (String.IsNullOrEmpty(txtBoxDrzava.Text))
            {
                poruka = poruka + $"Nije unesena država...\r\n";
            }

            return poruka;
        }
    }
}
