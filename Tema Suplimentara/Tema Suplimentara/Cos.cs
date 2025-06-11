using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_Suplimentara
{
    internal class Cos
    {
       private List<Produs> produseCos { get; set; }
       public int nrProduseCos { get { return produseCos.Count; } }
        public Produs getProdus(int index)
        {
            return produseCos[index];
        }
        public void adaugaProdus(Produs produs)
        {
            produseCos.Add(produs);
        }
        public decimal ValoareTotala { get { return produseCos.Sum(p=> p.pretProdus * p.cantitateProdus); } }



    }
}
