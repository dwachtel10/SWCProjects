﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RPG.Inventory.Items.Containers;
using RPG.Inventory.Items.Potions;
using RPG.Inventory.Items;
using RPG.Inventory.Items.Weapons;
using RPG.Inventory.Items.Containers.Restrictions;

namespace RPGInventory.Tests
{
    [TestFixture]
    public class ContainerTest
    {
        [Test]
        public void CanAddItemToBackpack()
        {
            Backpack b = new Backpack();
            HealthPotion p = new HealthPotion();

            AddItemStatus actual = b.AddItem(p);
            Assert.AreEqual(AddItemStatus.Ok, actual);
        }

        [Test]
        public void CannotAddItemToFullBackpack()
        {
            Backpack p = new Backpack();
            GreatAxe g = new GreatAxe();

            p.AddItem(g);
            p.AddItem(g);
            p.AddItem(g);
            p.AddItem(g);

            AddItemStatus actual = p.AddItem(g);
            Assert.AreEqual(AddItemStatus.ContainerFull, actual);

        }
        [Test]
        public void CanRemoveItemFromBackpack()
        {
            Backpack b = new Backpack();
            HealthPotion p = new HealthPotion();

            b.AddItem(p);

            Item actual = b.RemoveItem();

            Assert.AreEqual(p, actual);
        }
        [Test]
        public void EmptyBagReturnsNull()
        {
            Backpack b = new Backpack();
            Item item = b.RemoveItem();

            Assert.IsNull(item);
        }
        [Test]
        public void PotionSatchelRequiresPotions()
        {
            PotionSatchel p = new PotionSatchel();
            HealthPotion h = new HealthPotion();
            GreatAxe g = new GreatAxe();

            Assert.AreEqual(AddItemStatus.Ok, p.AddItem(h));
            Assert.AreEqual(AddItemStatus.ItemWrongType, p.AddItem(g));
        }
        [Test]
        public void ItemTypeRestrictionWorks()
        {
            ItemTypeRestriction restriction = new ItemTypeRestriction(ItemType.Weapon);

            AddItemStatus result = restriction.AddItem(new HealthPotion(), null);

            Assert.AreEqual(AddItemStatus.ItemWrongType, result);
        }

        [Test]
        public void MaxWeightRestrictionWorks()
        {
            WetPaperBag bag = new WetPaperBag();

            AddItemStatus actual = bag.AddItem(new GreatAxe());

            Assert.AreEqual(AddItemStatus.ContainerOverweight, actual);
        }

        //[Test]
        //public void PotionSatchelOnlyAllowsPotions()
        //{
        //    PotionSatchel satchel = new PotionSatchel();
        //    GreatAxe axe = new GreatAxe();

        //    AddItemStatus result = satchel.AddItem(axe);
        //    Assert.AreEqual(AddItemStatus.ItemWrongType, result);

        //    HealthPotion potion = new HealthPotion();
        //    result = satchel.AddItem(potion);
        //    Assert.AreEqual(AddItemStatus.Success, result);
        //}

        //[Test]
        //public void WeightRestrictedBagRestrictsWeight()
        //{
        //    WetPaperSack sack = new WetPaperSack();
        //    HealthPotion potion = new HealthPotion();

        //    Assert.AreEqual(AddItemStatus.Success, sack.AddItem(potion));

        //    Sword sword = new Sword();
        //    Assert.AreEqual(AddItemStatus.ItemTooHeavy, sack.AddItem(sword));

        //    Item item = sack.RemoveItem();
        //    Assert.AreEqual(AddItemStatus.Success, sack.AddItem(sword));
        //}

        public static void Main(string[] args)
        {

        }
    }

}

