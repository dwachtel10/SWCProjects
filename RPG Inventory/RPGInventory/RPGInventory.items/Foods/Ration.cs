using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.items.Foods
{
    public class Ration : Item
    {
        public Ration()
        {
            Name = "Ration";
            Description = "Tastes like alfalfa and sadness.";
            Weight = 2;
            Type = ItemType.Foods;
        }
    }
}
