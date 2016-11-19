using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.items.Weapons.Swords
{
   public class ShortSword : Weapon
    {
        public ShortSword()
        {
            this.Name = "Short Sword";
            this.Description = "It might not be long, but it's pointy!";
            this.Weight = 2;
        }

        public override string ToString()
        {
            return $"{Name} - {Description}\nType = {Type}";
        }
    }
}
