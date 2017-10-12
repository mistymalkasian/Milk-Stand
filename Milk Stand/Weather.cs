using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milk_Stand
{
    class Weather
    {
        public string CurrentWeather;
        public string Forecast;

        public Weather()
        {
            Random Random = new Random();

           List<string> WeatherTypes = new List<string>();

            WeatherTypes.Add("Rainy");
            WeatherTypes.Add("Hazy");
            WeatherTypes.Add("Cloudy");
            WeatherTypes.Add("Sunny");
            string Forecast = Convert.ToString(Random.Next(WeatherTypes.Count));
        }

        public void DetermineForecast()
        {
           
            Console.WriteLine("FORECAST");
            Console.WriteLine("Tomorrow's weather will be:" + Forecast);

        }

        Random Random = new Random();


        public void DetermineWeather(Day day)
        {
            CurrentWeather = Convert.ToString(Random.Next(1, 5));

            Console.WriteLine("Today is " + name + "!");
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

        public void DetermineForecast()
        {
            //use dot notation here instead of hard coding junk
            Day2Forecast = Random.Next(1, 5);

            Console.WriteLine("FORECAST");
            Console.WriteLine("Tomorrow's weather will be:");

            if (Day2Forecast == 1)
            {
                Console.WriteLine("Rainy.");
                //WeatherMultiplier(-1);
            }
            else if (Day2Forecast == 2)
            {
                Console.WriteLine("Hazy.");
            }
            else if (Day2Forecast == 3)
            {
                Console.WriteLine("Cloudy.");
            }
            else if (Day2Forecast == 4)
            {
                Console.WriteLine("Sunny.");
            }
            else
            {
                Console.WriteLine("A scorcher!!!");
            }
            Console.ReadLine();

        }

        name = "Monday";
           
    }
    public void DisplayWeather()
    {
        Random Random = new Random();
        int WeatherChoice = Random.Next(1, 5);

        Console.WriteLine("Today is " + Day.name + "!");
        Console.WriteLine("WEATHER NEWS");
        Console.WriteLine("Today's weather is:" + Day2Forecast);
        Console.ReadLine();
    }

    public void WeatherMultiplier(int Number)
    {

    }



}

