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
        RootBeer rootBeer;
        OrangeSoda orangeSoda;
        Cola cola;

        public SodaMachine()
        {
            StockRegister();
            StockInventory();
        }
        private void StockInventory()
        {
            StockRootBeer();
            StockOrangeSoda();
            StockCola();
        }

        private void StockRootBeer()
        {
            for (int i = 0; i < 12; i++)
            {
                inventory.Add(rootBeer);
            }
        }

        private void StockOrangeSoda()
        {
            for (int i = 0; i < 10; i++)
            {
                inventory.Add(orangeSoda);
            }
        }

        private void StockCola()
        {
            for (int i = 0; i < 8; i++)
            {
                inventory.Add(cola);
            }
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
            for (int i = 0; i < 50; i++)
            {
                register.Add(penny);
            }
        }

        private void StockNickels()
        {
            for (int i = 0; i < 20; i++)
            {
                register.Add(nickel);
            }
        }

        private void StockDimes()
        {
            for (int i = 0; i < 10; i++)
            {
                register.Add(dime);
            }
        }

        private void StockQuarters()
        {
            for (int i = 0; i < 20; i++)
            {
                register.Add(quarter);
            }
            
        }


    }
}
