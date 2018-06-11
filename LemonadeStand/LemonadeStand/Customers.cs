using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customers
    {
        // member variables
        public int people;
        public double customers;
        public int i;

        public Customers()
        {
            this.people = 100;
            this.customers = 0;
            this.i = 1;
        }
        // member methods

        

        public void DisplayCustomers()
        {
            Console.WriteLine("Today "+ people +" people walked by your lemonade stand and you had "+ customers +" customers.");
            Console.ReadLine();
        }

        public void LemonadeConsumed(Day day, Player player1)
        {
            for (int i = 1; i <= customers; i++)
            {
                if (player1.inventory.cup.quantity > 0 && player1.inventory.lemon.quantity > 0 && player1.inventory.sugar.quantity > 0 && player1.inventory.ice.quantity > 0)
                {
                    player1.inventory.cup.SubtractFromInventory(player1.inventory.cup.quantityForRecipe);
                    player1.inventory.lemon.SubtractFromInventory(player1.inventory.lemon.quantityForRecipe);
                    player1.inventory.sugar.SubtractFromInventory(player1.inventory.sugar.quantityForRecipe);
                    player1.inventory.ice.SubtractFromInventory(player1.inventory.ice.quantityForRecipe);
                }
                else
                {
                    DisplayCustomers();
                }
            }
            DisplayCustomers();
        }
    }
}
