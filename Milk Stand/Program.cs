using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milk_Stand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game Game = new Game();
            Weather Weather = new Weather();
            Customer Customer = new Customer("hello", 4);
            Day Day1 = new Day("Sunday");
            Shop Shop = new Shop();
            Player player = new Player();
            
            
                    

            Game.DisplayRules();
            Shop.SellToPlayer(player);
           
            Weather.DetermineForecast();
            Weather.DisplayWeather(Weather.Forecast);
            Weather.DetermineForecast();
            Weather.DisplayWeather(Weather.Forecast);
            Customer.CustomerGenerator(Weather);
            
            

            




        }
    }
}
