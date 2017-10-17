using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milk_Stand
{
    class Weather
    {
    
        public string Forecast;
        public string CurrentWeather;
        Random Random = new Random();

        public Weather()
        {

        }
        public void DetermineForecast()
        { 
            string[] WeatherTypes = new string[5];

            WeatherTypes[0] = "Rainy";
            WeatherTypes[1] = "Hazy";
            WeatherTypes[2] = "Cloudy";
            WeatherTypes[3] = "Sunny";
            WeatherTypes[4] = "HOT!";
            Forecast = Convert.ToString(WeatherTypes[Random.Next(0, 5)]);
            Console.WriteLine("FORECAST");
            Console.WriteLine("Tomorrow's weather will be: " + Forecast);
        }

   
        
         public void DisplayWeather(string Forecast)
        {
            CurrentWeather = Forecast;
            Console.WriteLine("WEATHER NEWS");
            Console.WriteLine("Today's weather is: " + CurrentWeather);
            Console.ReadLine();
        }   
    }
}

