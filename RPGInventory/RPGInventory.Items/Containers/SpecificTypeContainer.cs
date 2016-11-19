using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Items.Containers
{
    public abstract class SpecificTypeContainer : Container
    {
        protected ItemType RequiredType;

        public SpecificTypeContainer(int capacity, ItemType requiredType)
            : base(capacity)
        {
            this.RequiredType = requiredType;
        }

        public override bool AddItem(Item itemToAdd)
        {
            if (itemToAdd.Type != RequiredType)
            {
                return false;
            }

            return base.AddItem(itemToAdd);
        }
    }
}
