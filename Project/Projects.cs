using System;
using System.Collections.Generic;

namespace ProjectsNamespace
{
    public class Project
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string DownloadBtn { get; set; }
    }

    public static class Projects
    {
        public static List<Project> list = new List<Project>
        {
            new Project
            {
                Image = "497_449074_management.hero.jpg",
                Name = "Lagersystem",
                Text = "Jeg lavet dette projekt til GUI/OOP H2 aflevering. Med dette program man kan tilføje enhed, redigere og slet det.",
                DownloadBtn = "",
            },
            new Project
            {
                Image = "497_449074_management.hero.jpg",
                Name = "Lommeregner",
                Text = "Jeg lavet dette projekt til H2 clientside aflevering, Det er en lommeregner som virker med javascript og jQuery.",
                DownloadBtn = "",
            },
            new Project
            {
                Image = "497_449074_management.hero.jpg",
                Name = "Pizzeria Menu",
                Text = "Jeg lavet dette project i skolepraktik, Det er en menu til pizzeria, man kan tilføje en item, redigere og slet.",
                DownloadBtn = "",
            }
        };
    }
}
