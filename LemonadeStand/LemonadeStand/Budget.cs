using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Budget
    {
        public double balance;
        public double profit;
        public double loss;
        public double cupPrice;
        public List<double> totalProfit = new List<double>();
        public List<double> totalLoss = new List<double>();

        public Budget()
        {
            this.balance = 25;
            this.profit = 0;
            this.cupPrice = 0.25;
            this.loss = 0;
        }

        public void SubtractCostOfCupsFromBalance(Inventory inventory)
        {
            balance -= inventory.cup.cost;
            if (balance >= 0)
            {
                DisplayBalance();
            }
            else
            {
                Console.WriteLine("You do not have enough money left in your balance to make that purchase.");
                balance += inventory.cup.cost;
                DisplayBalance();
            }  
        }

        public void SubtractCostOfLemonsFromBalance(Inventory inventory)
        {
            balance -= inventory.lemon.cost;
            if (balance >= 0)
            {
                DisplayBalance();
            }
            else
            {
                Console.WriteLine("You do not have enough money left in your balance to make that purchase.");
                balance += inventory.lemon.cost;
                DisplayBalance();
            }
        }

        public void SubtractCostOfSugarFromBalance(Inventory inventory)
        {
            balance -= inventory.sugar.cost;
            if (balance >= 0)
            {
                DisplayBalance();
            }
            else
            {
                Console.WriteLine("You do not have enough money left in your balance to make that purchase.");
                balance += inventory.sugar.cost;
                DisplayBalance();
            }
        }

        public void SubtractCostOfIceFromBalance(Inventory inventory)
        {
            balance -= inventory.ice.cost;
            if (balance >= 0)
            {
                DisplayBalance();
            }
            else
            {
                Console.WriteLine("You do not have enough money left in your balance to make that purchase.");
                balance += inventory.ice.cost;
                DisplayBalance();
            }
        }

        public void GenerateProfit(Day day)
        {
            profit = day.customers.servedCustomers * cupPrice;
            totalProfit.Add(profit);
            DisplayProfit(day);
            AddProfitToBalance();
        }

        public void DisplayProfit(Day day)
        {
            Console.WriteLine("Your profit from today was: $"+ profit);
        }

        public void DisplayTotalProfit()
        {
            double sumProfit = totalProfit.Sum();
            Console.WriteLine("Your total profit is: $"+ sumProfit);
        }

        public void GenerateLoss(Day day)
        {
            loss = day.customers.unservedCustomers * cupPrice;
            totalLoss.Add(loss);
            DisplayLoss(day);
        }

        public void DisplayLoss(Day day)
        {
            Console.WriteLine("Your loss in sales from today was: $"+ loss);
            DisplayBalance();
        }

        public void DisplayTotalLoss()
        {
            double sumLoss = totalLoss.Sum();
            Console.WriteLine("Your total loss in sales is: $" + sumLoss);
            Console.ReadLine();
        }

        public void AddProfitToBalance()
        {
            balance += profit;
        }

        public void DisplayBalance()
        {
            Console.WriteLine("Your new balance is: $" + balance);
            Console.ReadLine();
        }

        public void SetLemonadePrice()
        {
            Console.WriteLine("How much would you like to charge for 1 cup of lemonade? Please enter a number (the default price is 0.25c).");
            try
            {
                cupPrice = Convert.ToDouble(Console.ReadLine());
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid entry. Please press enter to continue.");
                SetLemonadePrice();
            }
        }
    }
}
