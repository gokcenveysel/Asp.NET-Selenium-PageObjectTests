using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace N11PageObjectTests.PageObjects
{
    public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='header']/div/div/div[2]/div[2]/div[2]/div/a")]
        public IWebElement AccountButton { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement UsernameInput { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement PasswordInput { get; set; }

        [FindsBy(How = How.Id, Using = "loginButton")]
        public IWebElement LoginButton { get; set; }

        public void NavigateToHomePage()
        {
            AccountButton.Click();
            UsernameInput.SendKeys("gokcenveysel@gmail.com");
            PasswordInput.SendKeys("vycll1985");
            LoginButton.Click();
        }
    }
}
