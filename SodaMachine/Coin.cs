﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public abstract class Coin
    {
        protected string name;
        public double Value { get { return value; } }
        protected double value;

    }
}
