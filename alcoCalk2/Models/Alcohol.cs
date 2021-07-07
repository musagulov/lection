using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alcoCalk2.Models
{
    public class Alcohol
    {
        public int Gradus { get; }
        public int Volume { get; set; }
        public Alcohol(int gradus, int volume = 0)
        {
            Gradus = gradus;
            Volume = volume;
        }

        public Alcohol AddVolume(int volume)
        {
            this.Volume += volume;
            return this;
        }
    }
}
