using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Ice : Item
    {
        public Ice()
        {
            quantity = 0;
            quantityToPurchase = 0;
            quantityForRecipe = 2;
            price = 0.01;
            cost = 0;
        }

        public override void DisplayPrice()
        {
            Console.WriteLine("The price per ice cube is: " + price);
            SetQuantityToPurchase();
        }

        public override void SetQuantityToPurchase()
        {
            Console.WriteLine("How many ice cubes would you like to buy?  Please enter a whole number.");
            try
            {
                quantityToPurchase = Convert.ToInt32(Console.ReadLine());
                AddToInventory();
                GenerateCost();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid entry. Please enter a whole number.");
                SetQuantityToPurchase();
            }
        }

    }
}
