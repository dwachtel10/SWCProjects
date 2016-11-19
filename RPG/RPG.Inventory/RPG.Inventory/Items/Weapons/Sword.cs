using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Inventory.Items.Weapons
{
    public class Sword : Item
    {
        public Sword()
        {
            Name = "Wooden sword";
            Description = "Not much more than a stick, but it's better than nothing.";
            Weight = 3;
            Type = ItemType.Weapon;
        }
    }
}
