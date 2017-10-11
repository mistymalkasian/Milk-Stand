using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milk_Stand
{
    class Inventory
    {

        public Inventory()
        {
            Cup Cup = new Cup();
            Ice Ice = new Ice();
            FlavorPacket FlavorPacket = new FlavorPacket();
            MilkCarton MilkCarton = new MilkCarton();
        }
    }
}
