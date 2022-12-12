using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace ShowcaseBJJKelian
{
    public abstract class Technique
    {
        private string name;
        private Difficulty difficulty;

        public string Name
        {
            get { return name; }
        }
        public Difficulty Difficulty
        {
            get { return difficulty; }
        }

        public Technique(string name, Difficulty difficulty)
        {
            this.name = name;
            this.difficulty = difficulty;
        }
    }
}
