using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milk_Stand
{
    class Player
    {
        public double DailyCupsSold;
        public double money;
        public double TotalEarnings;
        public double DaysEarnings;
        public Inventory PlayerInventory;
        public List<double> AllEarnings = new List<double>();


        public Player()
        {
            this.money = 50.00;
            this.PlayerInventory = new Inventory();
        }

        public void DisplayInventory()
        {      
            Console.WriteLine("You have " + PlayerInventory.MilkCartons.Count + "  milk cartons.");
            Console.WriteLine("You have " + PlayerInventory.SugarPackets.Count + " sugar packets.");
            Console.WriteLine("You have " + PlayerInventory.FlavorSyrups.Count + " flavor syrups.");
            Console.WriteLine("You have " + PlayerInventory.IceCubes.Count + " ice cubes.");
            Console.WriteLine("You have " + PlayerInventory.Cups.Count + " cups.");
            Console.ReadLine();              
        }

        public void DisplayMoney()
        {
            Console.WriteLine("You currently have: $" + money);
            Console.ReadLine();
        }

        public void CreateRecipe(Recipe recipe) //THIS IS A THING DOER AND MUST BE FIXED
        {
            Console.WriteLine("Now it's time to create the recipe you want to use for the day.");
            Console.WriteLine("How many pitchers would you like to make? Remember that each pitcher uses up 10 milk cartons and serves 10 people.");
            try
            {
                recipe.AmountofPitchers = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input.Please enter an integer, and make sure you have the right amount of money to buy it! :)");
                CreateRecipe(recipe);
            }
            for (int i = 0; i < recipe.AmountofPitchers * 10; i++)
            {
                PlayerInventory.MilkCartons.RemoveAt(0);
            }
            Console.WriteLine("You are making " + recipe.AmountofPitchers + " pitchers today.");

            Console.WriteLine("How many sugar packets would you like to add to the pitcher?");
            Console.WriteLine("Hint: If you add too few or too many packets per pitcher, the customers won't like your product.");
            try
            {
                recipe.AmountofSugar = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input.Please enter an integer, and make sure you have the right amount of money to buy it! :)");
                CreateRecipe(recipe);
            }
           
            for (int i = 0; i < recipe.AmountofSugar; i++)
            {
                PlayerInventory.SugarPackets.RemoveAt(0);
            }
            Console.WriteLine("You are adding " + recipe.AmountofSugar + " sugar packets to each pitcher today.");

            Console.WriteLine("How many squirts of flavor syrup would you like to add to the pitcher?");
            Console.WriteLine("Hint: If you add too few or too many flavor syrups per pitcher, the customers won't like your product.");           
            try
            {
                recipe.AmountofFlavor = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input.Please enter an integer, and make sure you have the right amount of money to buy it! :)");
                CreateRecipe(recipe);
            }

            for (int i = 0; i < recipe.AmountofFlavor; i++)
            {
                PlayerInventory.FlavorSyrups.RemoveAt(0);
            }
            Console.WriteLine("You are adding " + recipe.AmountofFlavor + " flavor syrups to each pitcher today.");

            Console.WriteLine("How many ice cubes would you like to add to each cup?");          
            try
            {
                recipe.AmountofCubes = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please enter an integer, and make sure you have the right amount of money to buy it! :)");
            }

            for (int i = 0; i < recipe.AmountofCubes; i++)
            {
                PlayerInventory.IceCubes.RemoveAt(0);
            }
            Console.WriteLine("You are adding " + recipe.AmountofCubes + " cubes to each cup today.");
        }

        public void SetPrice(Recipe recipe)
        {
            Console.WriteLine("What price will you make each cup?");
            Console.WriteLine("Hint: If you make the price too high, the customers won't want to buy as much, but if you make it too low, you'll lose money!");
            try
            {
                recipe.price = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please only enter a price, in integers.");
                SetPrice(recipe);
            }
        }

        public void BeginDay()
        {
            Console.WriteLine("You trudge outside, ready to begin the business day... and A WILD HORDE OF CUSTOMERS APPEAR!!!");
            Console.ReadLine();
        }
    }
}
