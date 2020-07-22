using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class Quarter : Coin
    {
        private readonly double value = 0.25;
        public Quarter()
        {
            name = "Quarter";
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
