using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_3
{
    class persoana : INotifyPropertyChanged
    {
        private int varsta; //pt asta am dat click dreapta pe Varsta -> quick actions -> nuj

        public string Nume { get; set; }
        public int Varsta
        {
            get => varsta;
            set
            {
                if (varsta != value)
                {
                    varsta = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Varsta)));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        override public string ToString()
        {
            return Nume + " -- " + Varsta + " ani";
        }
    }
}