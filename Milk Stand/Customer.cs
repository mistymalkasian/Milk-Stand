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
        int TypeChoice;

        //constructor
        public Customer(string name)
        {
            this.name = name;
        }

        //member methods

       public void DetermineLikelihoodToBuy()
        {
            
            //put something that takes into account several different factors to determine whether or not a customer will buy Iced Milk on a given day.
        }

        public void DetermineCustomerType(Customer Patron)
        {
            Random Random = new Random();

            int TypeChoice = Random.Next(1, 21);

            switch (TypeChoice)
            {
                case 1:
                    Console.WriteLine("Youngster " + Patron.name);
                    break;
                case 2:
                    Console.WriteLine("Battle Girl " + Patron.name);
                    break;
                case 3:
                    Console.WriteLine("Madame " + Patron.name);
                    break;
                case 4:
                    Console.WriteLine("Swimmer " + Patron.name);
                    break;
                case 5:
                    Console.WriteLine("Ace Trainer " + Patron.name);
                    break;
                case 6:
                    Console.WriteLine("Athlete " + Patron.name);
                    break;
                case 7:
                    Console.WriteLine("Backpacker " + Patron.name);
                    break;
                case 8:
                    Console.WriteLine("Parasol Lady " + Patron.name);
                    break;
                case 9:
                    Console.WriteLine("Poke Fan " + Patron.name);
                    break;
                case 10:
                    Console.WriteLine("Poke Maniac " + Patron.name);
                    break;
                case 11:
                    Console.WriteLine("Nursery Aide " + Patron.name);
                    break;
                case 12:
                    Console.WriteLine("Pokemon Breeder " + Patron.name);
                    break;
                case 13:
                    Console.WriteLine("Bug Catcher " + Patron.name);
                    break;
                case 14:
                    Console.WriteLine("Chef " + Patron.name);
                    break;
                case 15:
                    Console.WriteLine("Interviewer " + Patron.name);
                    break;
                case 16:
                    Console.WriteLine("Bodybuilder" + Patron.name);
                    break;
                case 17:
                    Console.WriteLine("Comedian " + Patron.name);
                    break;
                case 18:
                    Console.WriteLine("Biker " + Patron.name);
                    break;
                case 19:
                    Console.WriteLine("Executive " + Patron.name);
                    break;
                case 20:
                    Console.WriteLine("Expert " + Patron.name);
                    break;
                default:
                    break;
            }
        }

            public void CustomerGenerator()

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
            Customer Deirdre = new Customer("Deirdre");
            Customer Laurie = new Customer("Laurie");
            Customer Ben = new Customer("Ben");

            //Random Random = new Random();
            //int NewCustomer = Random.Next(1, 6);

            List<Customer> Patrons = new List<Customer>();
            Patrons.Add(Agnes);
            Patrons.Add(Bobette);
            Patrons.Add(Gertrude);
            Patrons.Add(UmaBob);
            Patrons.Add(Edwin);
            Patrons.Add(Winnifred);
            Patrons.Add(Jane);
            Patrons.Add(Chives);
            Patrons.Add(Janice);
            Patrons.Add(Deirdre);
            Patrons.Add(Laurie);
            Patrons.Add(Ben);
            
            foreach (Customer Patron in Patrons)
            {
                DetermineCustomerType(Patron);
                //Console.WriteLine(Patron.name);
                
            }
            Console.ReadLine();
        }

        }
    }

