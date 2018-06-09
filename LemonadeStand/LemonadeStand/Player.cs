﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // member variables
        public Day day;
        public Inventory inventory;
        public Recipe recipe;
        public Budget budget;
        public string name;
        public string itemToPurchase;
       

        public Player(Day day)
        {
            inventory = new Inventory(budget);
            recipe = new Recipe(inventory);
            budget = new Budget(inventory, day, recipe);
            this.day = day;
            this.name = "";
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

        public void Purchases()
        {
            Console.WriteLine("Would you like to purchase anything? If so, please enter: 'cups', 'lemons', 'sugar', or 'ice'.  If not, please enter 'no'.");
            itemToPurchase = Console.ReadLine().ToLower();

            switch (itemToPurchase)
            {
                case "cups":
                    inventory.cup.DisplayPrice();
                    budget.SubtractCostOfCupsFromBalance();
                    Purchases();
                    break;
                case "lemons":
                    inventory.lemon.DisplayPrice();
                    budget.SubtractCostOfLemonsFromBalance();
                    Purchases();
                    break;
                case "sugar":
                    inventory.sugar.DisplayPrice();
                    budget.SubtractCostOfSugarFromBalance();
                    Purchases();
                    break;
                case "ice":
                    inventory.ice.DisplayPrice();
                    budget.SubtractCostOfIceFromBalance();
                    Purchases();
                    break;
                case "no":
                    ChooseRecipe();
                    break;
                default:
                    Console.WriteLine("That was an invalid entry.  Please press enter to continue.");
                    Purchases();
                    break;
            }
           
        }

        public void ChooseRecipe()
        {
            Console.WriteLine("Do you want to use the standard recipe or make your own? Please enter 'standard' or 'make'.");
            string recipeChoice = Console.ReadLine().ToLower();

            switch (recipeChoice)
            {
                case "standard":
                    recipe.UseStandardRecipe();
                    break;
                case "make":
                    recipe.MakeOwnRecipe();
                    break;
                default:
                    Console.WriteLine("That was an invalid entry. Please press enter to continue.");
                    break;
            }
        }
    }
}
