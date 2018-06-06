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
        public Weather weather;
        public Customers customers;
        public string forecastDay;
        public List<string> days = new List<string>() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

        public Day()
        {
            weather = new Weather();
            customers = new Customers();
        }
        // member methods

        public void GenerateWeekForecast()
        {
            for(int i = 0; i < days.Count; i++)
            {
                forecastDay = days[i];
                weather.GenerateTemperature();
                weather.GenerateCondition();
                DisplayGeneratedWeekForecast();
            }
        }

        public void DisplayGeneratedWeekForecast()
        {
            Console.WriteLine(forecastDay + " will be " + weather.temperature + "F and " + weather.condition);
            Console.ReadLine();
        }
    }
}
