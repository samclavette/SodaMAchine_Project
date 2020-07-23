using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Customer
    {
        public Wallet wallet;
        public Backpack backpack;

        public Customer()
        {
            wallet = new Wallet();
            backpack = new Backpack();
        }

        public Coin ChooseCoins()
        {
            Coin coin = null;
            string coinChosen = UserInterface.ChooseCoinPayment();
            
            for (int i = 0; i < wallet.coins.Count; i++)
            {
                if (coinChosen == wallet.coins[i].name)
                {
                    coin = wallet.coins[i];
                    break;
                }
                
            }
            if (coin == null)
            {
                return ChooseCoins();
            }
            wallet.coins.Remove(coin);
            return coin;
        }

        public void ChooseSodaCan()
        {
            string canChosen = UserInterface.ChooseSodaCan();
        }
    }
}
