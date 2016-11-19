using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Items.Weapons
{
    //the contract that all weapons will follow
    //in order to be used in combat
    public interface IAttackable
    {
        //any usable weapon must implement this weapon
        string Hit(string target);
    }
}
