using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Items.Potions
{
    public class HealingPotion : Item
    {
        public HealingPotion()
        {
            Name = "Healing Potion";
            Description = "Mountain DEW!!!";
            Weight = 1;
            Type = ItemType.Potion;
        }
    }
}
