using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using N11PageObjectTests.PageObjects;

namespace N11PageObjectTests.PageObjects
{
    public class FavoritePage
    {
        IWebDriver driver;
        public FavoritePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='header']/div/div/div[2]/div[2]/div[2]/div/a")]
        public IWebElement AccountButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='myAccount']/div[1]/div[1]/div[2]/ul/li[5]/a")]
        public IWebElement MyFavorite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='myAccount']/div[3]/ul/li[1]/div/a")]
        public IWebElement MyFavoriteList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='view']/ul/li")]
        public IWebElement DeleteBtnItem { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div/span")]
        public IWebElement OkBtnAfterDeleteFavorite { get; set; }

        public void NavigateToFavoriteList(string Id)
        {
            AccountButton.Click();
            MyFavorite.Click();
            MyFavoriteList.Click();
            bool visible = IsElementVisible(DeleteBtnItem.FindElement(By.XPath("//*[@id='" + Id + "']/div[3]/span")));

            if(visible)
            {
                DeleteBtnItem.FindElement(By.XPath("//*[@id='" + Id + "']/div[3]/span")).Click();
                OkBtnAfterDeleteFavorite.Click();
            }
            else
            {
                AccountButton.Click();
            }            
        }
        public bool IsElementVisible(IWebElement element)
        {
            return element.Displayed && element.Enabled;
        }
    }
}
