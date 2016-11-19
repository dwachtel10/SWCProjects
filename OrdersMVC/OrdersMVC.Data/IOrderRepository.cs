using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrdersMVC.Models;

namespace OrdersMVC.Data
{
    public interface IOrderRepository
    {
        List<Order> GetAll();
        Order GetById(int id);
        Order Add(Order newOrder);
        bool Delete(Order orderToDelete);
        Order Edit(Order orderToUpdate);
    }
}
