using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_7
{
   public class Persoana
    {
       public string Nume { get; init; }
        public int Varsta { get; init; }
        public override string ToString()
        {
            return $"{Nume} ({Varsta} ani)";
        }
    }
}
