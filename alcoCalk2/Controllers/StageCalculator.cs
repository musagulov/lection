using alcoCalk2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alcoCalk2.Controllers
{
    public class StageCalculator
    {
        AlcoHero Hero { get; set; }
        Alcohol Alcohol { get; set; }
        public StageCalculator(AlcoHero hero, Alcohol alcohol)
        {
            Hero = hero;
            Alcohol = alcohol;
        }

        public float CalcStage()
        {
            var stage = Alcohol.Gradus * Alcohol.Volume / Hero.Weight;
            if (Hero.Age < 27)
                stage /= Hero.Age;
            else
                if (Hero.Age < 54)
                stage /= (54 - Hero.Age);
            return stage;
        }
    }
}
