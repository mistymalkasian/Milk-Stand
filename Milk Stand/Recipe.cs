using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milk_Stand
{
  
    class Recipe
    {
        double AmountofPitchers;
        double AmountofFlavor;
        double AmountofCubes;
        double AmountofSugar;
        public bool IsGood;
        public double price;
        public bool IsHigh;

        public Recipe()
        {

        }


  public void CreateRecipe()
        {
            Console.WriteLine("Now it's time to create the recipe you want to use for the day.");
            Console.WriteLine("How many pitchers would you like to make? Remember that each pitcher uses up 10 milk cartons and serves 10 people.");
            AmountofPitchers = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("How many sugar packets would you like to add to the pitcher?");
            AmountofSugar = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("How many flavor packets would you like to add to the pitcher?");
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

        public void RecipeMultiplier(Customer customer)
        {
            if (IsGood == true)
            {
                customer.ChancetoBuy += 25;
            }
        }
    }
}
