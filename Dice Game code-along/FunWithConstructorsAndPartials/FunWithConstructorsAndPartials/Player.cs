using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithConstructorsAndPartials
{
    public partial class Player
    {
        //properties
        public string Name { get; set; }
        public int Score { get; set; }

        //default constructor

        public Player()
        {
            Name = "New Player";

        }
    }
}
