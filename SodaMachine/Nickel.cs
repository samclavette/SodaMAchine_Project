using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class Nickel : Coin
    {
        private readonly double value = 0.05;
        public Nickel()
        {
            name = "Nickel";
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
