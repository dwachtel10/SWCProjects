using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Contacts.Data;
using Contacts.Models;

namespace Contacts.WebAPI.Controllers
{
    public class ContactsController : ApiController
    {
        public List<Contact> Get()
        {
            var repo = Factory.CreateContactRepository();
            return repo.GetAll();
        }

        public Contact Get(int id)
        {
            var repo = Factory.CreateContactRepository();
            return repo.GetById(id);
        }

        public HttpResponseMessage Post(Contact contact)
        {
            var repo = Factory.CreateContactRepository();
            repo.Add(contact);

            var response = Request.CreateResponse(HttpStatusCode.Created, contact);

            string uri = Url.Link("DefaultApi", new {id = contact.ContactID});
            response.Headers.Location = new Uri(uri);

            return response;
        }
    }
}
