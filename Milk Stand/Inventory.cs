using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milk_Stand
{
    class Inventory
    {
        public double price;
        public List<MilkCarton> MilkCartons = new List<MilkCarton>();
        public List<Cup> Cups = new List<Cup>();
        public List<Ice> IceCubes = new List<Ice>();
        public List<Sugar> SugarPackets = new List<Sugar>();
        public List<FlavorSyrup> FlavorSyrups = new List<FlavorSyrup>();



        public Inventory ()
	{

    }
      
    }
}
