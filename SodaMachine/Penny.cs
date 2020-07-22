using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class Penny : Coin
    {
        
        public Penny()
        {
            name = "Penny";
            value = .01;
        }

        public double Value
        {
            get
            {
                return value;
            }
        }
    }
}
