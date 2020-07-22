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
        private readonly double value = 0.10;

        public Dime()
        {
            name = "Dime";
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
