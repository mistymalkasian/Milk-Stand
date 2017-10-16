﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milk_Stand
{

    class Customer
    {

        public string Name;
        public double Thirst;
        public string Type;
        public double ChancetoBuy = 25;
        
       Random Random = new Random();


        public Customer()
        {
           
        }

        public void DetermineCustomerType()
        {
            string[] Types = new string[21];

            Types[0] = "Youngster ";
            Types[1] = "Battle Girl ";
            Types[2] = "Madame ";
            Types[3] = "Swimmer ";
            Types[4] = "Ace Trainer ";
            Types[5] = "Athlete ";
            Types[6] = "Backpacker ";
            Types[7] = "Parasol Lady ";
            Types[8] = "Poke Fan ";
            Types[9] = "Poke Maniac ";
            Types[10] = "Nursery Aide ";
            Types[11] = "Pokemon Breeder ";
            Types[12] = "Bug Catcher ";
            Types[13] = "Chef ";
            Types[14] = "Interviewer ";
            Types[15] = "Bodybuilder ";
            Types[16] = "Comedian ";
            Types[17] = "Biker ";
            Types[18] = "Executive ";
            Types[19] = "Expert ";
            Types[20] = "Hiker ";

            Type = Convert.ToString(Types[Random.Next(0, 21)]);
            
        }

        public void DetermineCustomerName()
        { 
            string[] Names = new string[34];

            Names[0] = "Bobette";
            Names[1] = "Agnes";
            Names[2] = "Ophelia";
            Names[3] = "Gladys";
            Names[4] = "Edwin";
            Names[5] = "Edgar";
            Names[6] = "Alan";
            Names[7] = "Ambrose";
            Names[8] = "Clara";
            Names[9] = "Gertrude";
            Names[10] = "Bessie";
            Names[11] = "Cora";
            Names[12] = "Alfred";
            Names[13] = "Bessie";
            Names[14] = "Bertha";
            Names[15] = "Betty";
            Names[16] = "Donald";
            Names[17] = "Earl";
            Names[18] = "Ethel";
            Names[19] = "Eugene";
            Names[20] = "Harold";
            Names[21] = "Herbert";
            Names[22] = "Hortense";
            Names[23] = "Howard";
            Names[24] = "Irma";
            Names[25] = "Loretta";
            Names[26] = "Marvin";
            Names[27] = "Myrtle";
            Names[28] = "Norman";
            Names[29] = "Pearl";
            Names[30] = "Seymour";
            Names[31] = "Velma";
            Names[32] = "Jean";
            Names[33] = "Frances";

            Name = Convert.ToString(Names[Random.Next(0, 34)]);
            

        }

        public void DetermineCustomerThirst()
        {
            Thirst = Random.Next(1, 7);       
        }

       
        public void DetermineChanceToBuy(Customer customer, Weather weather, Recipe recipe)
        {
           
            if (weather.CurrentWeather == "Rainy")
            {
                ChancetoBuy -= 10;
            }
            else if (weather.CurrentWeather == "Sunny")
            {
                ChancetoBuy += 10;
            }
            else if (weather.CurrentWeather == "HOT!")
            {
                ChancetoBuy += 15;
            }
            else if (customer.Thirst >= 4)
            {
                ChancetoBuy += 10;
            }
            else if (customer.Thirst <= 3)
            {
                ChancetoBuy -= 10;
            }
            else if (recipe.IsGood == true)
            {
                ChancetoBuy += 25;
            } 
            else if (recipe.IsGood == false)
            {
                ChancetoBuy -= 25;
            }
            else if (recipe.IsHigh == true)
            {
                ChancetoBuy -= 25;
            }
            else if (recipe.IsHigh == false)
            {
                ChancetoBuy += 25;
            } 
        }

        public void DetermineWhoBuys(Player player, Recipe recipe)
        {
            if (ChancetoBuy >= 70)
            {
                Console.WriteLine(" buys a glass of Milk!");
                
            }

            else
            {
                Console.WriteLine(" doesn't buy anything!!!");
            }
            
        }

     }
 }

