using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class Dime : Coin
    { 
        public Dime()
        {
            name = "Dime";
            value = 0.10;
        }
    }
}
