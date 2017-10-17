using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milk_Stand
{
    class Day
    {
        public string name;
        
        Random Random = new Random();
        public List<Customer> TheDaysCustomers = new List<Customer>();

        public Day(string name)
        {
            this.name = name;

        }

        public void DisplayDay(Day day)
        {
            Console.WriteLine("Today is " + day.name + "!");
        }

        public void CustomerGenerator(Player player, Weather weather, Recipe recipe)

        {
            for (int i = 0; i < 101; i++)
            {
                Customer customer = new Customer();
                customer.DetermineCustomerType();
                customer.DetermineCustomerName();
                customer.DetermineCustomerThirst();
                Console.WriteLine(customer.Type + customer.Name);
                TheDaysCustomers.Add(customer);
                customer.DetermineChanceToBuy(customer, weather, recipe);
                customer.DetermineWhoBuys(player, recipe);
            }

            Console.ReadLine();
        }

        public void DisplayEndofDayReport()
        {
            Console.WriteLine("END OF DAY REPORT:");
            Console.WriteLine("You have made " + " today.");
            Console.WriteLine("Your total money is : $" );
        }
    }
 }
