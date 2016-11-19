using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Items.Weapons.Swords
{
    public class ShortSword : Weapon, IAttackable
    {
        public ShortSword()
        {
            this.Name = "Short Sword";
            this.Description = "you'll get more than a papercut...";
            this.Weight = 2;
        }

        public string Hit(string target)
        {
            return $"stabbed {target}";
        }

        public override string ToString()
        {
            return $"{Name} - {Description}\nType = {Type}";
        }
    }
}
