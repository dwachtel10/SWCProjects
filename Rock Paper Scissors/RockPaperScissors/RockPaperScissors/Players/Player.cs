using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;

namespace RockPaperScissors.Players
{
    public abstract class Player : IChoiceSelector
    {
        public string Name { get; }

        public Player(string Name)
        {
            this.Name = Name;
        }
        public abstract Choice GetChoice();
        
    }
}
