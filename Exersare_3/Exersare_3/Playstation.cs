using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_3
{
    //internal enum Exclusive
    //{
    //    GodofWar,RachetAndClank,Spiderman
    //}
    internal class Playstation: IConsole
    {
        public string denumire { get; set; }
        public float pret { get; set; }
        public string vanzari { get; set; }
        
        public float memorie { get; set; }

        public Exclusive exclusive { get; set; }
        public Playstation(string denumire, float pret, string vanzari,float memorie,Exclusive exclusive)
        {
            this.denumire = denumire;
            this.pret = pret;
            this.vanzari = vanzari;
            this.memorie = memorie;
            this.exclusive = exclusive;
        }

        public void afisarememorie()
        {
            Console.WriteLine($"Consola sony {denumire} are {memorie} MB memorie");
        }
        public override String ToString()
        {
            return $"Consola sony {denumire} costa {pret} RON, s-au vandut {vanzari} unitati, are {memorie} MB memorie si are jocurile exclusive {exclusive}";
        }

    }
}
