using alcoCalk2.Controllers;
using alcoCalk2.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace alcoCalc2.Tests
{
    
    public class StageCalcTest
    {
        [Fact]
        public void StageCalc()
        {
            //Arrange
            var hero = new AlcoHero("Петя", 27, 50);
            var alcohol = new Alcohol(40, 2000);
            //Act
            var stageResult = new StageCalculator(hero, alcohol).CalcStage();
            //Assert
            Assert.Equal(59, stageResult);
        }
    }
}
