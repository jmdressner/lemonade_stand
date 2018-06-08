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
            inventory.cup.quantity = 1;
            inventory.lemon.quantity = 1;
            inventory.sugar.quantity = 1;
            inventory.ice.quantity = 2;
            DisplayStandardRecipe();
        }

        public void DisplayStandardRecipe()
        {
            Console.WriteLine("Standard Recipe: 1 cup of lemonade needs: 1 lemon, 1 sugar, and 2 ice cubes.");
            Console.ReadLine();
        }

        public void MakeOwnRecipe()
        {
            inventory.cup.quantity = 1;
            Console.WriteLine("For one cup of lemonade how many lemons would you like to use?  Please enter a whole number.");
            inventory.lemon.quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("For one cup of lemonade how many sugars would you like to use?  Please enter a whole number.");
            inventory.sugar.quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("For one cup of lemonade how many ice cubes would you like to use?  Please enter a whole number.");
            inventory.ice.quantity = Convert.ToInt32(Console.ReadLine());
        }

        public void SetLemonadePrice()
        {
            Console.WriteLine("How much would you like to charge for 1 cup of lemonade?");
            cupPrice = Convert.ToInt32(Console.ReadLine());
        }
    }
}
