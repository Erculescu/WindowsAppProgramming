using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_11
{
    class Tranzactie
    {
      

        public int CodProdus { get; set; }
        public string Denumire { get; set; }
        public decimal Pret { get; set; }
        public int Cantitate { get; set; }
        public override string ToString()
            => $"{CodProdus} {Denumire} {Pret} {Cantitate}";
        
    }
}
