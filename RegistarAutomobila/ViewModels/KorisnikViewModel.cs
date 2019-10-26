using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistarAutomobila.ViewModels
{
    public class KorisnikViewModel
    {
        public int Id { get; set; }
        public string Korime { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Lozinka { get; set; }
        public string NazivUloge { get; set; }
    }
}
