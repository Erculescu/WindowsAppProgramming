using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_14 { 
    public interface ICalculPunctaj
{
    decimal getPunctaj();
}

    internal class Interviu:ICalculPunctaj
    {
        public int id;
        public string candidat;
        public decimal punctaj;
        public DateTime data;
        
        public decimal getPunctaj() { return this.punctaj; }

        public Interviu(int id, string candidat, decimal punctaj)
        {
            this.id = id;
            this.candidat = candidat;
            this.punctaj = punctaj;
            this.data = DateTime.Now;
        }

        public Interviu(int id, string candidat, decimal punctaj, DateTime data) : this(id, candidat, punctaj)
        {
            this.data = data;
        }

        public override string? ToString()
        {
            return  id + "," + candidat + "," + punctaj + "," + data.ToShortDateString();
        }
    }
}
