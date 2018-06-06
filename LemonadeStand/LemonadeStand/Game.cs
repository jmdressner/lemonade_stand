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
            day = new Day();
            item = new Item();
        }

        // member methods

        public void RunGame()
        {
            player1.SetName();
            day.GenerateWeekForecast();
        }

        public void GenerateDay()
        {
            for (int i = 0; i < day.days.Count; i++)
            {
                Console.WriteLine("It is " + day.days[i]);
                Console.ReadLine();
                day.weather.GenerateTemperature();
                day.weather.GenerateCondition();
            }
        }
    }
}
