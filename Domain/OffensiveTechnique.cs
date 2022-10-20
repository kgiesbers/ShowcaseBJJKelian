using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class OffensiveTechnique : Technique
    {
        public OffensiveTechnique(string name, Difficulty difficulty) : base(name, difficulty)
        {
        }
    }
}
