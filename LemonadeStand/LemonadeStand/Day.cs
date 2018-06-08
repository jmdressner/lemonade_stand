using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        // member variables
        public Player player1;
        public Weather weather;
        public Customers customers;
        public string forecastDay;
        public List<string> days = new List<string>() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
        public List<string> weekForecast = new List<string>();

        public Day(Player player1)
        {
            this.player1 = player1;
            weather = new Weather();
            customers = new Customers(weather, player1);
        }
        // member methods

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
    }
}
