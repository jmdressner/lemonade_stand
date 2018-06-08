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
        public double price;
        public double cost;

        public Item()
        {
            
        }
        // member methods

        public abstract void DisplayPrice();

        public abstract void SetQuantityToPurchase();

        public abstract void GenerateCost();

        public abstract void AddToInventory();

        public void GenerateBalance()
        {
            
        }
    }
}
