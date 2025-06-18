using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_17
{
    public class Traseu
    {
        public List<Locatie> locatii = new List<Locatie>();
        public Locatie this[int index]
        {
            get => locatii[index];
            set => locatii[index] = value;
        }
        public int NumarLocatii { get
            {
                return locatii.Count;
            } }
        public decimal LungimeTrase
        {
            get
            {
                decimal lungime = 0;
                for(int i = 0; i < locatii.Count - 1; i++)
                {
                    var loc1 = locatii[i];
                    var loc2 = locatii[i + 1];
                    var distanta = Math.Sqrt(Math.Pow((double)(loc2.Latitudine - loc1.Latitudine), 2) + Math.Pow((double)(loc2.Longitudine - loc1.Longitudine), 2));
                    lungime += (decimal)distanta;
                }
                return lungime;
                {

                }
            }
        }
        public void AdaugaLocatie(Locatie locatie)
        {
            int flag = 0;
            foreach (var loc in locatii)
            {
                if (loc.denumire == locatie.denumire)
                {
                    flag = 1; break;
                }
            }
            if (flag == 0)
            {
                locatii.Add(locatie);
            }
        }
    }
}
