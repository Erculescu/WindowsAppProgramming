using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_23
{
    internal class Apartament:IComparable<Apartament>
    {
        public int numarApt { get; set; }
        public string proprietar { get; set; }
        public int suprafata { get; set; }
        public decimal intretinere { get; set; }

        public Apartament(int numarApt, string proprietar, int suprafata, decimal intretinere)
        {
            this.numarApt = numarApt;
            this.proprietar = proprietar;
            this.suprafata = suprafata;
            this.intretinere = intretinere;
        }
        public int CompareTo(Apartament other)
        {
            if (other == null) return 1;
            return this.numarApt.CompareTo(other.numarApt);
        }

    }
}
