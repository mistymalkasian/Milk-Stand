using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milk_Stand
{
    class Game
    {
        public int CurrentDay;

        public Game()
        {
            
        }

       public void DisplayRules()
        {
            Console.WriteLine("You have decided to open your own Milk Stand!");
            Console.WriteLine("The rules are thus:");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ReadLine();           
        }


    public void RunGame(Player player, Shop shop, Weather weather, Customer customer, Recipe recipe)
        {

            weather.DetermineWeeksForecast();
            for (CurrentDay = 0; CurrentDay < 7; CurrentDay++)
            {
                Day day = new Day();   
                day.weather = weather.WeeklyWeather[CurrentDay + 1];
                weather.DisplayCurrentWeather(CurrentDay);
                weather.DetermineTomorrowsForecast(CurrentDay);
                shop.SellToPlayer(player);
                player.CreateRecipe(recipe);
                day.GenerateCustomers(player, weather, recipe, day);
                day.DisplayEndofDayReport(player, day);
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
