using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_Suplimentara
{
    internal class Cos
    {
       public List<Produs> produseCos { get; set; }
       public int nrProduseCos { get { return produseCos.Count; } }
        public Produs getProdus(int index)
        {
            return produseCos[index];
        }
        public event Action<Produs> ProdusAdaugat;
        public event Action<Produs> ProdusSters;
        public void adaugaProdus(Produs produs)
        {
            produseCos.Add(produs);
            ProdusAdaugat?.Invoke(produs);
        }
        public Cos()
        {
            produseCos = new List<Produs>();
        }
        public decimal ValoareTotala { get { return produseCos.Sum(p=> p.pretProdus * p.cantitateProdus); } }

        public void stergeProdus(Produs produs)
        {
            produseCos.Remove(produs);
            ProdusSters?.Invoke(produs);
        }



    }
}
