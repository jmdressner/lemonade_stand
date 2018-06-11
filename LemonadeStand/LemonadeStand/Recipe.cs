using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {

        public Recipe()
        {
            
        }

        public void UseStandardRecipe(Inventory inventory)
        {
            inventory.cup.quantityForRecipe = 1;
            inventory.lemon.quantityForRecipe = 1;
            inventory.sugar.quantityForRecipe = 1;
            inventory.ice.quantityForRecipe = 2;
        }

        public void DisplayStandardRecipe()
        {
            Console.WriteLine("The Standard Recipe for 1 cup of lemonade is: 1 lemon, 1 sugar, and 2 ice cubes.");
        }

        public void MakeOwnRecipe(Inventory inventory)
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
                MakeOwnRecipe(inventory);
            }
            Console.WriteLine("For one cup of lemonade how many sugars would you like to use?  Please enter a whole number.");
            try
            {
                inventory.sugar.quantityForRecipe = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid entry. Please enter a whole number.");
                MakeOwnRecipe(inventory);
            }
            Console.WriteLine("For one cup of lemonade how many ice cubes would you like to use?  Please enter a whole number.");
            try
            {
                inventory.ice.quantityForRecipe = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid entry. Please enter a whole number.");
                MakeOwnRecipe(inventory);
            }
        }

       
    }
}
