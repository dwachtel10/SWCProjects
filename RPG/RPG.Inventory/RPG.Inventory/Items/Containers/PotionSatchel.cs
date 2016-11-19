using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Inventory.Items.Containers
{
    public class PotionSatchel : SpecificContainer
    {
        public PotionSatchel() : base(4, ItemType.Potion)
        {
            Name = "Potion Satchel";
            Description = "A padded bag specially designed for protecting glass vials and bottles.";
            Type = ItemType.Container;
            Weight = 1;
        }

        
    }
}
