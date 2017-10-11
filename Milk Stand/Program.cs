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
            Game.DisplayRules();
            Weather.DetermineForecast();
            Customer Bob = new Customer("Bob");
            Customer Bobette = new Customer("Bobette");
            Customer Gertrude = new Customer("Gertrude");
            
        }
    }
}
