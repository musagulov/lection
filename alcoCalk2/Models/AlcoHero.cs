using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alcoCalk2.Models
{
    public class AlcoHero
    {
        string Name { get; }
        public int Age { get; }
        public int Weight { get; }
        public AlcoHero(string name, int age, int weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
    }
}
