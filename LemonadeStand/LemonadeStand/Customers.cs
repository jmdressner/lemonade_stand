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
        public Player player1;
        public Weather weather;
        public int people;
        public double customers;
        public int i;

        public Customers(Weather weather, Player player1)
        {
            this.weather = weather;
            this.player1 = player1;
            this.people = 100;
            this.customers = 0;
            this.i = 1;
        }
        // member methods

        public void GeneratePeople()
        {
            Random randNum = new Random();
            people = randNum.Next(50, 100);
            GenerateCustomers();
        }

        public void GenerateCustomers()
        {
           if (weather.temperature >= 75)
            {
                if (weather.condition == "sunny" || weather.condition == "clear" && player1.recipe.cupPrice < 1)
                {
                    customers = Math.Round(people * 0.8);
                    LemonadeConsumed();
                }
                else
                {
                    customers = Math.Round(people * 0.5);
                    LemonadeConsumed();
                }
            }
           else if (weather.temperature < 75)
            {
                if(weather.condition == "sunny" || weather.condition == "clear" && player1.recipe.cupPrice < 0.75)
                {
                    customers = Math.Round(people * 0.7);
                    LemonadeConsumed();
                }
                else
                {
                    customers = Math.Round(people * 0.4);
                    LemonadeConsumed();
                }
            }
        }

        public void DisplayCustomers()
        {
            Console.WriteLine("Today "+ people +" people walked by your lemonade stand and you had "+ customers +" customers.");
            Console.ReadLine();
        }

        public void LemonadeConsumed()
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
