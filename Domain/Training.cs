using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowcaseBJJKelian
{
    public class Training
    {
        private DateTime date;
        private Teacher teacher;
        private Technique technique;
        private List<Student> students = new List<Student>();


        public Training(DateTime date, Teacher teacher, Technique technique)
        {
            this.date = date;
            this.teacher = teacher;
            this.technique = technique;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
    }
}
