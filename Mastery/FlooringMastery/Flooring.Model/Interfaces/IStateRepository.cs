﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flooring.Models.Interfaces
{
    public interface IStateRepository
    {
        List<State> ListState(string StateName);
        State GetState(string StateName);
    }
}
