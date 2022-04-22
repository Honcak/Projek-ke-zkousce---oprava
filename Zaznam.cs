using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{

    public class Zaznam
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Mobil { get; set; }
        public string Vek { get; set; }

        public Zaznam(string jmeno, string prijmeni, string mobil, string vek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Mobil = mobil;
            Vek = vek;
        }
        public Zaznam()
        {

        }
    }

}
