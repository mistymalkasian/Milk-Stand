using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milk_Stand
{
    class Player
    {
        public double money;
        public Inventory PlayerInventory;

        public Player()
        {
            this.money = 50.00;
            this.PlayerInventory = new Inventory();
        }

        public void DisplayInventory()
        {
            Console.WriteLine("You have " + PlayerInventory.IceCubes.Count + " ice cubes.");
            Console.WriteLine("You have " + PlayerInventory.MilkCartons.Count + "  milk cartons.");
            Console.WriteLine("You have " + PlayerInventory.SugarPackets.Count + " sugar packets.");
            Console.WriteLine("You have " + PlayerInventory.FlavorSyrups.Count + " flavor syrups.");
            Console.WriteLine("You have " + PlayerInventory.Cups.Count + " cups.");
            Console.ReadLine();              
        }

        public void DisplayMoney()
        {
            Console.WriteLine("You currently have: $" + money);
            Console.ReadLine();
        }
    }
}
