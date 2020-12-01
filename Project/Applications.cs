using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationNameSpace
{
    public class Application
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public string Logo { get; set; }

    }

    public static class Applications
    {
        public static List<Application> list = new List<Application>
        {
            new Application
            {
                Name = "Application",
                Link = "~/applications/Application.pdf",
                Logo = "fa fa-file-pdf-o",
            },
            new Application
            {
               
                Name = "CV",
                Link = "~/applications/CV.pdf",
                Logo = "fa fa-file-pdf-o",

            }
        };
    }
}
