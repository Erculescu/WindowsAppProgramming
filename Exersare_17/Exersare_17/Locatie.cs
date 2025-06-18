using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_17
{
    public class Locatie
    {
        public decimal Latitudine { get; set; }
        public decimal Longitudine { get; set; }
        public string denumire { get; set; }

        public Locatie(decimal latitudine, decimal longitudine, string denumire)
        {
            Latitudine = latitudine;
            Longitudine = longitudine;
            this.denumire = denumire;
        }

        public override string? ToString()
        {
            return Latitudine + "," +Longitudine+","+denumire ;
        }
    }
}
