using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_7
{
    public class Produs
    {
        public int id { get; set; }
        public string denumire { get; set; }
        public int cantitate { get; set; }
        public double pret { get; set; }
        public double greutate { get; set; }
        public Produs(int id,string denumire,int cantitate,double pret,double greutate)
        {
            this.id = id;
            this.denumire = denumire;
            this.cantitate = cantitate;
            this.pret = pret;
            this.greutate = greutate;
        }
        

    }
}
