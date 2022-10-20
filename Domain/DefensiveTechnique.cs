using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DefensiveTechnique : Technique
    {
        public DefensiveTechnique(string name, Difficulty difficulty) : base(name, difficulty)
        {
        }
    }
}

