using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UserInterface
    {

        public static void DisplayInstructions()
        {
            Console.WriteLine("Welcome to Lemonade Stand!\n" +
                "You have 7 days to make as much money as possible, and you’ve decided to open a lemonade stand!\n" +
                "Set your recipe, buy your ingredients, and start selling!\n" +
                "At the beginning of everyday a weather report will be displayed. Pay attention to the temperature and weather condition as that will affect how many customers you will have.\n" +
                "Then choose your recipe and set the price for your lemonade.  Be careful not to charge to much as this will also affect how many customers you will have.\n" +
                "Purchase your ingredients with your starting budget of $25. Don’t try to spend more than that, there is no credit in this game.\n" +
                "At the end of each days you’ll see how much money you made that day and a running total of the profit and loss from that week. Play again, and try to beat your high score!");
            Console.ReadLine();
        }
    }
}
