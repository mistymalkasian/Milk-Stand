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

