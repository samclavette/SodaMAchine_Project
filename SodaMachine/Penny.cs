using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class Penny : Coin
    {
        private readonly double value = 0.01;
        public Penny()
        {
            name = "Penny";
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
