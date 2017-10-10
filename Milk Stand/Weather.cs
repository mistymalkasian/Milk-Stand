using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milk_Stand
{
    class Weather
    {
        //member variables
        double CurrentWeather;
        double Forecast;



        //constructor
        public Weather()
        {
            
        }

        //member methods

        public void DetermineWeather()
        {
           Random Random = new Random();

           double WeatherChoice = Random.Next(1, 5);

           Console.WriteLine("Today's weather is:");

            if (WeatherChoice == 1)
            {
                Console.WriteLine("Sunny.");
            }
            else if (WeatherChoice == 2)
            {
                Console.WriteLine("Hazy.");
            }
            else if (WeatherChoice == 3)
            {
                Console.WriteLine("Cloudy.");
            }
            else
            {
                Console.WriteLine("Rainy.");
            }
                

            
            Console.ReadLine();
            

        }
    }
}
