using RPGInventory.Items.Containers;
using RPGInventory.Items.Potions;
using RPGInventory.Items.Weapons.Projectiles;
using RPGInventory.Items.Weapons.Swords;
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
            //ShortSwordDemo();
            //PotionString();

            //// renamed some of the methods
            //// also take a look at the Container class
            //// I have reworked the class to now throw exceptions
            ////ContainerCauseException();
            //ContainerCatchAll();
            //ContainerCatchMultiple();
            //ContainerCatchExceptionObject();
            //ContainerFinallyBlock();

            //// added these methods
            //// this included the creation of the following classes
            ////      SpecificTypeContainer
            ////      PotionSatchel
            //SpecificContainerDemo();

            //demonstrate dependency injection
            DIExample();

            Console.ReadLine();
        }

        public static void ShortSwordDemo()
        {
            // create an object of type Short Sword
            ShortSword mySword = new ShortSword();

            // by overridding the ToString method we can print whatever we want 
            Console.WriteLine(mySword);

            // I can change Description because the setter is public
            mySword.Description = "Some new description";
            Console.WriteLine(mySword);

            // I cannot change the Type because the setter is protected
            // Only inside the Item class or a child class can I set it.
            // Program does not inherit from Item
            //mySword.Type = Items.ItemType.Armor;
        }

        public static void PotionString()
        {
            HealingPotion potion = new HealingPotion();

            // Because HealingPotion doesn't have a ToString override
            // The Item class is checked and since it does, it uses that. 
            Console.WriteLine(potion);
        }

        public static void ContainerCauseException()
        {
            // Create a backpack which can hold 4 things, add 5
            Backpack myPack = new Backpack();
            myPack.AddItem(new HealingPotion());
            myPack.AddItem(new HealingPotion());
            myPack.AddItem(new HealingPotion());
            myPack.AddItem(new HealingPotion());

            // This line should fail, we cannot add 5 things
            // backpacks can only hold 4 items.
            myPack.AddItem(new HealingPotion());
        }

        public static void ContainerCatchAll()
        {
            // very generic try...catch block where all types of exceptions are caught
            try
            {
                ContainerCauseException();
            }
            catch
            {
                // once the exception is caught we can handle however we want...
                Console.WriteLine("Something bad happened");
            }
        }

        public static void ContainerCatchMultiple()
        {
            // try...catch block with the multiple catches
            try
            {
                ContainerCauseException();
            }
            catch (IndexOutOfRangeException) // this catch will only catch this type of exception
            {
                Console.WriteLine("You can't add that!");
            }
            catch   // this is a catch all others
            {
                Console.WriteLine("Something bad happened");
            }

            Console.WriteLine("can I keep running?");
        }

        public static void ContainerCatchExceptionObject()
        {
            try
            {
                ContainerCauseException();
            }
            // declaring variable gives access to exception object
            // here iex represents the IndexOutOfRangeException exception object
            catch (IndexOutOfRangeException iex)
            {
                Console.WriteLine(iex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something bad happened");
            }
        }

        public static void ContainerFinallyBlock()
        {
            try
            {
                ContainerCauseException();

                // this line will not be reached since it is after the exception
                Console.WriteLine("Should not see me");

                // when an exception is thrown execution is interrupted
                // no code within the try block will be executed after an exception is thrown. 
            }
            catch (IndexOutOfRangeException iex)
            {
                Console.WriteLine(iex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something bad happened");
            }
            finally
            {
                // this always get's executed
                Console.WriteLine("Always written");
            }

            // since we gracefully handle exceptions above this will get executed. 
            Console.WriteLine("Also written because execution continues when exceptions caught");
        }

        public static void SpecificContainerDemo()
        {
            // created a container that will only allow a specific type of item
            // this container only holds potions
            PotionSatchel potions = new PotionSatchel();

            // adding a potion is fine and returns true
            Console.WriteLine($"Adding Healing Potion: {potions.AddItem(new HealingPotion())}");

            // adding a non potion item fails and returns false in this case
            Console.WriteLine($"Adding Short Sword: {potions.AddItem(new ShortSword())}");

        }

        public static void DIExample()
        {
            Samurai jack = new Samurai(new ShortSword());
            Console.WriteLine(jack.Attack("the bad guy"));

            Console.WriteLine(jack.SecondaryAttack("the evil doer's"));

            jack.SecondaryWeapon = new Shuriken();
            Console.WriteLine(jack.SecondaryWeapon);

            jack.PickupItem(new ShortSword());
            jack.PickupItem(new Shuriken());
        }
    }
}
