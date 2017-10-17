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
            Day Day1 = new Day("Sunday");
            Shop Shop = new Shop();
            Player Player = new Player();
            Recipe Recipe = new Recipe();
            Customer Customer = new Customer();
            
            //Game.DisplayRules();
         
            Game.RunGame(Player, Shop, Weather, Day1, Customer, Recipe);
            Console.ReadLine();
            //Game.DisplayEndgameResults();           
        }
    }
}
