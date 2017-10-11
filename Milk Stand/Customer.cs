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
        public string name;
        double LikelihoodToBuy;

        //constructor
        public Customer(string name)
        {
            Customer Agnes = new Customer("Agnes");
            Customer Bobette = new Customer("Bobette");
            Customer Gertrude = new Customer("Gertrude");
            Customer UmaBob = new Customer("Uma Bob");
            Customer Edwin = new Customer("Edwin");
            Customer Winnifred = new Customer("Winnifred");
            Customer Jane = new Customer("Jane");
            Customer Chives = new Customer("Chives");
            Customer Janice = new Customer("Janice");
            Customer Alice = new Customer("Alice");
            Customer Laurie = new Customer("Laurie");
            Customer Ben = new Customer("Ben");
        }

        //member methods

       public void DetermineLikelihoodToBuy()
        {
            
            //put something that takes into account several different factors to determine whether or not a customer will buy Iced Milk.
        }

       public void DetermineCustomerType(Customer customer)
        {
            Random Random = new Random();

           int TypeChoice = Random.Next(1, 21);

            switch (TypeChoice)
            {
                case 1:
                    Console.WriteLine("Youngster " + name);
                    break;
                case 2:
                    Console.WriteLine("Battle Girl " + name);
                    break;
                case 3:
                    Console.WriteLine("Madame " + name);
                    break;
                case 4:
                    Console.WriteLine("Swimmer " + name);
                    break;
                case 5:
                    Console.WriteLine("Ace Trainer " + name);
                    break;
                case 6:
                    Console.WriteLine("Athlete " + name);
                    break;
                case 7:
                    Console.WriteLine("Backpacker " + name);
                    break;
                case 8:
                    Console.WriteLine("Parasol Lady " + name);
                    break;
                case 9:
                    Console.WriteLine("Poke Fan " + name);
                    break;
                case 10:
                    Console.WriteLine("Poke Maniac " + name);
                    break;
                case 11:
                    Console.WriteLine("Nursery Aide " + name);
                    break;
                case 12:
                    Console.WriteLine("Pokemon Breeder " + name);
                    break;
                case 13:
                    Console.WriteLine("Bug Catcher " + name);
                    break;
                case 14:
                    Console.WriteLine("Chef " + name);
                    break;
                case 15:
                    Console.WriteLine("Interviewer " + name);
                    break;
                case 16:
                    Console.WriteLine("Bodybuilder" + name);
                    break;
                case 17:
                    Console.WriteLine("Comedian " + name);
                    break;
                case 18:
                    Console.WriteLine("Biker " + name);
                    break;
                case 19:
                    Console.WriteLine("Executive " + name);
                    break;
                case 20:
                    Console.WriteLine("Expert " + name);
                    break;
                default:
                    break;
            }

            public void CustomerGenerator()

        {
            Random Random = new Random();

            NewCustomer = Random.Next
        }

        }
    }
}
