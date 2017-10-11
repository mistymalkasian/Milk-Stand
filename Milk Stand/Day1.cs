using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milk_Stand
{
    class Day1 : Day
    {
        Random Random = new Random();
        public Day1()
        {
            name = "Sunday";
        }
      public void DetermineDay1Weather()
        {
            int WeatherChoice = Random.Next(1,5);

            Console.WriteLine("WEATHER NEWS");
            Console.WriteLine("Today's weather is:");

            if (WeatherChoice == 1)
            {
                Console.WriteLine("Rainy.");
            }
            else if (WeatherChoice == 2)
            {
                Console.WriteLine("Hazy.");
            }
            else if (WeatherChoice == 3)
            {
                Console.WriteLine("Cloudy.");
            }
            else if (WeatherChoice == 4)
            {
                Console.WriteLine("Sunny.");
            }
            else
            {
                Console.WriteLine("A scorcher!!!");
            }
            Console.ReadLine();
        }
    }
}
