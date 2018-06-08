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

        public Game()
        {
            player1 = new Player();
            day = new Day(player1);
        }

        // member methods

        public void RunGame()
        {
            player1.SetName();
            player1.DisplayBudget();
            day.GenerateWeekForecast();
            GenerateDay();
        }

        public void GenerateDay()
        {
            for (int i = 0; i < day.days.Count; i++)
            {
                Console.WriteLine("It is " + day.days[i]);
                Console.ReadLine();
                day.weather.DisplayTemperature();
                day.weather.DisplayCondition();
                player1.inventory.CurrentInventory();
                player1.Purchases();
                day.customers.GeneratePeople();
            }
        }
    }
}
