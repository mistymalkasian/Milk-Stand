using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milk_Stand
{
    class Shop
    {
        public Shop()
        {
            
        }        
        public void AskToShop(Player player, Recipe recipe)
        {
            Console.WriteLine("Type 1 if you'd like to go to the shop. Otherwise, we'll begin making the day's recipe!");
           string answer = Console.ReadLine();

            switch(answer)
            {
                case "yes":
                    SellToPlayer(player);
                    break;
                default:
                    recipe.CreateRecipe(player);
                    break;
            }
        }
        public void SellToPlayer(Player player)
        {            
            Console.WriteLine("Welcome to Dairy King!");
            Console.WriteLine("We just so happen to only sell the exact items you need for your business...");
            Console.WriteLine("How convenient!");
            Console.WriteLine("Please type the corresponding number of the item you wish to buy.");
            Console.WriteLine("[1] 'Code Farms' Single-Serve Organic Milk Carton - $1.00");
            Console.WriteLine("[2] Vanilla Flavor Syrup - $0.25");
            Console.WriteLine("[3] Raw Cane Sugar Packet - $0.10");
            Console.WriteLine("[4] 'Silicon Spring' Ice Cube - $0.01");
            Console.WriteLine("[5] Classy Plastic Cup - $0.05");
        
            double CustomerChoice = Convert.ToInt32(Console.ReadLine());

            if (CustomerChoice == 1)
            {
                Console.WriteLine("Please enter (in numerals) how many milk cartons you would like to purchase.");
                Console.WriteLine("Hint: Ten cartons will fill a pitcher, and a pitcher serves 10 people.");
                double NumberofCartons = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < NumberofCartons; i++)
                {
                    MilkCarton MilkCarton = new MilkCarton();
                    player.PlayerInventory.MilkCartons.Add(MilkCarton);
                    player.money -= MilkCarton.price;

                }               
            }
                    
            else if (CustomerChoice == 2)
            {
                Console.WriteLine("Please enter how many flavor packets you would like to purchase.");
                double NumberofPackets = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < NumberofPackets; i++)
                {
                    FlavorSyrup FlavorSyrup = new FlavorSyrup();
                    player.PlayerInventory.FlavorSyrups.Add(FlavorSyrup);
                    player.money -= FlavorSyrup.price;
                }
            }   

            else if (CustomerChoice == 3)
            {
                Console.WriteLine("Please enter how many sugar packets you would like to purchase.");
                double NumberofSugars = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < NumberofSugars; i++)
                {
                    Sugar SugarPacket = new Sugar();
                    player.PlayerInventory.SugarPackets.Add(SugarPacket);
                    player.money -= SugarPacket.price;
                }
            }
              
            else if (CustomerChoice == 4)
            {
                Console.WriteLine("Please enter how many ice cubes you would like to purchase.");
                double NumberofCubes = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < NumberofCubes; i++)
                {
                    Ice IceCube = new Ice();
                    player.PlayerInventory.IceCubes.Add(IceCube);
                    player.money -= IceCube.price;
                }
            }     
            
            else if (CustomerChoice == 5)
            {
                Console.WriteLine("Please enter how many cups you would like to purchase.");
                Console.WriteLine("Hint: Buy as many cups as you can reasonably afford!");
                double NumberofCups = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < NumberofCups; i++)
                {
                    Cup Cup = new Cup();
                    player.PlayerInventory.Cups.Add(Cup);
                    player.money -= Cup.price;
                    
                }
            }
            else
            {
                Console.WriteLine("We literally don't sell anything else here. Please only enter 1, 2, 3, 4, or 5.");
                SellToPlayer(player);
            }

            Console.WriteLine("Type 1 if you would like to buy another item. Otherwise we will begin making the day's recipe!");
            int choice = Convert.ToInt32( Console.ReadLine());

            switch(choice)
            {
                case 1:
                    SellToPlayer(player);
                    break;
                default:
                    //begin the day
                    break;

            }
        }
      
    }
}
