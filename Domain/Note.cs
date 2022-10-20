using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowcaseBJJKelian
{
    public class Note
    {
        private string title;
        private string description;

        public string Title
        {
            get { return title; }
        }
        public string Description
        {
            get { return description; }
        }

        public Note(string title, string description)
        {
            this.title = title;
            this.description = description;
        }
    }
}
