using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milk_Stand
{
    class Game
    {

       public void DisplayRules()
        {
            Console.WriteLine("You have decided to open your own Milk Stand!");
            Console.WriteLine("The rules are thus:");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ReadLine();
            
        }


    public void RunGame(Player player, Shop shop, Weather weather, Day day)
        {

            day.DisplayDay(day);
            weather.DetermineForecast();
            weather.DisplayWeather(weather.Forecast);

            shop.SellToPlayer(player);
            player.DisplayMoney();
            player.DisplayInventory();
            
            
            
        }
    }
}
