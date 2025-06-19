using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_20
{
    internal class CosCumparaturi
    {
        public List<Produs> produse;

        public CosCumparaturi()
        {
            produse = new List<Produs>();
        }

        public int nrProduse { get { return produse.Count(); } }
        public Produs this[int index]
        {
            get { return produse[index]; }
            set
            {
                if (index >= 0 && index < produse.Count)
                {
                    produse[index] = value;
                }
            }
        }
        public float valoareTotala
        {
            get
            {
                float total = 0;
                foreach(Produs p in produse)
                {
                    total += (float)(p.pret * p.cantitate);
                }
                return total;
            }
        }

        public void AdaugaProdus(Produs produs)
        {
            produse.Add(produs);
        }
        public void StergeProdus(Produs p)
        {
            produse.Remove(p);
        }
        public void ModificaProdus(int index,Produs produsNou)
        {
            produse[index] = produsNou;
        }

        public CosCumparaturi(List<Produs> produse)
        {
            this.produse = produse;
        }

    }
}
