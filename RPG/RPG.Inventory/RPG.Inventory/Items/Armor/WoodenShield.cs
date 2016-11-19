using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Inventory.Items.Armor
{
    public class WoodenShield : Item
    {
        public WoodenShield()
        {
            Name = "Wooden Shield";
            Description = "Not much more than a barrel lid with a handle attached.";
            Weight = 5;
            Type = ItemType.Armor;

        } 
    }
}
