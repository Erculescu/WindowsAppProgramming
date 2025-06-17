using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_10
{
    internal class Camera:IComparable<Camera>
    {
        private static int CodCamera;
        private static int contor=0;
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
        public Camera(string denumire,decimal pret,int cantitate)
        {
            this.denumire = denumire;
            this.pret = pret;
            this.cantitate = cantitate;
            CodCamera = ++contor;
        }
        public int getCodCamera()
        {
            return CodCamera;
        }
    }
}
