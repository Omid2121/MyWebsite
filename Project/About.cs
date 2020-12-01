using System;
using System.Collections.Generic;
using System.Text;

namespace AboutNameSpace
{
    public class About
    {
        public string Image { get; set; }
        public string HeadingName { get; set; }
        public string Text { get; set; }
    }
    public static class Abouts
    {
        public static List<About> list = new List<About>
        {
            new About
            {
                HeadingName = "Omidreza Ahangi",
            },
            new About
            {
                HeadingName = "Uddannelse",
                Text = "Om min uddannelse.",
            },
            new About
            {
                HeadingName = "Om Mig",
                Text = "Om mig.",
            },
            new About
            {
                HeadingName = "Min fritid",
                Text = "Min fritider.",
                Image = "image/me.jpg",

            }
        };
    }
}
