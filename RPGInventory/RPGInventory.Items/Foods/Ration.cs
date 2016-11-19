using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Items.Foods
{
    public class Ration : Item
    {
        public Ration()
        {
            Name = "Ration";
            Description = "Pizza Fire is good!";
            Weight = 2;
            Type = ItemType.Food;
        }
    }
}
