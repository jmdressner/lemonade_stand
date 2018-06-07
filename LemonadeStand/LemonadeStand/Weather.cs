using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        // member variables
        public int temperature;
        public string condition;
        public List<string> conditions = new List<string>() {"sunny", "hazy", "overcast", "rainy"};

        public Weather()
        {

        }
        // member methods

        public int GenerateTemperature()
        {
            Random randomTemperature = new Random();
            temperature = randomTemperature.Next(50, 100);
            return temperature;
        }

        public void DisplayTemperature()
        {
            GenerateTemperature();
            Console.WriteLine("The temperature is: " + temperature);
        }

        public string GenerateCondition()
        {
            Random randNum = new Random();
            int index = randNum.Next(0, 3);
            condition = conditions[index];
            return condition;
        }

        public void DisplayCondition()
        {
            GenerateCondition();
            Console.WriteLine("The weather is: " + condition);
            Console.ReadLine();
        }
    }
}
