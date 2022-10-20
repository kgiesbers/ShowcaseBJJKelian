using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Dojo
    {
        private string name;
        private List<Teacher> teachers = new List<Teacher>();
        private List<Student> students = new List<Student>();
        private List<Technique> techniques = new List<Technique>();
        private List<Training> trainings = new List<Training>();

        public string Name
        {
            get { return name; }
        }

        public Dojo(string name)
        {
            this.name = name;
        }
    }
}
