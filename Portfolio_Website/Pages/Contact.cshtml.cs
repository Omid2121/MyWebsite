using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContactsNameSpace;

namespace Portfolio_Website.Pages
{
    public class ContactModel : PageModel
    {
        public List<Contact> contacts;

        public void OnGet()
        {
            contacts = Contacts.list;
        }
    }
}
