using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public abstract class Item
    {
        // member vaiables

        public int quantity;
        public int quantityToPurchase;
        public int quantityForRecipe;
        public double price;
        public double cost;

        public Item()
        {
            
        }
        // member methods

        public abstract void DisplayPrice();

        public abstract void SetQuantityToPurchase();

        public void AddToInventory()
        {
            quantity += quantityToPurchase;
        }

        public void GenerateCost()
        {
            cost = quantityToPurchase * price;
        }

        public void SubtractFromInventory(int quantityForRecipe)
        {
            quantity -= quantityForRecipe;
        }
    }
}
