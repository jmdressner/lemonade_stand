using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        public Player player1;
        public Day day;
        public DatabaseSaver saver;

        public Game()
        {
            player1 = new Player();
            day = new Day();
            saver = new DatabaseSaver();
        }

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
            saver.Save(player1.name, player1.budget.sumProfit, player1.budget.sumLoss);
            Console.Clear();
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
                player1.recipe.ClearList();
                Console.Clear();
            }
        }
    }
}
