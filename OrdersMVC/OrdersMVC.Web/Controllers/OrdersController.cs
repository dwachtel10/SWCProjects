using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrdersMVC.BLL;
using OrdersMVC.Models;

namespace OrdersMVC.Web.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult All()
        {
            var ops = new OrderOperations();
            var orders = ops.GetAllOrders();

            return View(orders);
        }

        public ActionResult ViewOrder(int id)
        {
            var ops = new OrderOperations();
            var order = ops.GetOrderById(id);

            return View(order);
        }

        [HttpPost]
        public ActionResult ViewOrder2()
        {
            var orderId = int.Parse(Request.Form["thisId"]);

            var ops = new OrderOperations();
            var order = ops.GetOrderById(orderId);

            return View("ViewOrder", order);

        }

        public ActionResult Add()
        {
            return View(new Order());
        }
    }
}