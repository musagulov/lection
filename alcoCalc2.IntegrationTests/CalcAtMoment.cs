using Xunit;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace alcoCalc2.IntegrationTests
{
    public class CalcAtMoment
    {
        [Fact]
        public void DedTest()
        {
            //Arrange
            var client = new RestSharp.RestClient("http://34.67.210.8/");

            //Act
            var responce = client.Post(new RestRequest("/AlcoCalculate?name=Jennifer&age=99&weight=12&alcoGradus=2&alcoVolume=1000"));

            //Assert
            Assert.Equal("Дед Jennifer в таком возрасте 99 вам уже нельзя", JObject.Parse(responce.Content).SelectToken("responceText").Value<string>());
        }
    }
}
