﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public Inventory inventory;
        public Recipe recipe;
        public Budget budget;
        public string name;

        public Player()
        {
            inventory = new Inventory();
            recipe = new Recipe();
            budget = new Budget();
            this.name = "";
        }

        public void SetName()
        {
            Console.WriteLine("Please enter player name.");
            name = Console.ReadLine();
            DisplayName();
        }

        public void DisplayName()
        {
            Console.WriteLine("Player: " + name);
            Console.ReadLine();
        }

        public void Purchases()
        {
            Console.WriteLine("Would you like to purchase anything? If so, please enter: 'cups', 'lemons', 'sugar', or 'ice'.  If not, please enter 'no'.");
            string itemToPurchase = Console.ReadLine().ToLower();

            switch (itemToPurchase)
            {
                case "cups":
                    inventory.cup.DisplayPrice();
                    budget.SubtractCostOfCupsFromBalance(inventory);
                    Purchases();
                    break;
                case "lemons":
                    inventory.lemon.DisplayPrice();
                    budget.SubtractCostOfLemonsFromBalance(inventory);
                    Purchases();
                    break;
                case "sugar":
                    inventory.sugar.DisplayPrice();
                    budget.SubtractCostOfSugarFromBalance(inventory);
                    Purchases();
                    break;
                case "ice":
                    inventory.ice.DisplayPrice();
                    budget.SubtractCostOfIceFromBalance(inventory);
                    Purchases();
                    break;
                case "no":
                    inventory.CurrentInventory();
                    recipe.QuantityOfLemonadePossible(inventory);
                    break;
                default:
                    Console.WriteLine("That was an invalid entry.  Please press enter to continue.");
                    Purchases();
                    break;
            }
        }

        public void ChooseRecipe()
        {
            recipe.DisplayStandardRecipe();
            Console.WriteLine("Do you want to use the standard recipe or make your own? Please enter 'standard' or 'make'.");
            string recipeChoice = Console.ReadLine().ToLower();

            switch (recipeChoice)
            {
                case "standard":
                    recipe.UseStandardRecipe(inventory);
                    break;
                case "make":
                    recipe.MakeOwnRecipe(inventory);
                    break;
                default:
                    Console.WriteLine("That was an invalid entry. Please press enter to continue.");
                    ChooseRecipe();
                    break;
            }
        }
    }
}
