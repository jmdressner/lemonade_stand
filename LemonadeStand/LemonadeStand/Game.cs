using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        // member variables
        public Player player1;
        public Day day;
        public Item item;

        public Game()
        {
            player1 = new Player();
        }

        // member methods

        public void RunGame()
        {
            player1.SetName();
        }
    }
}
