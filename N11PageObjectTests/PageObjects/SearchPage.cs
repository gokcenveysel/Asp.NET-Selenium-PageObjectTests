using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N11PageObjectTests.PageObjects
{
    public class SearchPage
    {
        IWebDriver driver;
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "searchData")]
        public IWebElement SearchBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".searchBtn")]
        public IWebElement SearchButton { get; set; }

        public void NavigateToResultPage()
        {
            SearchBox.SendKeys("samsung");
            SearchButton.Click();
        }
    }
}
