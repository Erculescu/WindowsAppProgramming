using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_20
{
    internal class Produs:IComparable<Produs>, INotifyPropertyChanged
    {
        private string _denumire;
        public string denumire { get=>_denumire; set
            {
                if (_denumire != value)
                {
                    _denumire = value;
                    OnPropertyChanged(nameof(denumire));
                }
            }
        }
        public decimal pret { get; set; }
        public int cantitate { get; set; }
        public int CompareTo(Produs other)
        {
            if (other == null) return 1;
            return this.denumire.CompareTo(other.denumire);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Produs(string denumire, decimal pret, int cantitate)
        {
            this.denumire = denumire;
            this.pret = pret;
            this.cantitate = cantitate;
        }

        public override string? ToString()
        {
            return denumire+","+pret+","+cantitate;
        }
    }
}
