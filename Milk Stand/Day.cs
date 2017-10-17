using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milk_Stand
{
    class Day
    {
        public double DaysEarnings;
        public string weather;
        public int CurrentDay;
        public Random Random = new Random();
        public List<Customer> TheDaysCustomers = new List<Customer>();

        public Day()
        {
            
        }

        public void GenerateCustomers(Player player, Weather weather, Recipe recipe, Day day)

        {            
            for (int i = 0; i < 101; i++)
            {
                Customer customer = new Customer();
                customer.DetermineCustomerType(day);
                customer.DetermineCustomerName(day);
                customer.DetermineCustomerThirst(day);
                Console.WriteLine(customer.Type + customer.Name);
                TheDaysCustomers.Add(customer);
                customer.DetermineChanceToBuy(customer, weather, recipe);
                customer.DetermineWhoBuys(player, recipe);
            }
            Console.ReadLine();
        }

        public void DisplayEndofDayReport(Player player, Day day)
        {
            Console.WriteLine("END OF DAY REPORT:");
            Console.WriteLine("You have made $" + day.DaysEarnings + " today.");
            Console.WriteLine("Your total money is : $" + player.money);
        }
    }
 }
