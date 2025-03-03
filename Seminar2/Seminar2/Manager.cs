using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    class Manager:Angajat
    {
        public Manager(int marca,string nume,string functie) : base(marca, nume, functie)
        {

        }
        public List<Angajat> subordonati { get; } = new List<Angajat>();

        public void adaugasubordonat(Angajat angajat)
        {
            subordonati.Add(angajat);
            angajat.sef = this;
        }
        public void stergesubordonat(Angajat angajat)
        {
            subordonati.Remove(angajat);
            angajat.sef = null;
        }
        public override string ToString()
        {
            return base.ToString() + $"[{subordonati.Count} subordonati]";
        }
    }
}
