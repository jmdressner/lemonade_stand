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
            quantityToPurchase = Convert.ToInt32(Console.ReadLine());
            AddToInventory();
            GenerateCost();
        }

        public override void GenerateCost()
        {
            cost = quantityToPurchase * price;
        }

        public override void AddToInventory()
        {
            quantity += quantityToPurchase;
        }
    }
}
