using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Wallet
    {
        public Card card;
        public List<Coin> coins;
        Quarter quarter;
        Dime dime;
        Nickel nickel;
        Penny penny;

        public void AddCoinsToWallet()
        {
            AddPenniesToWallet();
            AddNickelsToWallet();
            AddDimesToWallet();
            AddQuartersToWallet();
        }

        public void AddPenniesToWallet()
        {
            for (int i = 0; i < 20; i++)
            {
                coins.Add(penny);
            }
        }

        public void AddNickelsToWallet()
        {
            for (int i = 0; i < 16; i++)
            {
                coins.Add(nickel);
            }
        }

        public void AddDimesToWallet()
        {
            for (int i = 0; i < 10; i++)
            {
                coins.Add(dime);
            }
        }

        public void AddQuartersToWallet()
        {
            for (int i = 0; i < 12; i++)
            {
                coins.Add(quarter);
            }
        }
    }
}
