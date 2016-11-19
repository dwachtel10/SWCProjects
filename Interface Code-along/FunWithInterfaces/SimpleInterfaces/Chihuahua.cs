using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaces
{
   public class Chihuahua : IDog
    {
        public string Name
            {get; private set; }

        public Chihuahua(string Name)
        {
            this.Name = Name;
        }
       

        public void Bark()
        {
            Console.WriteLine("Yip!");
        }

        public string GoForAWalk()
        {
            return "Going for a short walk.";
        }
    }
}
