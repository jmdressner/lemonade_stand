using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customers
    {
        public int people;
        public double customers;
        public int unservedCustomers;
        public int servedCustomers;

        public Customers()
        {
            this.people = 100;
            this.customers = 0;
            this.unservedCustomers = 0;
            this.servedCustomers = 0;
        }
      
        public void DisplayCustomers()
        {
            Console.WriteLine("Today "+ people +" people walked by your lemonade stand and you had "+ customers +" possible customers.");
            Console.ReadLine();
        }

        public void LemonadeConsumed(Day day, Player player1)
        {
            for (int i = 1; i <= customers; i++)
            {
                if (player1.inventory.cup.quantity > 0 && player1.inventory.lemon.quantity > 0 && player1.inventory.sugar.quantity > 0 && player1.inventory.ice.quantity > 0 && i <= player1.recipe.possibleCupsOfLemonade)
                {
                    player1.inventory.cup.SubtractFromInventory(player1.inventory.cup.quantityForRecipe);
                    player1.inventory.lemon.SubtractFromInventory(player1.inventory.lemon.quantityForRecipe);
                    player1.inventory.sugar.SubtractFromInventory(player1.inventory.sugar.quantityForRecipe);
                    player1.inventory.ice.SubtractFromInventory(player1.inventory.ice.quantityForRecipe);
                }
                else
                {
                    unservedCustomers = Convert.ToInt32(customers) - (i - 1);
                    Console.WriteLine("You ran out of lemonade. You were only able to serve "+ servedCustomers +" customers.");
                    break;
                }
                unservedCustomers = 0;
                servedCustomers = i;
            }
            DisplayCustomers();
        }
    }
}
