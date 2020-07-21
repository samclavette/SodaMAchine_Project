using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachine
    {
        public List<Can> inventory;
        public List<Coin> register;
        Quarter quarter;
        Dime dime;
        Nickel nickel;
        Penny penny;

        public SodaMachine()
        {
            StockRegister();
            register.Add(quarter);
            register.Add(dime);
            register.Add(nickel);
            register.Add(penny);
        }

        private void StockRegister()
        {
            StockPennies();
            StockNickels();
            StockDimes();
            StockQuarters();
        }

        private void StockPennies()
        {

        }

        private void StockNickels()
        {

        }

        private void StockDimes()
        {

        }

        private void StockQuarters()
        {

        }


    }
}
