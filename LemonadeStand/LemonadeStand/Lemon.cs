using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Lemon : Item
    {
        public Lemon()
        {
            quantity = 0;
            quantityToPurchase = 0;
            quantityForRecipe = 1;
            price = 0.1;
            cost = 0;
        }

        public override void DisplayPrice()
        {
            Console.WriteLine("The price per lemon is: " + price);
            SetQuantityToPurchase();
        }

        public override void SetQuantityToPurchase()
        {
            Console.WriteLine("How many lemons would you like to buy?  Please enter a whole number.");
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
