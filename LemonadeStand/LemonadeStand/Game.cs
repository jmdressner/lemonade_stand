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
            UserInterface.DisplayInstructions();
            Console.Clear();
            player1.SetName();
            Console.WriteLine("The weather forecast for the week is:");
            Console.ReadLine();
            day.GenerateWeekForecast();
            Console.Clear();
            GenerateDay();
        }

        public void GenerateDay()
        {
            for (int i = 0; i < day.days.Count; i++)
            {
                Console.WriteLine("It is " + day.days[i]);
                day.weather.DisplayTemperature();
                day.weather.DisplayCondition();
                player1.budget.DisplayBalance();
                player1.ChooseRecipe();
                player1.budget.SetLemonadePrice();
                player1.inventory.CurrentInventory();
                player1.Purchases();
                day.GeneratePeople(day, player1);
                player1.budget.GenerateProfit(day);
                player1.budget.GenerateLoss(day);
                player1.budget.DisplayTotalProfit();
                player1.budget.DisplayTotalLoss();
                Console.Clear();
            }
        }
    }
}
