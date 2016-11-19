using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrdersMVC.Models;
using OrdersMVC.Data.FileRepositories;

namespace OrdersMVC.BLL
{
    public class OrderOperations
    {
        public List<Order> GetAllOrders()
        {
            var repo = new OrderFileRepository();
            return repo.GetAll();
        }

        public Order GetOrderById(int id)
        {
            var repo = new OrderFileRepository();
            return repo.GetById(id);
        }

        public List<State> GetAllStates()
        {
            var repo = new StateFileRepository();
            return repo.GetAll();
        }

        public void Add(Order order)
        {
            var repo = new OrderFileRepository();
            repo.Add(order);
        }
    }
}
