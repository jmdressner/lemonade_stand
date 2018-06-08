using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customers
    {
        // member variables
        public Player player1;
        public Weather weather;
        public int people;
        public double customers;

        public Customers(Weather weather, Player player1)
        {
            this.weather = weather;
            this.player1 = player1;
            this.people = 100;
            this.customers = 0;
        }
        // member methods

        public void GeneratePeople()
        {
            Random randNum = new Random();
            people = randNum.Next(50, 100);
            GenerateCustomers();
        }

        public void GenerateCustomers()
        {
           if (weather.temperature >= 75)
            {
                if (weather.condition == "sunny" || weather.condition == "clear" && player1.recipe.cupPrice < 1)
                {
                    customers = people * 0.8;
                    Math.Ceiling(customers);
                    DisplayCustomers();
                }
                else
                {
                    customers = people * 0.5;
                    Math.Ceiling(customers);
                    DisplayCustomers();
                }
            }
           else if (weather.temperature < 75)
            {
                if(weather.condition == "sunny" || weather.condition == "clear" && player1.recipe.cupPrice < 0.75)
                {
                    customers = people * 0.7;
                    Math.Ceiling(customers);
                    DisplayCustomers();
                }
                else
                {
                    customers = people * 0.4;
                    Math.Ceiling(customers);
                    DisplayCustomers();
                }
            }
        }

        public void DisplayCustomers()
        {
            Console.WriteLine("Today "+ people +" people walked by your lemonade stand and you had "+ customers +" customers.");
            Console.ReadLine();
        }

    }
}
