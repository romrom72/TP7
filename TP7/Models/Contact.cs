using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP7.Models
{
    public class Contact
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

        public Contact(String firstName, String lastName, String email, String phone)
        {
            setFirstName(firstName);
            setLastName(lastName);
            setEmail(email);
            setPhone(phone);
        }
    }
}