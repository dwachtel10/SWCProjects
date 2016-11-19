using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contacts.Data;
using Contacts.Models;

namespace Contacts.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var repo = Factory.CreateContactRepository();
            var contacts = repo.GetAll();

            return View(contacts);
        }

        public ActionResult AddContact()
        {
            return View(new Contact());
        }

        [HttpPost]
        public ActionResult AddContact(Contact newContact)
        {
            var repo = Factory.CreateContactRepository();
            repo.Add(newContact);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteContact()
        {
            int contactID = int.Parse(Request.Form["ContactId"]);

            var repo = Factory.CreateContactRepository();
            repo.Delete(contactID);

            return View("Index", repo.GetAll());
        }

        [HttpPost]
        public ActionResult EditContact(int id)
        {
            var repo = Factory.CreateContactRepository();
            var contact = repo.GetById(id);

            return View(contact);
        }

        public ActionResult EditContact(Contact contact)
        {
            var repo = Factory.CreateContactRepository();
            repo.Edit(contact);

            return RedirectToAction("Index");
        }

    }
}