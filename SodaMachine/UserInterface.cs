using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    static class UserInterface
    {
        public static string ChooseSodaCan()
        {
            string userInput = "";

            while (!userInput.Equals("cola") && !userInput.Equals("orangesoda") && !userInput.Equals("rootbeer"))
            {
                Console.WriteLine("Please choose a soda:\ncola\norangesoda\nrootbeer");
                userInput = Console.ReadLine();     
            }
            return userInput;

            //int userInputToInt = Convert.ToInt32(userInput);
            //if (userInputToInt == 1)
            //{
            //    return Cola;
            //}
            //else if (userInputToInt == 2)
            //{
            //    return OrangeSoda;
            //}
            //else if (userInputToInt == 3)
            //{
            //    return RootBeer;
            //}

        }

        public static string ChooseCoinPayment()
        {
            string userInput = "";

            while (!userInput.Equals("quarter") && !userInput.Equals("dime") && !userInput.Equals("nickel") && !userInput.Equals("penny"))
            {
                Console.WriteLine("Please choose coin to enter:\nquarter\ndime\nnickel\npenny");
                userInput = Console.ReadLine();
            }

            return userInput;
        } 

        
    }
}
