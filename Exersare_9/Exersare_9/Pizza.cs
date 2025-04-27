using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_9
{
    public enum Tip
    {
        Diavola,
Quattro_Stagioni,
Carnivora,
Hawaian
    }
   
    public class Pizza
    {
        public String Adresa { get; set; }
        public Tip tip { get; set; }
        public Boolean areSos { get; set; } 
        public Pizza(string adresa, Tip tip, bool areSos)
        {
            Adresa = adresa;
            this.tip = tip;
            this.areSos = areSos;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
