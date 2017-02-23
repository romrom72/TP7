using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP7.Models;
using TP7.Services;

namespace TP7.Controllers
{
    public class ContactController : Controller
    {
        ContactService contactService = new ContactService();

        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.List = contactService.getAll();
            return View();
        }

        [HttpPost]
        public ActionResult Index(string filter)
        {
            ViewBag.Filter = filter;
            ViewBag.List = ContactController.Filter(filter);
            return View();
        }

        public static List<Contact> Filter(string filter)
        {
            List<Contact> gg = GetAll();
            List<Contact> Contacts = new List<Contact>();
            foreach (Contact con in gg)
            {
                if (con.FirstName.ToLower().Contains(filter.ToLower()) || con.LastName.ToLower().Contains(filter.ToLower()) || con.Email.ToLower().Contains(filter.ToLower()) || con.Phone.ToLower().Contains(filter.ToLower()))
                {
                    Contacts.Add(con);
                }
            }
            if (Contacts.Count == 0)
            {
                Contacts = GetAll();
            }
            return Contacts;
        }
    }
}