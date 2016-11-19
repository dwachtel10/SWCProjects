using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrdersMVC.Models;

namespace OrdersMVC.Data
{
    public interface IStateRepository
    {
        List<State> GetAll();
        State GetById(string id);
    }
}
