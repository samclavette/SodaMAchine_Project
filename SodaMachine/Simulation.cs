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

        public Can PullSodaFromMachine()
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
                return PullSodaFromMachine();
            }
            sodaMachine.inventory.Remove(can);
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

        public void MakeChange()
        {
            double coinsInHandTotal2 = DetermineCoinsInHandValue();
            Can can = PullSodaFromMachine();
            double changeDue = coinsInHandTotal2 - can.Cost;
            if (changeDue > .25)

        }
        public void CustomerBuysSoda()
        {
            Can can = PullSodaFromMachine();
            AddCoinsInHandToList();
            double coinTotal = DetermineCoinsInHandValue();
            if (coinTotal == can.Cost)
            {
                customer.backpack.AddCanToBackpack(can);
                sodaMachine.register.Add(coinsInHand);
            }
            else if (coinTotal > can.Cost)
            {
                customer.backpack.AddCanToBackpack(can);
                sodaMachine.register.Add(coinsInHand);
            }
            else if (coinTotal < can.Cost)
            {
                sodaMachine.inventory.Add(can);
                customer.wallet.Add(coinsInHand);
            }


        }

        public void AskCustomerForPayment()
        {

        }
    }
}
