using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_10
{
    internal class Camera:IComparable<Camera>
    {
        public static int CodCamera { get;set; }
        public string denumire { get; set; }
        public decimal pret { get; set; }
        public int cantitate { get; set; }

        public int CompareTo(Camera other)
        {
            if (other==null)
            {
                return 1;   
            }
            return this.denumire.CompareTo(other.denumire);
        }
    }
}
