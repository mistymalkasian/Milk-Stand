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

        public void CustomerGenerator()

        {
            for (int i = 0; i < 101; i++)
            {
                Customer customer = new Customer();
                customer.DetermineCustomerType();
                customer.DetermineCustomerName();
                customer.DetermineCustomerThirst();
                Console.WriteLine(customer.Type + customer.Name);
                TheDaysCustomers.Add(customer);
            }

            Console.ReadLine();
        }
    }
 }
