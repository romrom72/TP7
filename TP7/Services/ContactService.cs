using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP7.Models;

namespace TP7.Services
{
    public class ContactService
    {
        public List<Contact> getAll()
        {
            List<Contact> listContact = new List<Contact>();

            listContact.Add(new Contact("Jean-Louis", "Kilo", "jean-louis@kedale.fr", "06.25.48.63.15"));
            listContact.Add(new Contact("Jean-Michel", "Stigmate", "jean-michel@kedale.fr", "06.94.23.21.58"));
            listContact.Add(new Contact("Charle-Edouard", "Denis", "charle-edouard@kedale.fr", "06.63.87.58.12"));
            listContact.Add(new Contact("Eddy", "Malou", "eddy@kedale.fr", "06.14.75.63.28"));
            listContact.Add(new Contact("Jean", "Robert", "jean@kedale.fr", "07.58.96.18.34"));
            listContact.Add(new Contact("Sylvain", "Duriff", "sylvain@kedale.fr", "07.58.63.18.74"));
            listContact.Add(new Contact("Francis", "Bidule", "francis@kedale.fr", "06.25.73.18.91"));
            listContact.Add(new Contact("Francine", "Kepouic", "francis@kedale.fr", "07.51.61.91.81"));
            listContact.Add(new Contact("Thomas", "Klaboune", "thomas@kedale.fr", "06.21.23.94.75"));
            listContact.Add(new Contact("François", "Hollande", "françois@kedale.fr", "07.15.94.63.74"));

            return listContact;
        }
    }
}