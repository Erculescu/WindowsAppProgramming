using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersare_3
{
    internal interface IConsole
    {
        void afisarememorie();
        string denumire { get; set; }
        float pret { get; set; }
        string vanzari { get; set; }
        float memorie { get; set; }

    }

}
