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

         
            
        }

        public void DetermineForecast()
        {





            string[] WeatherTypes = new string[5];

            WeatherTypes[0] = "Rainy";
            WeatherTypes[1] = "Hazy";
            WeatherTypes[2] = "Cloudy";
            WeatherTypes[3] = "Sunny";
            WeatherTypes[4] = "HOT!";
            string Forecast = Convert.ToString(WeatherTypes[Random.Next(0, 4)]);
            Console.WriteLine("FORECAST");
            Console.WriteLine("Tomorrow's weather will be: " + Forecast);

        }

        Random Random = new Random();


        public void DisplayWeather(Day day)
        {
            //CurrentWeather = Convert.ToString(Random.Next(1, 5));

            Console.WriteLine("Today is " + day.name + "!");
            Console.WriteLine("WEATHER NEWS");
            Console.WriteLine("Today's weather is:" + Forecast);

            Console.ReadLine();
        }        
    }
  
    //public void WeatherMultiplier(int Number)
    //{

    //}
}

