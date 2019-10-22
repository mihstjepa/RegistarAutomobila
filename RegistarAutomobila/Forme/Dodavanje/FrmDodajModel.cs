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
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmModeliAutomobila forma = new FrmModeliAutomobila();
            forma.ShowDialog();
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            ModelAutomobila noviModel = new ModelAutomobila();

        }
    }
}
