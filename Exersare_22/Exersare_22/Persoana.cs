using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_22
{
    internal class Persoana
    {
        public int id { get; set; }
        public string nume { get; set; }
        public decimal salariu { get; set; }

        public Persoana(int id, string nume, decimal salariu)
        {
            this.id = id;
            this.nume = nume;
            this.salariu = salariu;
        }

        public override string? ToString()
        {
            return id+","+nume+","+salariu;
        }
    }
}
