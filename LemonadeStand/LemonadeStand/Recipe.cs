using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        Inventory inventory;
        public double cupPrice;

        public Recipe(Inventory inventory)
        {
            this.inventory = inventory;
            cupPrice = 0.25;
        }

        public void UseStandardRecipe()
        {
            inventory.cup.quantityForRecipe = 1;
            inventory.lemon.quantityForRecipe = 1;
            inventory.sugar.quantityForRecipe = 1;
            inventory.ice.quantityForRecipe = 2;
            DisplayStandardRecipe();
        }

        public void DisplayStandardRecipe()
        {
            Console.WriteLine("Standard Recipe: 1 cup of lemonade needs: 1 lemon, 1 sugar, and 2 ice cubes.");
            Console.ReadLine();
        }

        public void MakeOwnRecipe()
        {
            inventory.cup.quantityForRecipe = 1;
            Console.WriteLine("For one cup of lemonade how many lemons would you like to use?  Please enter a whole number.");
            try
            {
                inventory.lemon.quantityForRecipe = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid entry. Please enter a whole number.");
                MakeOwnRecipe();
            }
            Console.WriteLine("For one cup of lemonade how many sugars would you like to use?  Please enter a whole number.");
            try
            {
                inventory.sugar.quantityForRecipe = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid entry. Please enter a whole number.");
                MakeOwnRecipe();
            }
            Console.WriteLine("For one cup of lemonade how many ice cubes would you like to use?  Please enter a whole number.");
            try
            {
                inventory.ice.quantityForRecipe = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid entry. Please enter a whole number.");
                MakeOwnRecipe();
            }
        }

        public void SetLemonadePrice()
        {
            Console.WriteLine("How much would you like to charge for 1 cup of lemonade?");
            try
            {
                cupPrice = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid entry. Please press enter to continue.");
                SetLemonadePrice();
            }
        }
    }
}
