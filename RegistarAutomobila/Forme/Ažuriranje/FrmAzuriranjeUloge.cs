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
        /// Zatvara trenutnu formu i otvara prethodnu glavnu formu za uloge.
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
                    string errorPoruka = ProvjeraUnosa();
                    if (errorPoruka == "")
                    {                       
                        AzurirajUlogu();
                        MessageBox.Show("Ažuriranje uspješno!");

                        this.Hide();
                        FrmUloge forma = new FrmUloge();
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
        /// Ažurira selektiranu ulogu sa novim unosnim podacima.
        /// </summary>
        private void AzurirajUlogu()
        {
                Uloga selektiranaUloga = new Uloga()
                {
                    Id = this.IdSelektiraneUloge,
                    Naziv = this.NazivSelektiraneUloge
                };

                var postojecaUloga = db.Uloga.Find(selektiranaUloga.Id);
                postojecaUloga.Naziv = txtBoxNaziv.Text;
                db.SaveChanges();
        }

        /// <summary>
        /// Provodi validaciju unesenih podataka kod ažuriranja postojeće uloge.
        /// </summary>
        /// <returns>Poruku za ERROR messagebox.</returns>
        private string ProvjeraUnosa()
        {
            string errorPoruka = "";

            var upit = from u in db.Uloga
                       select new { u.Id, u.Naziv };

            
            //  NAZIV
            if (string.IsNullOrEmpty(txtBoxNaziv.Text))
            {
                errorPoruka = errorPoruka + $"Nije unesen naziv!\r\n";
            }
            else
            {
                foreach (var u in upit)
                {
                    if (u.Naziv.ToString() == txtBoxNaziv.Text && u.Id != this.IdSelektiraneUloge)
                    {
                        errorPoruka = errorPoruka + $"Već postoji uloga sa ovim nazivom!\r\n";
                    }
                }
            }

            return errorPoruka;
        }
    }
}
