using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        // member variables
        public Cup cup;
        public Lemon lemon;
        public Sugar sugar;
        public Ice ice;

        public Inventory()
        {
            cup = new Cup();
            lemon = new Lemon();
            sugar = new Sugar();
            ice = new Ice();
        }

        public void CurrentInventory()
        {
            Console.WriteLine("Your current inventory is:\n Cups: " + cup.quantity + "\n Lemons: " + lemon.quantity + "\n Sugar: " + sugar.quantity + "\n Ice: " + ice.quantity);
            Console.ReadLine();
        } 
    }
}
