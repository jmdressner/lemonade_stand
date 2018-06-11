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
        public double balance;
        public double profit;
        public double cupPrice;

        public Budget()
        {
            this.balance = 25;
            this.profit = 0;
            this.cupPrice = 0.25;
        }

        // member methods
        public void DisplayBudget()
        {
            Console.WriteLine("Your balance is $" + balance);
            Console.ReadLine();
        }

        public void SubtractCostOfCupsFromBalance(Inventory inventory)
        {
            balance -= inventory.cup.cost;
            DisplayBalance();
        }

        public void SubtractCostOfLemonsFromBalance(Inventory inventory)
        {
            balance -= inventory.lemon.cost;
            DisplayBalance();
        }

        public void SubtractCostOfSugarFromBalance(Inventory inventory)
        {
            balance -= inventory.sugar.cost;
            DisplayBalance();
        }

        public void SubtractCostOfIceFromBalance(Inventory inventory)
        {
            balance -= inventory.ice.cost;
            DisplayBalance();
        }

        public void GenerateProfit(Day day)
        {
            profit = day.customers.customers * cupPrice;
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

        public void SetLemonadePrice()
        {
            Console.WriteLine("How much would you like to charge for 1 cup of lemonade?");
            try
            {
                cupPrice = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid entry. Please press enter to continue.");
                SetLemonadePrice();
            }
        }
    }
}
