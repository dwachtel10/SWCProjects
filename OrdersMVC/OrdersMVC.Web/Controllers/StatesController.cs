using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrdersMVC.BLL;

namespace OrdersMVC.Web.Controllers
{
    public class StatesController : Controller
    {
        // GET: States
        public ActionResult Index()
        {
            var ops = new OrderOperations();
            var states = ops.GetAllStates();

            return View(states);
        }
    }
}