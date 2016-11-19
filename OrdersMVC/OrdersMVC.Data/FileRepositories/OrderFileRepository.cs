using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using OrdersMVC.Models;

namespace OrdersMVC.Data.FileRepositories
{
    public class OrderFileRepository : IOrderRepository
    {
        private string _fileName = "DataFiles/orders.txt";

        public OrderFileRepository()
        {
            // This code solves the problem between web and local file system.
            if (HttpContext.Current != null)
            {
                _fileName = HttpContext.Current.Server.MapPath("~/" + _fileName);
            }
        }

        public List<Order> GetAll()
        {
            List<Order> allOrders = new List<Order>();

            if (File.Exists(_fileName))
            {
                using (var reader = File.OpenText(_fileName))
                {
                    //read the header line
                    reader.ReadLine();

                    string inputLine;
                    while ((inputLine = reader.ReadLine()) != null)
                    {
                        var columns = inputLine.Split(',');
                        var order = new Order()
                        {
                            Id = int.Parse(columns[0]),
                            OrderDate = DateTime.Parse(columns[1]),
                            CustomerName = columns[2],
                            State = new State()
                            {
                                Abbreviation = columns[3],
                                Name = columns[4]
                            },
                            Total = decimal.Parse(columns[5])
                        };

                        allOrders.Add(order);
                    }
                }
            }

            return allOrders;
        }

        public Order GetById(int id)
        {
            return GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Order Add(Order newOrder)
        {
            // ternary operator is saying:
            // if there are any contacts return the max contact id and add 1 to set our new contact id
            // else set to 1
            newOrder.Id = (GetAll().Any()) ? GetAll().Max(c => c.Id) + 1 : 1;

            var orders = GetAll();
            orders.Add(newOrder);

            WriteFile(orders);

            return newOrder;
        }

        public bool Delete(Order orderToDelete)
        {
            var orders = GetAll();
            orders.RemoveAll(c => c.Id == orderToDelete.Id);

            WriteFile(orders);

            return true;
        }

        public Order Edit(Order orderToUpdate)
        {
            var orders = GetAll();
            orders.RemoveAll(c => c.Id == orderToUpdate.Id);
            orders.Add(orderToUpdate);

            WriteFile(orders);

            return orderToUpdate;
        }

        private void WriteFile(List<Order> orders)
        {
            orders = orders.OrderBy(c => c.Id).ToList();
            using (var writer = new StreamWriter(_fileName, false))
            {
                writer.WriteLine("Id,OrderDate,CustomerName,StateAbbr,StateName,Total");

                foreach (Order order in orders)
                {
                    writer.WriteLine($"{order.Id},{order.OrderDate.ToString("MM/dd/yyyy")},{order.CustomerName},{order.State.Abbreviation},{order.State.Name},{order.Total}");
                }
            }
        }

    }
}
