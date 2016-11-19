using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Items.Containers.Exceptions
{
    // I can create my own exception type
    public class ContainerItemAlreadyExistsException : Exception
    {
        public ContainerItemAlreadyExistsException() : 
            base("This item is already in the container")
        {
            
        }
    }
}
