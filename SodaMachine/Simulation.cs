using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Simulation
    {
        public SodaMachine sodaMachine;
        public Customer customer;
        public List<Coin> coinsInHand;

        public Simulation()
        {
            sodaMachine = new SodaMachine();
            customer = new Customer();
            coinsInHand = new List<Coin>();
        }

        //public bool CheckSodaTypeAvailability()
        //{
        //    string sodaCanChosen = customer.ChooseSodaCan();
        //    for (int i = 0; i < sodaMachine.inventory.Count; i++)
        //    {
        //        if (sodaCanChosen == sodaMachine.inventory[i].name)
        //        {
        //            return true;
        //        }      
        //    }
        //    return false;
        //}

        public Can ChooseSodaFromMachine()
        {
            Can can = null;
            string sodaCanChosen = customer.ChooseSodaCan();

            for (int i = 0; i < sodaMachine.inventory.Count; i++)
            {
                if (sodaCanChosen == sodaMachine.inventory[i].name)
                {
                    can = sodaMachine.inventory[i];
                    break;
                }
            }
            if (can == null)
            {
                UserInterface.OutOfInventory(sodaCanChosen);
                return ChooseSodaFromMachine();
            }
            return can;
        }

        public void AddCoinsInHandToList()
        {
            Coin coinChosen = customer.ChooseCoins();
            coinsInHand.Add(coinChosen);
            bool addMoreCoins = UserInterface.ContinueEnteringCoins();
            if (addMoreCoins == true)
            {
                AddCoinsInHandToList();
            }
        }

        public double DetermineCoinsInHandValue()
        {
            double coinsInHandTotal = 0;

            for (int i = 0; i < coinsInHand.Count; i++)
            {
                coinsInHandTotal += coinsInHand[i].Value;
            }
            return coinsInHandTotal;
        }

        public Coin FindCoinWithValue(double value)
        {
            Coin coin = null;
            foreach (Coin item in sodaMachine.register)
            {
                if (item.Value == value)
                {
                    coin = item;
                    break;
                }
            }
            return coin;
        }
        public void MakeChange(Can can)
        {
            double coinsInHandTotal2 = DetermineCoinsInHandValue();
            double changeDue = coinsInHandTotal2 - can.Cost;

            while (changeDue >= .25)
            {
                Coin coin = FindCoinWithValue(.25);
                if (coin == null)
                {
                    break;
                }
                changeDue -= .25;
                sodaMachine.register.Remove(coin);
            }
            while (changeDue >= .10)
            {
                Coin coin = FindCoinWithValue(.10);
                if (coin == null)
                {
                    break;
                }
                changeDue -= .10;
                sodaMachine.register.Remove(coin);
            }
            while (changeDue >= .05)
            {
                Coin coin = FindCoinWithValue(.05);
                if (coin == null)
                {
                    break;
                }
                changeDue -= .05;
                sodaMachine.register.Remove(coin);
            }
            while (changeDue - .01 > 0)
            {
                Coin coin = FindCoinWithValue(.01);
                if (coin == null)
                {
                    break;
                }
                changeDue -= .01;
                sodaMachine.register.Remove(coin);
            }

        }
    public void CustomerBuysSoda()
{
    Can can = ChooseSodaFromMachine();
    AddCoinsInHandToList();
    double coinTotal = DetermineCoinsInHandValue();
    if (coinTotal == can.Cost)
    {
        customer.backpack.AddCanToBackpack(can);
        sodaMachine.register.AddRange(coinsInHand);
    }
    else if (coinTotal > can.Cost)
    {
        customer.backpack.AddCanToBackpack(can);
        sodaMachine.register.Add(coinsInHand);
        MakeChange(can);
    }
    else if (coinTotal < can.Cost)
    {
        sodaMachine.inventory.Add(can);
        customer.wallet.Add(coinsInHand);
    }
    sodaMachine.inventory.Remove(can);


}

public void AskCustomerForPayment()
{

}
    }
}
