using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace N11PageObjectTests.BaseClass
{
    public class WebDriver
    {
        public IWebDriver driver;

        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url= "https://www.n11.com/";
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
