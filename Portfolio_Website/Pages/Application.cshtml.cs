using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ApplicationNameSpace;

namespace Portfolio_Website.Pages
{
    public class ApplicationModel : PageModel
    {
        public List<Application> applications;

        public void OnGet()
        {
            applications = Applications.list;
        }
    }
}
