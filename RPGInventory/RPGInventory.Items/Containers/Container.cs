using RPGInventory.Items.Containers.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Items.Containers
{
    public abstract class Container : Item
    {
        protected int Capacity;
        protected Item[] Items;
        protected int ItemIndex;

        public Container(int capacity)
        {
            this.Capacity = capacity;
            Items = new Item[capacity];

            Type = ItemType.Container;
        }

        public virtual bool AddItem(Item itemToAdd)
        {
            if (ItemIndex == Capacity)
            {
                // you can throw an exception type that already exists
                throw new IndexOutOfRangeException("capacity has been reached");
            }

            if (Items.Contains(itemToAdd))
            {
                // I can create my own exception object and throw it.
                throw new ContainerItemAlreadyExistsException();
            }

            Items[ItemIndex] = itemToAdd;
            ItemIndex++;
            return true;
        }

        public Item RemoveItem()
        {
            if (ItemIndex == 0)
            {
                return null;
            }

            ItemIndex--;
            Item item = Items[ItemIndex];
            Items[ItemIndex] = null;
            return item;
        }
    }
}
