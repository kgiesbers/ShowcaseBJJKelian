using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowcaseBJJKelian
{
    public class Student
    {
        private string firstname;
        private string lastname;
        private Beltlevel beltlevel;

        public Student(string firstname, string lastname, Beltlevel beltlevel)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.beltlevel = beltlevel;
        }
    }
}
