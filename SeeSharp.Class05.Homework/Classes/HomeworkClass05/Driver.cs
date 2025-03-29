using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClass05
{
    class Driver
    {
        public string Name { get; set; }
        public int Skill { get; set; }


        public Driver(string name, int skill)
        {
            Name = name;
            Skill = skill;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Skill: {Skill}";

        }

    }
}
