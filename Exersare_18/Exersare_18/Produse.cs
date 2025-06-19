using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_18
{
    internal class Produse
    {
        public int cod;
        public string denumire;
        private decimal pret;
        public decimal getPret()
        {
            return pret;
        }
        public void setPret(decimal value)
        {
            if (value > 0)
            {
                pret = value;
            }
        }

        public Produse(int cod, string denumire, decimal pret)
        {
            this.cod = cod;
            this.denumire = denumire;
            this.pret = pret;
        }

        public override string? ToString()
        {
            return this.cod+","+this.denumire+","+this.pret;
        }

        public Produse()
        {
        }
    }
}
