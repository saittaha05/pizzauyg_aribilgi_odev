using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzauyg
{
    internal interface Ipizza
    {
        string boyut { get; set; }
        string kenar { get; set; }
        int malzemeadedi { get; set; }
        string malzeme { get; set; }
        bool icecek { get; set; }
        bool tatli { get; set; }
        string siparistutari();

    }
}
