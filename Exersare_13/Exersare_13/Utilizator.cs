using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_13
{
    internal class Utilizator
    {
        public string nume { get; set; }
        public int codBici { get; set; }
        public int durata { get; set; }

        public Utilizator(string nume, int codBici, int durata)
        {
            this.nume = nume;
            this.codBici = codBici;
            this.durata = durata;
        }

        public Utilizator()
        {
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
