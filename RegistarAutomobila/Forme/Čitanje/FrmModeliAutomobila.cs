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
        public FrmModeliAutomobila()
        {
            InitializeComponent();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGlavniIzbornik formaGlavniIzbornik = new FrmGlavniIzbornik();
            formaGlavniIzbornik.ShowDialog();
            this.Close();
        }
    }
}
