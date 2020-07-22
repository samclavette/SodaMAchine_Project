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

        public Wallet()
        {
            card = new Card();
            coins = new List<Coin>();
            AddCoinsToWallet();
        }

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
                Penny penny = new Penny();
                coins.Add(penny);
            }
        }

        public void AddNickelsToWallet()
        {
            for (int i = 0; i < 16; i++)
            {
                Nickel nickel = new Nickel();
                coins.Add(nickel);
            }
        }

        public void AddDimesToWallet()
        {
            for (int i = 0; i < 10; i++)
            {
                Dime dime = new Dime();
                coins.Add(dime);
            }
        }

        public void AddQuartersToWallet()
        {
            for (int i = 0; i < 12; i++)
            {
                Quarter quarter = new Quarter();
                coins.Add(quarter);
            }
        }
    }
}
