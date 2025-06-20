using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_24
{
    internal class Magazin
    {
        public string denumire;
        public List<Telefon> telefoane;
        public decimal stoc
        {
            get { decimal suma = 0;
            foreach(var telefon in telefoane)
                {
                    suma += telefon.pret;
                }
                return suma;
            }
        }

        public Magazin(string denumire)
        {
            this.denumire = denumire;
            this.telefoane = new List<Telefon>();
        }
        public void adaugaTelefon(Telefon telefon)
        {
            telefoane.Add(telefon);
        }

        public override string? ToString()
        {
            return denumire+","+stoc+","+string.Join(",",telefoane);
        }
    }
}
