using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowcaseBJJKelian
{
    internal class Dojo
    {
        private string name;
        private List<Teacher> teachers = new List<Teacher>();
        private List<Student> students = new List<Student>();
        private List<Technique> techniques = new List<Technique>();
        private List<Training> trainings = new List<Training>();

        public Dojo(string name)
        {
            this.name = name;
        }

        void addTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }
        void addStudent(Student student)
        {
            students.Add(student);
        }
        void addTechnique(Technique technique)
        {
            techniques.Add(technique);
        }
        void addTraining(Training training)
        {
            trainings.Add(training);
        }
    }
}
