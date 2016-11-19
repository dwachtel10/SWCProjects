using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelValidation.Models;

namespace ModelValidation.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult MakeBooking()
        {
            return View(new Appointment() {Date = DateTime.Now});
        }
        [HttpPost]
        public ViewResult MakeBooking(Appointment appt)
        {
            if (string.IsNullOrEmpty(appt.ClientName))
            {
                ModelState.AddModelError("ClientName", "Please enter your name.");
            }
            if (!ModelState.IsValidField("Date") ||(ModelState.IsValidField("Date") && DateTime.Now > appt.Date))
            {
                ModelState.AddModelError("Date", "You cannot schedule an appointment in the past");
            }

            if (!appt.TermsAccepted)
            {
                ModelState.AddModelError("TermsAccepted", "You must accept the terms and conditions to continue.");
            }
            if (!ModelState.IsValidField("Time") || (ModelState.IsValidField("Time") && appt.Time < 0))
            {
                ModelState.AddModelError("Time", "Please enter how long you'd like your appointment to be.");
            }
            if (ModelState.IsValidField("ClientName") && ModelState.IsValidField("Date"))
            {
                if (appt.ClientName == "Garfield" && appt.Date.DayOfWeek == DayOfWeek.Monday)
                { ModelState.AddModelError("", "Garfield cannot be scheduled on Mondays.");}
            }
            if (ModelState.IsValid)
            {
                return View("Completed", appt);
            }
            //statements to store a new appointment in a repository would go here

            return View();
        }
    }
}