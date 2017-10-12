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
        protected int Day2Forecast;
        protected int Day3Forecast;
        protected int Day4Forecast;
        protected int Day5Forecast;
        protected int Day6Forecast;
        protected int Day7Forecast;

        
        public Day()
        {
            this.name = name;

            Weather Weather = new Weather();
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

        }



       

}
    }
