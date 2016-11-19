using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Items.Weapons.Projectiles
{
    public class Shuriken : Weapon, IAttackable
    {
        public Shuriken()
        {
            Name = "Shuriken";
            Description = "Throwing star";
            Weight = 1; 

        }
        //implementing this method and implementing the interface
        //means any object of this type can be IAttackable
        public string Hit(string target)
        {
           return $"Pierced {target}'s armor!";
        }
    }
}
