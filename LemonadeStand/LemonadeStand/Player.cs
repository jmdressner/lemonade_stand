using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // member variables
        public Inventory inventory;
        public Recipe recipe;
        public string name;
        public string budget;

        public Player()
        {
            inventory = new Inventory();
            recipe = new Recipe();
            this.name = "";
        }
        // member methods
        public void DisplayName()
        {
            Console.WriteLine("Player: " + name);
            Console.ReadLine();
        }

        public void SetName()
        {
            Console.WriteLine("Please enter player name.");
            name = Console.ReadLine();
            DisplayName();
        }
    }
}
