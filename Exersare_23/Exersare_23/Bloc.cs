using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_23
{
    internal class Bloc
    {
        public string adresa { get; set; }
        public List<Apartament> apartamente { get; set; }
        public decimal totalIntretinere
        {
            get
            {
                decimal total = 0;
                foreach(var apt in apartamente)
                {
                    total += apt.intretinere;
                }
                return total;
            }
        }
        public int suprafataTotala
        {
            get { int total = 0;
            foreach(var apt in apartamente)
                {
                    total += apt.suprafata;
                }
                return total;
            }
        }

        public Bloc(string adresa)
        {
            this.adresa = adresa;
            this.apartamente = new List<Apartament>();
        }
        public void adaugaApartament(Apartament apartament)
        {
            apartamente.Add(apartament);
        }
    }
}
