using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowcaseBJJKelian
{
    public class Technique
    {
        private string name;
        private Difficulty difficulty;

        public Technique(string name, Difficulty difficulty)
        {
            this.name = name;
            this.difficulty = difficulty;
        }
    }
}
