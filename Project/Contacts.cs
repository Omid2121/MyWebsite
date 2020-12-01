using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsNameSpace
{
    public class Contact
    {
        public string Email { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }
        public string EmailLogo { get; set; }
        public string PhoneLogo { get; set; }
        public string AddressLogo { get; set; }
    }

    public static class Contacts
    {
        public static List<Contact> list = new List<Contact>
        {
            new Contact
            {
                Email = "omid_ahangi2000@yahoo.com",
                Number = "+45 27 15 94 27",
                Address = "Brøderslev 9700, Denmark",
                EmailLogo = "far fa-envelope",
                PhoneLogo = "fas fa-phone",
                AddressLogo = "fas fa-map-marker-alt",
            }
        };
    }
}
