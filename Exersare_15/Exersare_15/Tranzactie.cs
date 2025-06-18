using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_15
{
    internal class Tranzactie
    {
        private readonly int id;
        private string IBAN { get; set; }
        private string detalii { get; set; }
        private double suma { get; set; }
        private DateTime dataTranzactie { get; set; }

        public Tranzactie(int id, string iBAN, string detalii, double suma, DateTime dataTranzactie)
        {
            this.id = id;
            IBAN = iBAN;
            this.detalii = detalii;
            this.suma = suma;
            this.dataTranzactie = dataTranzactie;
        }
        public int ID => id;
        public Tranzactie()
        {
        }

        public override string? ToString()
        {
            return id + "," + IBAN + "," + detalii + "," + suma + "," + dataTranzactie.ToLongDateString();
        }
    }
}
