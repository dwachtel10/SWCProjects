﻿using RockPaperScissors.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Players
{
    public interface IChoiceSelector
    {
        Choice GetChoice();
    }
}
