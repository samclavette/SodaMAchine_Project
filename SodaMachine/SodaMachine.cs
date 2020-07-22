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

        public SodaMachine()
        {
            inventory = new List<Can>();
            register = new List<Coin>();
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
                RootBeer rootBeer = new RootBeer();
                inventory.Add(rootBeer);
            }
        }

        private void StockOrangeSoda()
        {
            for (int i = 0; i < 10; i++)
            {
                OrangeSoda orangeSoda = new OrangeSoda();
                inventory.Add(orangeSoda);
            }
        }

        private void StockCola()
        {
            for (int i = 0; i < 8; i++)
            {
                Cola cola = new Cola();
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
                Penny penny = new Penny();
                register.Add(penny);
            }
        }

        private void StockNickels()
        {
            for (int i = 0; i < 20; i++)
            {
                Nickel nickel = new Nickel();
                register.Add(nickel);
            }
        }

        private void StockDimes()
        {
            for (int i = 0; i < 10; i++)
            {
                Dime dime = new Dime();
                register.Add(dime);
            }
        }

        private void StockQuarters()
        {
            for (int i = 0; i < 20; i++)
            {
                Quarter quarter = new Quarter();
                register.Add(quarter);
            }
            
        }


    }
}
