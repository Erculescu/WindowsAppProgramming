using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_13
{
    internal class Bicicleta
    {
        private readonly int cod;
        private static int contor = 0;
        public string denumireStatie { get; set; }
        public int kmParcursi { get; set; }

        public Bicicleta(string denumire, int kmParcursi)
        {
           this.cod = ++contor;
            this.denumireStatie = denumire;
            this.kmParcursi = kmParcursi;
        }
        public int getcod()
        {
            return this.cod;
        }

        public Bicicleta()
        {
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
