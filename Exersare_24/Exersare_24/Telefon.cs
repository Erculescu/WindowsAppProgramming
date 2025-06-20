using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_24
{
    internal class Telefon:IComparable<Telefon>
    {
        public int CompareTo(Telefon other)
        {
            if (other == null) return 1;
            return this.imei.CompareTo(other.imei);
        }
        private string _imei;
        public  string imei { get { return _imei; } set { _imei = value; } }
        public string denumire;
        public decimal pret;

        public Telefon(string imei, string denumire, decimal pret)
        {
            this.imei = imei;
            this.denumire = denumire;
            this.pret = pret;
        }

        public override string? ToString()
        {
            return imei+","+denumire+","+pret;
        }
    }
}
