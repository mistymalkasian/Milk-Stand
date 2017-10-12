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

       public void DetermineWhoBuys(Customer customer, Day day)
        {
            if (customer.Thirst == 2 || day.CurrentWeather == "Rainy")
            {
                List<string> Reasons = new List<string>();
                Reasons.Add(" doesn't want to buy any Milk because it's raining.");
                Reasons.Add(" doesn't want to buy any Milk because they aren't thirsty.");
                //Reason.Add(" doesn't want to buy any Milk because the recipe isn't good.");
                Random Random = new Random();
                string Reason = Convert.ToString(Random.Next(Reasons.Count));
                Console.WriteLine(Reason);

            }
            else if (customer.Thirst == 3 || day.CurrentWeather == "Hazy")
            {
                
                List<string> Reasons = new List<string>();
                Reasons.Add(" doesn't want to buy any Milk because it's hazy.");
                Reasons.Add(" doesn't want to buy any Milk because they aren't thirsty enough.");
                Reasons.Add(" buys a glass of Milk!");
                //Reason.Add(" doesn't want to buy any Milk because the recipe isn't good.");
                //Reason.Add(" doesn't want to buy any Milk because the price is too high.");
                Random Random = new Random();
                string Reason = Convert.ToString(Random.Next(Reasons.Count));
                Console.WriteLine(Reason);
            }
            else if (customer.Thirst == 4)//&&
            {
                Console.WriteLine(" buys a glass of Milk!");
            }
            else if (customer.Thirst == 5)//&&
            {
                Console.WriteLine(" buys a glass of Milk!");
            }
           
        }

        public void DetermineCustomerType(Customer Patron, Day day)
        {
            
            int TypeChoice = Random.Next(1, 21);


            switch (TypeChoice)
            {
                case 1:
                    Console.WriteLine("Youngster " + Patron.Name);
                    DetermineWhoBuys(Patron, day);
                    break;
                case 2:
                    Console.WriteLine("Battle Girl " + Patron.Name);
                    DetermineWhoBuys(Patron, day);
                    break;
                case 3:
                    Console.WriteLine("Madame " + Patron.Name);
                    DetermineWhoBuys(Patron, day);
                    break;
                case 4:
                    Console.WriteLine("Swimmer " + Patron.Name);
                    DetermineWhoBuys(Patron, day);
                    break;
                case 5:
                    Console.WriteLine("Ace Trainer " + Patron.Name);
                    DetermineWhoBuys(Patron, day);
                    break;
                case 6:
                    Console.WriteLine("Athlete " + Patron.Name);
                    DetermineWhoBuys(Patron, day);
                    break;
                case 7:
                    Console.WriteLine("Backpacker " + Patron.Name);
                    DetermineWhoBuys(Patron, day);
                    break;
                case 8:
                    Console.WriteLine("Parasol Lady " + Patron.Name);
                    DetermineWhoBuys(Patron, day);
                    break;
                case 9:
                    Console.WriteLine("Poke Fan " + Patron.Name);
                    DetermineWhoBuys(Patron, day);
                    break;
                case 10:
                    Console.WriteLine("Poke Maniac " + Patron.Name);
                    DetermineWhoBuys(Patron, day);
                    break;
                case 11:
                    Console.WriteLine("Nursery Aide " + Patron.Name);
                    DetermineWhoBuys(Patron, day);
                    break;
                case 12:
                    Console.WriteLine("Pokemon Breeder " + Patron.Name);
                    DetermineWhoBuys(Patron, day);
                    break;
                case 13:
                    Console.WriteLine("Bug Catcher " + Patron.Name);
                    DetermineWhoBuys(Patron, day);
                    break;
                case 14:
                    Console.WriteLine("Chef " + Patron.Name);
                    DetermineWhoBuys(Patron, day);
                    break;
                case 15:
                    Console.WriteLine("Interviewer " + Patron.Name);
                    DetermineWhoBuys(Patron, day);
                    break;
                case 16:
                    Console.WriteLine("Bodybuilder " + Patron.Name);
                    DetermineWhoBuys(Patron, day);
                    break;
                case 17:
                    Console.WriteLine("Comedian " + Patron.Name);
                    DetermineWhoBuys(Patron, day);
                    break;
                case 18:
                    Console.WriteLine("Biker " + Patron.Name);
                    DetermineWhoBuys(Patron, day);
                    break;
                case 19:
                    Console.WriteLine("Executive " + Patron.Name);
                    DetermineWhoBuys(Patron, day);
                    break;
                case 20:
                    Console.WriteLine("Expert " + Patron.Name);
                    DetermineWhoBuys(Patron, day);
                    break;
                default:
                    break;
            }
        }

            public void CustomerGenerator(Day day)

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
                DetermineCustomerType(Patron, day);
              
            }
            Console.ReadLine();
        }

        }
    }

