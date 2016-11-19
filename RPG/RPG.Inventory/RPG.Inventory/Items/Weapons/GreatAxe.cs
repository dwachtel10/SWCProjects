using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Inventory.Items.Weapons
{
    public class GreatAxe : Item
    {
        public GreatAxe()
        {
            Name = "Greataxe";
            Description = "A weapon designed more for intimidation than practical use.";
            Weight = 5;
            Type = ItemType.Weapon;

        }
    }
}
