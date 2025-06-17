using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_10
{
    internal class Stoc
    {
        public List<Camera> camere { get; set; }
        public decimal ValoareTotala
        {
            get
            {
                return camere.Sum( c => c.pret * c.cantitate); 
            }
        }
        public int cantitateTotala
        {
            get { return camere.Sum(c => c.cantitate); }
        }
        public void adaugaCamera(Camera camera)
        {
            this.camere.Add(camera);
            
        }

    }
}
