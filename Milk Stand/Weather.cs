using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milk_Stand
{
    class Weather
    {
        Random Random = new Random();
        public string CurrentWeather;
        //public int i;
        public List<string> WeeklyWeather = new List<string>(); 

        public Weather()
        {

        }
        public void DetermineWeeksForecast()
        {
            string[] WeatherTypes = new string[5];

            WeatherTypes[0] = "Rainy";
            WeatherTypes[1] = "Hazy";
            WeatherTypes[2] = "Cloudy";
            WeatherTypes[3] = "Sunny";
            WeatherTypes[4] = "HOT!";

            Console.WriteLine("WEEKLY FORECAST:");

            
            for (int counter = 1; counter < 8; counter++)
            {
                string DailyForecast = Convert.ToString(WeatherTypes[Random.Next(0, 5)]);
                Console.WriteLine("Day " + counter + "'s weather will be: " + DailyForecast);
                WeeklyWeather.Add(DailyForecast);

            }
        }

       public void DetermineTomorrowsForecast(int CurrentDay)
        {
            Console.WriteLine("Tomorrow's forecast is: " + WeeklyWeather[CurrentDay + 1]);
        }
       
         public void DisplayCurrentWeather(int CurrentDay)
        {
            CurrentWeather = WeeklyWeather[CurrentDay];

            Console.WriteLine("WEATHER NEWS");
            Console.WriteLine("Today's weather is: " + CurrentWeather);
            Console.ReadLine();
        }   
    }
}

