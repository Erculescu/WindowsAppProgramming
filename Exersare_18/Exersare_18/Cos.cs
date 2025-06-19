using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_18
{
    internal class Cos
    {
        public List<Produse> produse;

        public Cos()
        {
            produse = new List<Produse>();
        }

        public decimal ValoareCos
        {
            get { decimal valoare = 0;
            foreach(var p in produse)
                {
                    valoare += p.getPret();
                }
                return valoare;
            }
        }
        public void adaugaProdus(Produse produs)
        {
            produse.Add(produs);
        }

    }
}
