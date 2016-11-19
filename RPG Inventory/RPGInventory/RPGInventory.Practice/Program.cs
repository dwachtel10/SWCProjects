using RPGInventory.items.Containers;
using RPGInventory.items.Potions;
using RPGInventory.items.Weapons.Swords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            PotionString();
            ContainerFun();
            ShortSword mySword = new ShortSword();
            Console.WriteLine(mySword);
            mySword.Description = "New description";
            //mySword.Type = items.ItemType.Armor;
            Console.ReadLine();
            
        }

        public static void PotionString()
        {
            HealingPotion potion = new HealingPotion();
            Console.WriteLine(potion);
        }

        public static void ContainerFun()
        {

            try {
                Backpack myPack = new Backpack();
                myPack.AddItem(new HealingPotion());
                myPack.AddItem(new HealingPotion());
                myPack.AddItem(new HealingPotion());
                myPack.AddItem(new HealingPotion());
                myPack.AddItem(new HealingPotion());

            }
            catch
            {
                Console.WriteLine("Something bad happned");
            }

        }
    }
}
