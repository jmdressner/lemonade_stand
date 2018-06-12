using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        public Weather weather;
        public Customers customers;
        public string forecastDay;
        public List<string> days = new List<string>() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

        public Day()
        {
            weather = new Weather();
            customers = new Customers();
        }

        public void GenerateWeekForecast()
        {
            for(int i = 0; i < days.Count; i++)
            {
                forecastDay = days[i];
                weather.GenerateTemperature();
                weather.GenerateCondition();
                DisplayGeneratedForecast();
            }
        }

        public string DisplayGeneratedForecast()
        {
            Console.WriteLine(forecastDay + " will be " + weather.temperature + "F and " + weather.condition);
            Console.ReadLine();
            return "";
        }

        public void GeneratePeople(Day day, Player player1)
        {
            Random randNum = new Random();
            customers.people = randNum.Next(50, 100);
            GenerateCustomers(day, player1);
        }

        public void GenerateCustomers(Day day, Player player1)
        {
            if (weather.temperature >= 75)
            {
                if (weather.condition == "sunny" || weather.condition == "clear" && player1.budget.cupPrice < 1)
                {
                    customers.customers = Math.Round(customers.people * 0.8);
                    customers.LemonadeConsumed(day, player1);
                }
                else
                {
                    customers.customers = Math.Round(customers.people * 0.5);
                    customers.LemonadeConsumed(day, player1);
                }
            }
            else if (weather.temperature < 75)
            {
                if (weather.condition == "sunny" || weather.condition == "clear" && player1.budget.cupPrice < 0.75)
                {
                    customers.customers = Math.Round(customers.people * 0.7);
                    customers.LemonadeConsumed(day, player1);
                }
                else
                {
                    customers.customers = Math.Round(customers.people * 0.4);
                    customers.LemonadeConsumed(day, player1);
                }
            }
        }
    }
}
