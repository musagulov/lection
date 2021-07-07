using alcoCalk2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace alcoCalk2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlcoCalculateController
    {
        [HttpPost]
        public CalcResponce Post(string name, int age, int weight, int alcoGradus, int alcoVolume)
        {
            if (age > 75)
                return new CalcResponce($"Дед {name} в таком возрасте {age} вам уже нельзя");
            if (age < 15)
                return new CalcResponce("Э щегол, до 15 лет хоть каплю попробуешь до15 лет не доживешь");
            var hero = new AlcoHero(name, age, weight);
            var alcohol = new Alcohol(alcoGradus, alcoVolume);
            var stage = new StageCalculator(hero, alcohol).CalcStage();

            if (stage <= 2)
            {
                return new CalcResponce("Как чай с прокисшем варением");
            }
            if (stage <= 10)
            {
                return new CalcResponce("Весело задорно без последствий");
            }
            if (stage <= 20)
            {
                return new CalcResponce("Увлекательно возможно с последствиями головными болями");
            }
            if (stage <= 50)
            {
                return new CalcResponce("Сознание пару раз ребутнется");
            }
            if (stage <= 60)
            {
                return new CalcResponce("Легендарно, несколько дней будет стыдно, возможно потребуется многодневное востановление");
            }
            return new CalcResponce("Тэбе пызда");
        }
    }

    
}
