using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowcaseBJJKelian
{
    public class Teacher
    {
        private string name;
        private List<Note> notes = new List<Note>();

        public string Name
        {
            get { return name; }
        }
        

        public Teacher(string name)
        {
            this.name = name;
        }

        private void CreateTraining(DateTime date, Teacher teacher, Technique technique)
        {
            Training training = new Training(date, teacher, technique);            
        }

        void AddNote(Note note)
        {
            notes.Add(note);
        }
    }
}
