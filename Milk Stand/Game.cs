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
            Console.WriteLine("Buy your ingredients.");
            Console.WriteLine("Make your own recipe of gourmet flavored milk.");
            Console.WriteLine("See how many glasses you can sell a day!");
            Console.WriteLine("How you make your recipe, as well as the weather and your pricing,");
            Console.WriteLine("will determine whether or not customers will want to buy your product.");
            Console.WriteLine("Become a Milk Expert!");
            Console.ReadLine();           
        }


    public void RunGame(Player player, Shop shop, Weather weather, Customer customer, Recipe recipe)
        {
            weather.DetermineWeeksForecast();
            for (CurrentDay = 0; CurrentDay < 7; CurrentDay++)
            {
                Console.WriteLine("");
                Console.WriteLine("A new day has begun!");
                Day day = new Day();   
                day.weather = weather.WeeklyWeather[CurrentDay + 1];
                weather.DisplayCurrentWeather(CurrentDay);
                weather.DetermineTomorrowsForecast(CurrentDay);
                player.DisplayMoney();
                player.DisplayInventory();
                AskToShop(player, recipe, shop);
                player.CreateRecipe(recipe);
                player.SetPrice(recipe);
                player.BeginDay();
                day.GenerateCustomers(player, weather, recipe, day);
                DisplayEndofDayReport(player, day);
            }
        }

        public void AskToShop(Player player, Recipe recipe, Shop shop)
        {
            Console.WriteLine("Type 'yes' if you'd like to go to the shop. Otherwise, we'll begin making the day's recipe!");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "yes":
                    shop.SellToPlayer(player, recipe);
                    break;
                default:
                    break;
            }
        }

        public void DisplayEndofDayReport(Player player, Day day)
        {
            Console.WriteLine("END OF DAY REPORT:");
            Console.WriteLine("You have sold " + player.DailyCupsSold + " cups of milk today.");
            Console.WriteLine("You have made $" + player.DaysEarnings + " today.");
            Console.WriteLine("Your total money is : $" + player.money);        
            Console.ReadLine();
        }

        public void DisplayEndgameResults(Player player)
        {
            Console.WriteLine("Well, it looks like your business venture, like all good things, has come to an end.");
            Console.WriteLine("Here are your final results!");
            Console.WriteLine("Overall profit : $" + player.TotalEarnings);
            Console.WriteLine("Play again sometime!");
        }
    }
}
