using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public abstract class Can
    {
        protected string name;
        public double Cost { get { return cost; } }
        protected double cost;
    }
}
