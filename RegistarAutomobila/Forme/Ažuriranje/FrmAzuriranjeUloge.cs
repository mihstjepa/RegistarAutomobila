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
    public partial class FrmAzuriranjeUloge : Form
    {
        DBContext db = new DBContext();

        public int IdSelektiraneUloge { get; set; }
        public string NazivSelektiraneUloge { get; set; }


        /// <summary>
        /// Konstruktor forme za ažuriranje uloga (FrmAzuriranjeUloge).
        /// </summary>
        /// <param name="selektiranaUloga">Selektirana uloga iz dgvUloge sa forme FrmUloge.</param>
        public FrmAzuriranjeUloge(Uloga selektiranaUloga)
        {
            InitializeComponent();

            this.IdSelektiraneUloge = selektiranaUloga.Id;
            this.NazivSelektiraneUloge = selektiranaUloga.Naziv;

            txtBoxSifra.Text = this.IdSelektiraneUloge.ToString();
            txtBoxNaziv.Text = this.NazivSelektiraneUloge.ToString();
        }

        /// <summary>
        /// Zatvara trenutnu formu (FrmAzuriranjeUloge) i otvara prethodnu (FrmUloge).
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
        /// Poziva metodu AzurirajUlogu(), zatvara trenutnu formu (FrmAzuriranjeUloge) i
        /// vraća se na prethodnu formu (FrmUloge).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            DialogResult porukaUpozorenja = MessageBox.Show("Sigurno želite ažurirati selektiranu ulogu?", "Upozorenje!", MessageBoxButtons.YesNo);
            switch (porukaUpozorenja)
            {
                case DialogResult.Yes:
                    AzurirajUlogu();
                    this.Hide();
                    FrmUloge forma = new FrmUloge();
                    forma.ShowDialog();
                    this.Close();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        /// <summary>
        /// Ažurira selektiranu ulogu sa novim unosnim podacima.
        /// </summary>
        private void AzurirajUlogu()
        {
            string errorPoruka = "";

            if (string.IsNullOrEmpty(txtBoxNaziv.Text))
            {
                errorPoruka = errorPoruka + $"Nije unesen naziv!\r\n";
            }


            if (errorPoruka == "")
            {
                Uloga selektiranaUloga = new Uloga()
                {
                    Id = this.IdSelektiraneUloge,
                    Naziv = this.NazivSelektiraneUloge
                };

                var postojecaUloga = db.Uloga.Find(selektiranaUloga.Id);
                postojecaUloga.Naziv = txtBoxNaziv.Text;
                db.SaveChanges();
                MessageBox.Show("Ažuriranje uspješno!");
            }
            else
            {
                MessageBox.Show(errorPoruka, "Greška kod unosa!");
            }
        }
    }
}
