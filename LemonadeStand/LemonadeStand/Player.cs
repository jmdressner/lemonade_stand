using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // member variables
        public Inventory inventory;
        public Recipe recipe;
        public string name;
        public double budget;
        public string itemToPurchase;
       

        public Player()
        {
            inventory = new Inventory();
            recipe = new Recipe(inventory);
            this.name = "";
            this.budget = 20;
            this.itemToPurchase = "";
        }
        // member methods
        public void DisplayName()
        {
            Console.WriteLine("Player: " + name);
            Console.ReadLine();
        }

        public void SetName()
        {
            Console.WriteLine("Please enter player name.");
            name = Console.ReadLine();
            DisplayName();
        }

        public void DisplayBudget()
        {
            Console.WriteLine("Your balance is $" + budget);
            Console.ReadLine();
        }

        public void Purchases()
        {
            Console.WriteLine("Would you like to purchase anything? If so, please enter: 'cups', 'lemons', 'sugar', or 'ice'.  If not, please enter 'no'.");
            itemToPurchase = Console.ReadLine().ToLower();

            switch (itemToPurchase)
            {
                case "cups":
                    inventory.cup.DisplayPrice();
                    Purchases();
                    break;
                case "lemons":
                    inventory.lemon.DisplayPrice();
                    Purchases();
                    break;
                case "sugar":
                    inventory.sugar.DisplayPrice();
                    Purchases();
                    break;
                case "ice":
                    inventory.ice.DisplayPrice();
                    Purchases();
                    break;
                case "no":
                    GenerateBalance();
                    break;
                default:
                    Console.WriteLine("That was an invalid entry.  Please press enter to continue.");
                    Purchases();
                    break;
            }
           
        }

        public void GenerateBalance()
        {
            budget -= (inventory.cup.cost + inventory.lemon.cost + inventory.sugar.cost + inventory.ice.cost);
            DisplayBalance();
        }

        public void DisplayBalance()
        {
            Console.WriteLine("Your new balance is: $"+ budget);
            Console.ReadLine();
        }
    }
}
