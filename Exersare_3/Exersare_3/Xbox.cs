using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_3
{
    //internal enum Exclusive
    //{
    //    Forza,Halo,GearsOfWar
    //}
   internal class Xbox:IConsole
    {
        public string denumire { get; set; }
        public float pret { get; set; }
        public string vanzari { get; set; }
        public float memorie { get; set; }
        public Exclusive exclusive { get; set; }
        public Xbox(string denumire,float pret,string vanzari,float memorie,Exclusive exclusive)
        {
            this.denumire = denumire;
            this.pret = pret;
            this.vanzari = vanzari;
            this.memorie = memorie;
            this.exclusive = exclusive;
        }
        public void afisarememorie()
        {
            Console.WriteLine($"Consola microsoft {denumire} are {memorie} MB memorie");
        }
        public void calculvenit()
        {if (float.TryParse(vanzari, out float vanzariFloat))
            {
                Console.WriteLine($"Venitul total este de {pret * vanzariFloat} RON");
            }
            else { 
                Console.WriteLine("Nu s-a putut calcula venitul"); 
            }

            }
        public override string ToString()
        {
            return $"Consola microsoft {denumire} costa {pret} RON, s-au vandut {vanzari} unitati, are {memorie} MB memorie si are jocurile exclusive {exclusive}";
        }

    }
}
