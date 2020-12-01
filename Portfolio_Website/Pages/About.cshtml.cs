using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AboutNameSpace;

namespace Portfolio_Website.Pages
{
    public class AboutModel : PageModel
    {
        public List<About> abouts;
        public void OnGet()
        {
            abouts = Abouts.list;
        }
    }
}
