﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public int temperature;
        public string condition;
        public List<string> conditions = new List<string>() {"sunny", "clear", "overcast", "rainy"};

        public Weather()
        {

        }

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
        }
    }
}
