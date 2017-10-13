using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milk_Stand
{

    class Customer
    {
        //member variables
        public string Name;
        double Thirst;

       Random Random = new Random();


        //constructor
        public Customer(string name, double Thirst)
        {
            this.Name = name;
            this.Thirst = Thirst;
            
        }

       public void DetermineWhoBuys(Customer customer, Weather weather)//recipe and price will eventually need to be passed in as well
        {
            if (weather.CurrentWeather == "Sunny" || weather.CurrentWeather == "HOT!" && customer.Thirst >= 3)
            {
                string[] Reasons = new string[3];

                Reasons[0] = " buys some Milk because it's hot outside!";
                Reasons[1] = " buys some Milk because they are thirsty!";
                //Reasons[2] = " buys some Milk because the recipe is great!";
                Reasons[2] = " buys some Milk because they are feeling sorry for you!";

                string ReasonForYes = Convert.ToString(Reasons[Random.Next(0, 3)]);
                Console.WriteLine(ReasonForYes);
                //add to player's money by amount specified at the start of the day (by the player) and take away from their current inventory supplies by the amount specified

            }
            else if (customer.Thirst <= 3 && weather.CurrentWeather== "Rainy")//&& recipe is bad && price is high
            {

                string[] Reasons = new string[3];

                Reasons[0] = " doesn't want to buy any Milk because the price is too high.";
                Reasons[1] = " doesn't want to buy any Milk because they aren't thirsty enough.";
                //Reasons[2] = " doesn't want to buy any Milk because the recipe isn't good.";
                Reasons[2] = " doesn't want to buy any Milk because of the weather.";
               
                string ReasonForNo = Convert.ToString(Reasons[Random.Next(0, 3)]);
                Console.WriteLine(ReasonForNo);
            }
            else if (weather.CurrentWeather == "Hazy" || weather.CurrentWeather == "Cloudy")//&&
            {
                Console.WriteLine(" buys a glass of Milk!");
                   
            }
          else
            {
                Console.WriteLine(" supposes that they'll buy some Milk because why not!");
            }
           
        }

        public void DetermineCustomerType(Customer Patron, Weather weather)
        {
            
            int TypeChoice = Random.Next(1, 21);


            switch (TypeChoice)
            {
                case 1:
                    Console.WriteLine("Youngster " + Patron.Name);
                    DetermineWhoBuys(Patron, weather);
                    break;
                case 2:
                    Console.WriteLine("Battle Girl " + Patron.Name);
                    DetermineWhoBuys(Patron, weather);
                    break;
                case 3:
                    Console.WriteLine("Madame " + Patron.Name);
                    DetermineWhoBuys(Patron, weather);
                    break;
                case 4:
                    Console.WriteLine("Swimmer " + Patron.Name);
                    DetermineWhoBuys(Patron, weather);
                    break;
                case 5:
                    Console.WriteLine("Ace Trainer " + Patron.Name);
                    DetermineWhoBuys(Patron, weather);
                    break;
                case 6:
                    Console.WriteLine("Athlete " + Patron.Name);
                    DetermineWhoBuys(Patron, weather);
                    break;
                case 7:
                    Console.WriteLine("Backpacker " + Patron.Name);
                    DetermineWhoBuys(Patron, weather);
                    break;
                case 8:
                    Console.WriteLine("Parasol Lady " + Patron.Name);
                    DetermineWhoBuys(Patron, weather);
                    break;
                case 9:
                    Console.WriteLine("Poke Fan " + Patron.Name);
                    DetermineWhoBuys(Patron, weather);
                    break;
                case 10:
                    Console.WriteLine("Poke Maniac " + Patron.Name);
                    DetermineWhoBuys(Patron, weather);
                    break;
                case 11:
                    Console.WriteLine("Nursery Aide " + Patron.Name);
                    DetermineWhoBuys(Patron, weather);
                    break;
                case 12:
                    Console.WriteLine("Pokemon Breeder " + Patron.Name);
                    DetermineWhoBuys(Patron, weather);
                    break;
                case 13:
                    Console.WriteLine("Bug Catcher " + Patron.Name);
                    DetermineWhoBuys(Patron, weather);
                    break;
                case 14:
                    Console.WriteLine("Chef " + Patron.Name);
                    DetermineWhoBuys(Patron, weather);
                    break;
                case 15:
                    Console.WriteLine("Interviewer " + Patron.Name);
                    DetermineWhoBuys(Patron, weather);
                    break;
                case 16:
                    Console.WriteLine("Bodybuilder " + Patron.Name);
                    DetermineWhoBuys(Patron, weather);
                    break;
                case 17:
                    Console.WriteLine("Comedian " + Patron.Name);
                    DetermineWhoBuys(Patron, weather);
                    break;
                case 18:
                    Console.WriteLine("Biker " + Patron.Name);
                    DetermineWhoBuys(Patron, weather);
                    break;
                case 19:
                    Console.WriteLine("Executive " + Patron.Name);
                    DetermineWhoBuys(Patron, weather);
                    break;
                case 20:
                    Console.WriteLine("Expert " + Patron.Name);
                    DetermineWhoBuys(Patron, weather);
                    break;
                default:
                    break;
            }
        }

            public void CustomerGenerator(Weather weather)

        {
            Customer Agnes = new Customer("Agnes", 2);
            Customer Bobette = new Customer("Bobette", 4);
            Customer Gertrude = new Customer("Gertrude", 3);
            Customer UmaBob = new Customer("Uma Bob", 5);
            Customer Edwin = new Customer("Edwin", 3);
            Customer Winnifred = new Customer("Winnifred", 2);
            Customer Jane = new Customer("Jane", 5);
            Customer Chives = new Customer("Chives", 2);
            Customer Gladys = new Customer("Gladys", 5);
            Customer Deirdre = new Customer("Deirdre", 3);
            Customer Laurie = new Customer("Laurie", 4);
            Customer Ben = new Customer("Ben", 3);
         

            List<Customer> Patrons = new List<Customer>();
            Patrons.Add(Agnes);
            Patrons.Add(Bobette);
            Patrons.Add(Gertrude);
            Patrons.Add(UmaBob);
            Patrons.Add(Edwin);
            Patrons.Add(Winnifred);
            Patrons.Add(Jane);
            Patrons.Add(Chives);
            Patrons.Add(Gladys);
            Patrons.Add(Deirdre);
            Patrons.Add(Laurie);
            Patrons.Add(Ben);

            foreach (Customer Patron in Patrons)
            {
                DetermineCustomerType(Patron, weather);
              
            }
            Console.ReadLine();
        }

        }
    }

