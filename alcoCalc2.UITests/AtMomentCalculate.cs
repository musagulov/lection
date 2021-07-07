using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Xunit;
using OpenQA.Selenium.Support.UI;
using System;

namespace alcoCalc2.UITests
{
    public class AtMomentCalculate
    {
        [Fact]
        public void DedTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            driver.Navigate().GoToUrl("http://34.67.210.8/calc-at-moment");
            driver.FindElement(By.Id("name")).SendKeys("Володя");
            driver.FindElement(By.Id("age")).SendKeys("76");
            driver.FindElement(By.Id("weight")).SendKeys("80");
            driver.FindElement(By.Id("alcoGradus")).SendKeys("40");
            driver.FindElement(By.Id("alcoVolume")).SendKeys("1500");
            driver.FindElement(By.XPath("//form//button")).Click();
            Assert.True(driver.FindElement(By.XPath("//div[@class='alert alert-success']")).Displayed);
            Assert.Equal("Дед Володя в таком возрасте 76 вам уже нельзя", driver.FindElement(By.XPath("//div[@class='alert alert-success']//p")).Text);
            driver.Quit();
        }
    }
}
