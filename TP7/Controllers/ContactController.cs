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

            List<Contact> listContact = contactService.getAll();
            ViewBag.List = ContactController.Filter(filter, listContact);
            return View();
        }

        [HttpPost]
        public ActionResult Add()
        {
            return View();
        }

        public static List<Contact> Filter(string filter, List<Contact> listContact)
        {
            List<Contact> listFilter = new List<Contact>();
            foreach (Contact con in listContact)
            {
                if (con.getFirstName().ToLower().Contains(filter.ToLower()) || con.getLastName().ToLower().Contains(filter.ToLower()) || con.getEmail().ToLower().Contains(filter.ToLower()) || con.getPhone().ToLower().Contains(filter.ToLower()))
                {
                    listFilter.Add(con);
                }
            }
            if (listFilter.Count == 0)
            {
                listFilter = listContact;
            }
            return listFilter;
        }
    }
}