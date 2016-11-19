using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithConstructorsAndPartials
{
    public partial class Player
    {
        //constructor - with a parameter
        public Player(string Name)
        {
            //set the name to the parameter value
            this.Name = Name;
            //'this' is referring to instance of the class (object)
        }
    }
}
