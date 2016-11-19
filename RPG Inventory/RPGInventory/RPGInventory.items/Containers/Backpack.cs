using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.items.Containers
{
    public class Backpack : Container
    {
        public Backpack(): base(4)
        {
            Name = "A leater backpack";
            Description = "Leathery and hollow inside, just like me.";
            Weight = 2;
        }
    }
}
