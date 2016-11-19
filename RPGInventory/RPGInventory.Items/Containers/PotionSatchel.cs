using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Items.Containers
{
    public class PotionSatchel : SpecificTypeContainer
    {
        public PotionSatchel() : base(3, ItemType.Potion)
        {
            Name = "Potion Satchel";
            Description = "It holds your potions";
            Weight = 1;
        }
    }
}
