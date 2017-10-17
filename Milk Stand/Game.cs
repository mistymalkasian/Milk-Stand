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


    public void RunGame(Player player, Shop shop, Weather weather, Day day, Customer customer, Recipe recipe)
        {  
            for( int i = 0; i < 8; i++)
            {
                day.DisplayDay(day);
                weather.DetermineForecast();
                weather.DisplayWeather(weather.Forecast);
                player.DisplayMoney();
                shop.SellToPlayer(player);
                player.DisplayInventory();
                player.CreateRecipe(recipe);
                player.SetPrice(recipe);
                day.GenerateCustomers(player, weather, recipe);
                day.DisplayEndofDayReport();
            }
        }
        
       public void DisplayEndgameResults()
        {
            Console.WriteLine("Well, it looks like your business venture, like all good things, has come to an end.");
            Console.WriteLine("Here are your final results!");
            Console.WriteLine("Overall profit : $");
            Console.WriteLine("Play again sometime!");
        }
    }
}
