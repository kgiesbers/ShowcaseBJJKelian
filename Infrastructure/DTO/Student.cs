using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowcaseBJJKelian
{
    public class Student
    {
        private string name;
        private Beltlevel beltlevel;

        public Student(string name,  Beltlevel beltlevel)
        {
            this.name = name;
            this.beltlevel = beltlevel;
        }
    }
}
