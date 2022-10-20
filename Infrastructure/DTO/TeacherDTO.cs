using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Teacher
    {
        private string name;

        public string Name
        {
            get { return name; }
        }

        public Teacher(string name)
        {
            this.name = name;
        }
    }
}
