using RPGInventory.Items;
using RPGInventory.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Practice
{
   public class Samurai
    {
        private readonly IAttackable _weapon;
        private List<Item> _items;
        //property injection
        //property might be set, might not
        public IAttackable SecondaryWeapon { get; set; }

        //constructor injection
        // we are taking in a concrete/specific object as input during creation
        public Samurai(IAttackable weapon)
        {
            _weapon = weapon;
            _items = new List<Item>();
        }

        public string Attack(string target)
        {
            return _weapon.Hit(target);
        }

        public string SecondaryAttack(string target)

        {
            if (SecondaryWeapon != null)
            {
                return SecondaryWeapon.Hit(target);
            }

            return "You do not have a secondary weapon";
        }

        //method injection
        //be able to provide dependency in method call
        public void PickupItem(Item item)
        {
             _items.Add(item);
        }
    }
}
