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
