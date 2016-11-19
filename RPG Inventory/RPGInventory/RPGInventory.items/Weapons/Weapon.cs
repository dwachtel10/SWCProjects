using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.items.Weapons
{
    public abstract class Weapon : Item
    {
        public Weapon()
        {
            this.Type = ItemType.Weapons;
        }
    }
}
