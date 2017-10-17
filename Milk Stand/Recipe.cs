using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milk_Stand
{
  
    class Recipe
    {
       public double AmountofPitchers;
       public double AmountofFlavor;
       public double AmountofCubes;
       public double AmountofSugar;
       public bool IsGood;
       public double price;
       public bool IsHigh;

        public Recipe()
        {
           
        }
        public void CreateRecipe(Player player)
        {
            Console.WriteLine("Now it's time to create the recipe you want to use for the day.");

            Console.WriteLine("How many pitchers would you like to make? Remember that each pitcher uses up 10 milk cartons and serves 10 people.");
            AmountofPitchers = Convert.ToInt32(Console.ReadLine());
            for ( int i = 0; i < 11; i++)
            {
                player.PlayerInventory.MilkCartons.RemoveAt(0);
            }
            
            Console.WriteLine("How many sugar packets would you like to add to the pitcher?");
            Console.WriteLine("Hint: If you add too few or too many packets per pitcher, the customers won't like your product.");
            AmountofSugar = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("How many squirts of flavor syrup would you like to add to the pitcher?");
            Console.WriteLine("Hint: If you add too few or too many syrups per pitcher, the customers won't like your product.");
            AmountofFlavor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many ice cubes would you like to add to each cup?");
            AmountofCubes = Convert.ToInt32(Console.ReadLine());
        }
        
        public void SetPrice()
        {
            Console.WriteLine("What price will you make each cup today?");
            price = Convert.ToInt32(Console.ReadLine());
        }    
       
    public void DetermineIfRecipeIsGood()
        {
            if (AmountofFlavor <= 2 || AmountofFlavor >= 6 || AmountofSugar <= 5 || AmountofSugar >= 10 || AmountofCubes <= 2 || AmountofCubes >= 5)
            {
                IsGood = false;
            }
       
            else
            {
                IsGood = true;
            }
        }

        public void DetermineIfPriceIsHigh()
        {
            if (price >= 2.50)
            {
                IsHigh = true;
            }
            else
            {
                IsHigh = false;
            }
        }
    }
}
