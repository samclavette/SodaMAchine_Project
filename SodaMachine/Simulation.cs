﻿using System;
using System.Collections.Generic;
using System.Data.Odbc;
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
        public bool CheckInventory(Can can)
        {
            for (int i = 0; i < sodaMachine.inventory.Count; i++)
            {
                if (can.name == sodaMachine.inventory[i].name)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckRegister()
        {
            for (int i = 0; i < coinsInHand.Count; i++)
            {
                Coin coin = coinsInHand[i];
            }
            for (int i = 0; i < sodaMachine.register.Count; i++)
            {
                if (coin.name == sodaMachine.register[i].name)
                {
                    return true;
                }
            }
            return false;

        }

        public void ReturnMoney()
        {
            customer.wallet.coins.AddRange(coinsInHand);
        }

        public void CustomerBuysSoda()
        {
        Can can = ChooseSodaFromMachine();
        AddCoinsInHandToList();
        double coinTotal = DetermineCoinsInHandValue();
        bool inventoryStocked = CheckInventory(can);

        // I think I have everything I need (maybe one more method). I just need a way to check the coinsInHand list against 
        // the register of the soda machine to make sure it has enough to despense. Then I can use that bool result to cycle 
        // through some more loops in the logic below.

        if (inventoryStocked == true)
            {
                if (coinTotal == can.Cost)
                {
                    customer.backpack.AddCanToBackpack(can);
                    sodaMachine.register.AddRange(coinsInHand);
                    sodaMachine.inventory.Remove(can);
                }
                else if (coinTotal > can.Cost)
                {
                     customer.backpack.AddCanToBackpack(can);
                     sodaMachine.register.AddRange(coinsInHand);
                     sodaMachine.inventory.Remove(can);
                     MakeChange(can);
                }
                
            }

        


    }

    }
}
