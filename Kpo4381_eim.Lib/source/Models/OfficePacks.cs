using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.eim.Lib
{    
    public class OfficePacks
    {
        public OfficePacks()
        {
            name = "";
            vendor = "";
            composition = 0;
            price = 0;

        }
        public string name { get; set; }
        public string vendor { get; set; }
        public int composition { get; set; }
        public int price { get; set; }


    }
}
