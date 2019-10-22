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
    public partial class FrmDodajUlogu : Form
    {
        DBContext db = new DBContext();

        /// <summary>
        /// Konstruktor za formu FrmDodajUlogu.
        /// </summary>
        public FrmDodajUlogu()
        {
            InitializeComponent();
            OsvjeziPrikaz();
        }

        /// <summary>
        /// Dodaje novu ulogu u bazu podataka (tablica "Uloga").
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string poruka = ProvjeraUnosa(txtBoxNazivUloge.Text);

            if (poruka != "")
            {
                MessageBox.Show(poruka);
                OsvjeziPrikaz();
            }
            else
            {
                Uloga novaUloga = new Uloga()
                {
                    Naziv = txtBoxNazivUloge.Text
                };

                db.Uloga.Add(novaUloga);
                db.SaveChanges();
                MessageBox.Show("Uspješan unos!");
                OsvjeziPrikaz();
            }
        }

        /// <summary>
        /// Zatvara trenutnu formu (FrmDodajUlogu) i vraća se u prethodnu (FrmUloge).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUloge forma = new FrmUloge();
            forma.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Osvježava textbox za unos (briše ako je nešto uneseno 
        /// i postavlja blank textbox).
        /// </summary>
        private void OsvjeziPrikaz()
        {
            txtBoxNazivUloge.Text = "";
        }

        /// <summary>
        /// Provodi validaciju unesenih podataka za dodavanje nove uloge u bazu.
        /// </summary>
        /// <param name="_naziv">Naziv nove uloge.</param>
        /// <returns>Poruka za ERROR messagebox.</returns>
        private string ProvjeraUnosa(string _naziv)
        {
            string poruka = "";

            if (String.IsNullOrEmpty(txtBoxNazivUloge.Text))
            {
                poruka = poruka + $"Nije unesen naziv.\r\n";
            }

            return poruka;
        }
    }
}
