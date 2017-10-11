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
       public double CurrentWeather;
       public double Forecast;
       


        //constructor
        public Weather(double Forecast)
        {
            
        }

        //member methods

        public double DetermineForecast()
        {
           Random Random = new Random();
           double Forecast = Random.Next(1, 6);

            Console.WriteLine("FORECAST");
            Console.WriteLine("Tomorrow's weather will be:");

            if (Forecast == 1)
            {
                Console.WriteLine("Rainy.");
            }
            else if (Forecast == 2)
            {
                Console.WriteLine("Hazy.");
            }
            else if (Forecast == 3)
            {
                Console.WriteLine("Cloudy.");
            }
            else if (Forecast == 4)
            {
                Console.WriteLine("Sunny.");
            }
            else
            {
                Console.WriteLine("A scorcher!!!");
            }
            return Forecast;
        }

        //public void DetermineCurrentWeather(double Forecast)
        //{
        //    make current weather whatever the forecast was yesterday, except for the starting day, which will be random
        //}
      public void WeatherMultiplier()
        {
            
        }





    }
}
