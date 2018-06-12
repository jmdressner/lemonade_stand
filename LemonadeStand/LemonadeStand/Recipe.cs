using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        public List<double> CupsOfLemonade;
        public double possibleCupsOfLemonade;

        public Recipe()
        {
            this.possibleCupsOfLemonade = 0;
            CupsOfLemonade = new List<double>();
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

        public void QuantityOfLemonadePossible(Inventory inventory)
        {
            double possibleCups = inventory.cup.quantity / inventory.cup.quantityForRecipe;
            CupsOfLemonade.Add(possibleCups);
            double possibleLemons = inventory.lemon.quantity / inventory.lemon.quantityForRecipe;
            CupsOfLemonade.Add(possibleLemons);
            double possibleSugar = inventory.sugar.quantity / inventory.sugar.quantityForRecipe;
            CupsOfLemonade.Add(possibleSugar);
            double possibleIce = inventory.ice.quantity / inventory.ice.quantityForRecipe;
            CupsOfLemonade.Add(possibleIce);
            possibleCupsOfLemonade = Math.Floor(CupsOfLemonade.Min());
        }

        public void ClearList()
        {
            CupsOfLemonade.Clear();
        }
    }
}
