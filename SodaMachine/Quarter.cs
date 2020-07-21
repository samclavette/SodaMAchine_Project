using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class Quarter : Coin
    {
        public Quarter()
        { 
            name = "Quarter";
            Value = 0.25;
        }
    }
}
