using RPG.Inventory.Items.Containers.Restrictions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Inventory.Items.Containers
{
    public class PotionSatchel : Container
    {
        public PotionSatchel() : base(4)
        {
            Name = "Potion satchel";
            Description = "A specially padded bag for carrying glass bottles and vials";
            Type = ItemType.Container;
            Weight = 1;

            AddRestriction(new CapacityRestriction());
            AddRestriction(new ItemTypeRestriction(ItemType.Potion));
        }
    }
}
