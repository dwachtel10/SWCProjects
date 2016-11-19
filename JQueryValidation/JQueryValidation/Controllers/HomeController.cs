using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JQueryValidation.Models;

namespace JQueryValidation.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegistrationForm()
        {
            return View(new RsvpResponse());
        }

        [HttpPost]
        public ActionResult RegistrationForm(RsvpResponse model)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", model);
            }
            else
            {
                return View(model);
            }
        }
    }
}