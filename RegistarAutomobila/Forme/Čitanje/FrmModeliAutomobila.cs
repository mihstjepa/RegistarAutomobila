using RegistarAutomobila.Forme.Ažuriranje;
using RegistarAutomobila.Forme.Dodavanje;
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

namespace RegistarAutomobila.Forme
{
    public partial class FrmModeliAutomobila : Form
    {
        DBContext db = new DBContext();

        public FrmModeliAutomobila()
        {
            InitializeComponent();
            AutentikacijaUloge();
            OsvjeziPrikaz();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        private void btnNoviUnos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDodajModel forma = new FrmDodajModel();
            forma.ShowDialog();            
            this.Close();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (dgvSveMarke.SelectedRows.Count == 1)
            {
                this.Hide();
                FrmAzuriranjeModela forma = new FrmAzuriranjeModela(DohvatiSelektiraniModel());
                forma.ShowDialog();                
                this.Close();
            }
            else
            {
                MessageBox.Show("Morate selektirati samo jedan model automobila!");
            }
        }

        /// <summary>
        /// Ako je selektiran red u Data Grid View-u, onda poziva metodu za brisanje selektiranog modela
        /// i osvježava prikaz.
        /// Ako nije selektiran red u Data Grid View-u, onda ispisuje error poruku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObriši_Click(object sender, EventArgs e)
        {
            if (dgvSveMarke.SelectedRows.Count == 1)
            {
                DialogResult poruka = MessageBox.Show($"Sigurno želite obrisati ovaj model automobila?", "Upozorenje!", MessageBoxButtons.YesNo);
                switch (poruka)
                {
                    case DialogResult.Yes:
                        ObrisiModel();
                        MessageBox.Show("Brisanje uspješno");
                        OsvjeziPrikaz();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Morate selektirati samo jedan model automobila!");
            }
        }

        /// <summary>
        /// Popunjava Data Grid View sa view-om na bazu koji ispisuje sve modele, 
        /// njihove marke i korisnike koji su unijeli marku u bazu te postavlja
        /// inicijalnu vrijednost filtera ComboBoxa za pretragu.
        /// </summary>
        private void OsvjeziPrikaz()
        {
            var upit = from model in db.ModelAutomobila 
                       join marka in db.MarkaAutomobila 
                       on model.MarkaAutomobilaId equals marka.Id
                       join korisnik in db.Korisnik 
                       on model.KorisnikId equals korisnik.Id into nazivKorisnika
                       from korisnik in nazivKorisnika.DefaultIfEmpty()
                       select new { model.Id, nazivModela = model.Naziv, model.GodinaProizvodnje, model.SnagaMotora, model.Cijena, nazivMarke = marka.Naziv, korisnik.Korime };
            dgvSveMarke.DataSource = upit.ToList();

            dgvSveMarke.Columns[0].HeaderText = "Šifra";
            dgvSveMarke.Columns[1].HeaderText = "Naziv";
            dgvSveMarke.Columns[2].HeaderText = "Godina proizvodnje";
            dgvSveMarke.Columns[3].HeaderText = "Snaga motora (kWH)";
            dgvSveMarke.Columns[4].HeaderText = "Cijena (kn)";
            dgvSveMarke.Columns[5].HeaderText = "Marka";
            dgvSveMarke.Columns[6].HeaderText = "Unio korisnik";

            comboBoxFilter.SelectedIndex = 0;
        }

        /// <summary>
        /// Dohvaća model automobila selektiran u Data Grid View-u.
        /// </summary>
        /// <returns>Objekt tipa Model Automobila popunjen vrijednostima. 
        /// Vraća "null" ako nije selektiran nijedan red u DataGridView-u.</returns>
        private ModelAutomobila DohvatiSelektiraniModel()
        {
            int _id = (int)dgvSveMarke.SelectedRows[0].Cells[0].Value;
            ModelAutomobila selektiraniModel = db.ModelAutomobila.Find(_id);

            return selektiraniModel;
        }

        /// <summary>
        /// Briše selektiranog korisnika u Data Grid View-u iz baze.
        /// </summary>
        private void ObrisiModel()
        {
            ModelAutomobila selektiraniModel = DohvatiSelektiraniModel();

            db.ModelAutomobila.Attach(selektiraniModel);
            db.ModelAutomobila.Remove(selektiraniModel);
            db.SaveChanges();
        }

        /// <summary>
        /// Poziva metodu za pretragu modela po ključnoj riječi ukoliko je filter odabran.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTrazi_Click(object sender, EventArgs e)
        {
            if (comboBoxFilter.SelectedItem.ToString() != null)
            {
                Trazi(comboBoxFilter.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Morate odabrati filter za pretragu!");
            }
        }

        /// <summary>
        /// Poziva metodu za osvjezavanje DGV-a.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOsvjeziPrikaz_Click(object sender, EventArgs e)
        {
            OsvjeziPrikaz();
        }

        /// <summary>
        /// Ispisuje rezultate pretrage modela u DGV po ključnoj riječi.
        /// </summary>
        /// <param name="odabraniFilter"></param>
        private void Trazi(string odabraniFilter)
        {
            if (odabraniFilter == "Sve" || odabraniFilter == "")
            {
                var upit = from model in db.ModelAutomobila
                           join marka in db.MarkaAutomobila
                           on model.MarkaAutomobilaId equals marka.Id
                           join korisnik in db.Korisnik
                           on model.KorisnikId equals korisnik.Id into nazivKorisnika
                           from korisnik in nazivKorisnika.DefaultIfEmpty()
                           where    model.Naziv.Contains(txtBoxKljucnaRijec.Text)  
                                ||  model.GodinaProizvodnje.ToString().Contains(txtBoxKljucnaRijec.Text)
                                ||  model.SnagaMotora.ToString().Contains(txtBoxKljucnaRijec.Text)
                                ||  model.Cijena.ToString().Contains(txtBoxKljucnaRijec.Text)
                                ||  marka.Naziv.Contains(txtBoxKljucnaRijec.Text)
                                ||  korisnik.Korime.Contains(txtBoxKljucnaRijec.Text)
                           select new { model.Id, nazivModela = model.Naziv, model.GodinaProizvodnje, model.SnagaMotora, model.Cijena, nazivMarke = marka.Naziv, korisnik.Korime };
                dgvSveMarke.DataSource = upit.ToList();
            }
            else if (odabraniFilter == "Naziv")
            {
                var upit = from model in db.ModelAutomobila
                           join marka in db.MarkaAutomobila
                           on model.MarkaAutomobilaId equals marka.Id
                           join korisnik in db.Korisnik
                           on model.KorisnikId equals korisnik.Id into nazivKorisnika
                           from korisnik in nazivKorisnika.DefaultIfEmpty()
                           where model.Naziv.Contains(txtBoxKljucnaRijec.Text)
                           select new { model.Id, nazivModela = model.Naziv, model.GodinaProizvodnje, model.SnagaMotora, model.Cijena, nazivMarke = marka.Naziv, korisnik.Korime };
                dgvSveMarke.DataSource = upit.ToList();
            }
            else if (odabraniFilter == "Godina proizvodnje")
            {
                var upit = from model in db.ModelAutomobila
                           join marka in db.MarkaAutomobila
                           on model.MarkaAutomobilaId equals marka.Id
                           join korisnik in db.Korisnik
                           on model.KorisnikId equals korisnik.Id into nazivKorisnika
                           from korisnik in nazivKorisnika.DefaultIfEmpty()
                           where model.GodinaProizvodnje.ToString().Contains(txtBoxKljucnaRijec.Text)                                
                           select new { model.Id, nazivModela = model.Naziv, model.GodinaProizvodnje, model.SnagaMotora, model.Cijena, nazivMarke = marka.Naziv, korisnik.Korime };
                dgvSveMarke.DataSource = upit.ToList();
            }
            else if (odabraniFilter == "Snaga motora")
            {
                var upit = from model in db.ModelAutomobila
                           join marka in db.MarkaAutomobila
                           on model.MarkaAutomobilaId equals marka.Id
                           join korisnik in db.Korisnik
                           on model.KorisnikId equals korisnik.Id into nazivKorisnika
                           from korisnik in nazivKorisnika.DefaultIfEmpty()
                           where model.SnagaMotora.ToString().Contains(txtBoxKljucnaRijec.Text)
                           select new { model.Id, nazivModela = model.Naziv, model.GodinaProizvodnje, model.SnagaMotora, model.Cijena, nazivMarke = marka.Naziv, korisnik.Korime };
                dgvSveMarke.DataSource = upit.ToList();
            }
            else if (odabraniFilter == "Cijena")
            {
                var upit = from model in db.ModelAutomobila
                           join marka in db.MarkaAutomobila
                           on model.MarkaAutomobilaId equals marka.Id
                           join korisnik in db.Korisnik
                           on model.KorisnikId equals korisnik.Id into nazivKorisnika
                           from korisnik in nazivKorisnika.DefaultIfEmpty()
                           where model.Cijena.ToString().Contains(txtBoxKljucnaRijec.Text)
                           select new { model.Id, nazivModela = model.Naziv, model.GodinaProizvodnje, model.SnagaMotora, model.Cijena, nazivMarke = marka.Naziv, korisnik.Korime };
                dgvSveMarke.DataSource = upit.ToList();
            }
            else if (odabraniFilter == "Marka automobila")
            {
                var upit = from model in db.ModelAutomobila
                           join marka in db.MarkaAutomobila
                           on model.MarkaAutomobilaId equals marka.Id
                           join korisnik in db.Korisnik
                           on model.KorisnikId equals korisnik.Id into nazivKorisnika
                           from korisnik in nazivKorisnika.DefaultIfEmpty()
                           where marka.Naziv.Contains(txtBoxKljucnaRijec.Text)
                           select new { model.Id, nazivModela = model.Naziv, model.GodinaProizvodnje, model.SnagaMotora, model.Cijena, nazivMarke = marka.Naziv, korisnik.Korime };
                dgvSveMarke.DataSource = upit.ToList();
            }
            else if (odabraniFilter == "Korisnik (unio)")
            {
                var upit = from model in db.ModelAutomobila
                           join marka in db.MarkaAutomobila
                           on model.MarkaAutomobilaId equals marka.Id
                           join korisnik in db.Korisnik
                           on model.KorisnikId equals korisnik.Id into nazivKorisnika
                           from korisnik in nazivKorisnika.DefaultIfEmpty()
                           where korisnik.Korime.Contains(txtBoxKljucnaRijec.Text)
                           select new { model.Id, nazivModela = model.Naziv, model.GodinaProizvodnje, model.SnagaMotora, model.Cijena, nazivMarke = marka.Naziv, korisnik.Korime };
                dgvSveMarke.DataSource = upit.ToList();
            }


            dgvSveMarke.Columns[0].HeaderText = "Šifra";
            dgvSveMarke.Columns[1].HeaderText = "Naziv";
            dgvSveMarke.Columns[2].HeaderText = "Godina proizvodnje";
            dgvSveMarke.Columns[3].HeaderText = "Snaga motora (kWH)";
            dgvSveMarke.Columns[4].HeaderText = "Cijena (kn)";
            dgvSveMarke.Columns[5].HeaderText = "Marka";
            dgvSveMarke.Columns[6].HeaderText = "Unio korisnik";
        }

        /// <summary>
        /// Provjerava ulogu logiranog korisnika i sakriva gumbe ovisno o pravima uloge.
        /// </summary>
        private void AutentikacijaUloge()
        {
            if (LoginPodaci.Uloga != 1 && LoginPodaci.Uloga != 2)
            {
                btnAzuriraj.Visible = false;
                btnNoviUnos.Visible = false;
                btnObriši.Visible = false;
            }
        }
    }
}
