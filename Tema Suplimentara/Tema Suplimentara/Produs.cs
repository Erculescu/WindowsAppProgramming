using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_Suplimentara
{
    public class Produs:INotifyPropertyChanged,IComparable<Produs>
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private static int counter = 0;
        private static int codProdus;
        private string denumireProdus;
        public string DenumireProdus
        {
            get { return denumireProdus; } set
            {
                if (denumireProdus != value)
                {
                    denumireProdus = value;
                    OnProperyChanged(nameof(DenumireProdus));
                }
            }
        }
        public decimal pretProdus { get; set; }
        public int cantitateProdus { get; set; }
       public  Produs(string denumire, decimal pret, int cantitate)
        {
            codProdus = ++counter;
            denumireProdus = denumire;
            pretProdus = pret;
            cantitateProdus = cantitate;
        }
        public int getcodProdus()
        {
            return codProdus;
        }
        public int CompareTo(Produs other) {
            if (other == null) return 1;
            return denumireProdus.CompareTo(other.denumireProdus);
        }
        protected void OnProperyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
