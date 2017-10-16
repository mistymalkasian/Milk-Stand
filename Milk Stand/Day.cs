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
        public string CurrentWeather;
        Random Random = new Random();
       
        public Day(string name)
        {
            this.name = name;
            

            //Weather Weather = new Weather();
            //Day Day1 = new Day("Sunday");
            //Day Day2 = new Day("Monday");
            //Day Day3 = new Day("Tuesday");
            //Day Day4 = new Day("Wednesday");
            //Day Day5 = new Day("Thursday");
            //Day Day6 = new Day("Friday");
            //Day Day7 = new Day("Saturday");

        }

        public void DisplayDay(Day day)
        {
            Console.WriteLine("Today is " + day.name + "!");
        }
    }
 }
