using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_12
{
    internal class Vehicul:ICloneable,IComparable<Vehicul>
    {
        public string serie { get;set; }
        public string marca { get; set; }
        public string model { get; set; }
        public int anFabricatie { get; set; }
        public decimal pret { get; set; }

        public Vehicul(string serie, string marca, string model, int anFabricatie, decimal pret)
        {
            this.serie = serie;
            this.marca = marca;
            this.model = model;
            this.anFabricatie = anFabricatie;
            this.pret = pret;
        }

        public Vehicul(string serie, string marca, string model, decimal pret)
        {
            this.serie = serie;
            this.marca = marca;
            this.model = model;
            this.pret = pret;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
        public int CompareTo(Vehicul other)
        {
            if (other == null) return 1;
            return this.serie.CompareTo(other.serie);
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
