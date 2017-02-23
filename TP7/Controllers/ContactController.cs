using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP7.Models;

namespace TP7.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.List = ContactController.GetAll();
            return View();
        }

        [HttpPost]
        public ActionResult Index(string filter)
        {
            ViewBag.Filter = filter;
            ViewBag.List = ContactController.Filter(filter);
            return View();
        }

        public static List<Contact> GetAll()
        {
            List<Contact> Contacts = new List<Contact>();
            string[] FirtName = new string[] { "Dolphi", "Dobi", "Rollo", "Legolas", "abraham", "Donald", "Dolan", "adolfo", "adolph", "adrian" };
            string[] LastName = new string[] { "Le dauphin", "Le nain", "Le gland", "Durand", "King of the north", "Grincheux", "Potté", "chaussettes", "Pim", "Poum" };
            Random rnd = new Random();
            Random rand = new Random(100);
            for (int i = 0; i < 10; i++)
            {
                Contact people = new Contact();
                people.FirstName = FirtName[i];
                people.LastName = LastName[i];
                people.Email = FirtName[i] + "." + LastName[i] + "@mail.fr";
                int tel = rand.Next(000000000, 999999999);
                people.Phone = tel.ToString();
                Contacts.Add(people);
            }
            return Contacts;
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