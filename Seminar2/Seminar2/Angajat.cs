using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    public class Angajat
    {
        public Angajat(int marca,string nume,string functie)
        {
            this.marca = marca;
            this.nume = nume;
            this.functie = functie;
            sef = null;
        }
      public int marca { get; set; }
        public string nume { get; set; }
        public string functie { get; set; }
        public Angajat sef { get; internal set; }

        public override string ToString()
        {
            var sefi = new List<string>();
            var sef = this.sef;
            while (sef != null)
            {
                sefi.Add(sef.nume);
                sef = sef.sef;
            }
            return $"#{marca,-3} {nume} ({functie}" +$",superiori:{string.Join(", ",sefi)})"/* $",{(sef == null ? "-":sef)})"*/;

        }

    }
}
