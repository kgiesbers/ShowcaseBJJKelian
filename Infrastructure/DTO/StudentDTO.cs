using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Student
    {
        private string firstname;
        private string lastname;
        private Beltlevel beltlevel;

        public string Firstname
        {
            get { return firstname; }
        }
        public string Lastname
        {
            get { return lastname; }
        }
        public Beltlevel Beltlevel
        {
            get { return beltlevel; }
        }

        public Student(string firstname, string lastname, Beltlevel beltlevel)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.beltlevel = beltlevel;
        }
    }
}
