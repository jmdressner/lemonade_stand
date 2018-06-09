using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Sugar : Item
    {
        public Sugar()
        {
            quantity = 0;
            quantityToPurchase = 0;
            quantityForRecipe = 1;
            price = 0.05;
            cost = 0;
        }

        public override void DisplayPrice()
        {
            Console.WriteLine("The price per sugar is: " + price);
            SetQuantityToPurchase();
        }

        public override void SetQuantityToPurchase()
        {
            Console.WriteLine("How many sugars would you like to buy?  Please enter a whole number.");
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

        public override void GenerateCost()
        {
            cost = quantityToPurchase * price;
        }
    }
}
