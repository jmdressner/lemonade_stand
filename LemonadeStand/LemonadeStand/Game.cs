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
            day = new Day();
        }

        // member methods

        public void RunGame()
        {
            player1.SetName();
            player1.budget.DisplayBudget();
            day.GenerateWeekForecast();
            GenerateDay();
        }

        public void GenerateDay()
        {
            for (int i = 0; i < day.days.Count; i++)
            {
                Console.WriteLine("It is " + day.days[i]);
                day.weather.DisplayTemperature();
                day.weather.DisplayCondition();
                player1.ChooseRecipe();
                player1.budget.SetLemonadePrice();
                player1.inventory.CurrentInventory();
                player1.Purchases();
                day.GeneratePeople(day, player1);
                player1.budget.GenerateProfit(day);
                player1.budget.GenerateLoss(day);
            }
        }
    }
}
