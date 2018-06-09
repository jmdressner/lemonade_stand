using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Budget
    {
        // member variables
        public Inventory inventory;
        public Day day;
        public Recipe recipe;
        public double balance;
        public double profit;

        public Budget(Inventory inventory, Day day, Recipe recipe)
        {
            this.inventory = inventory;
            this.day = day;
            this.recipe = recipe;
            this.balance = 25;
            this.profit = 0;
        }

        // member methods
        public void DisplayBudget()
        {
            Console.WriteLine("Your balance is $" + balance);
            Console.ReadLine();
        }

        public void SubtractCostOfCupsFromBalance()
        {
            balance -= inventory.cup.cost;
            DisplayBalance();
        }

        public void SubtractCostOfLemonsFromBalance()
        {
            balance -= inventory.lemon.cost;
            DisplayBalance();
        }

        public void SubtractCostOfSugarFromBalance()
        {
            balance -= inventory.sugar.cost;
            DisplayBalance();
        }

        public void SubtractCostOfIceFromBalance()
        {
            balance -= inventory.ice.cost;
            DisplayBalance();
        }

        public void GenerateProfit()
        {
            profit = day.customers.customers * recipe.cupPrice;
            AddProfitToBalance();
        }

        public void AddProfitToBalance()
        {
            balance += profit;
            DisplayBalance();
        }

        public void DisplayBalance()
        {
            Console.WriteLine("Your new balance is: $" + balance);
            Console.ReadLine();
        }


    }
}
