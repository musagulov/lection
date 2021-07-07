using alcoCalk2.Controllers;
using Xunit;

namespace alcoCalc2.Tests
{    
    public class AlcoCalculateControllerTest
    {
        [Theory]
        [InlineData("Серго",76, 75, 75, 100)]
        [InlineData("Олег", 99, 10, 70, 58)]
        public void DedTest(string name, int age, int weight, int alcoGradus, int alcoVolume)
        {
            //Arrange
            var controller = new AlcoCalculateController();

            //Act
            var resploce = controller.Post(name, age, weight, alcoGradus, alcoVolume);

            //Assert
            Assert.Equal($"Дед {name} в таком возрасте {age} вам уже нельзя", resploce.responceText);
        }
    }
}
