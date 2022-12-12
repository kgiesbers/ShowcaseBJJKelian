using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Training
    {
        private DateTime date;
        private Teacher teacher;
        private Technique technique;
        private List<Student> students = new List<Student>();

        public DateTime Date
        {
            get { return date; }
        }
        public Teacher Teacher
        {
            get { return teacher; }
        }
        public Technique Technique
        {
            get { return technique; }
        }

        public Training(DateTime date, Teacher teacher, Technique technique)
        {
            this.date = date;
            this.teacher = teacher;
            this.technique = technique;
        }
    }
}
