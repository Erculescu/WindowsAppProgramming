using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_12
{
    internal class Reprezentanta: ICloneable,IComparable<Reprezentanta>
    {
        public string nume { get; set; }
        public string adresa { get; set; }
        public string telefon { get; set; }
        public List<Vehicul> vehicule { get; set; }
        public decimal valoareStoc
        {
            get { return vehicule.Sum(v => v.pret); }
        }

        public Reprezentanta(string nume, string adresa, string telefon)
        {
            this.nume = nume;
            this.adresa = adresa;
            this.telefon = telefon;
            this.vehicule = new List<Vehicul>();
        }

        public Reprezentanta()
        {
        }

        public void AdaugaVehicul(Vehicul vehicul)
        {
            vehicule.Add(vehicul);
        }
        public int CompareTo(Reprezentanta other)
        {
            if (other == null) return 1;
            int compnume=this.nume.CompareTo(other.nume);
            if (compnume != 0)
            {
                return compnume;
            }
            return this.valoareStoc.CompareTo(other.valoareStoc);
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}
