using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace N11PageObjectTests.PageObjects
{
    public class ResultPage
    {
        IWebDriver driver;
        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='contentListing']/div/div/div[2]/div[3]/a[2]")]
        public IWebElement SecondPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='view']/ul/li[3]")]
        public IWebElement ThirtSamsungProductItem { get; set; }

        public string ThirtSamsungProductItemsID { get; set; }

        public string NavigateToProductDetailPage()
        {
            SecondPage.Click();
            string URL = "https://www.n11.com/arama?q=samsung&pg=2";
            try
            {
                if (driver.Url == URL)
                {
                    IWebElement item = ThirtSamsungProductItem.FindElement(By.CssSelector("span.textImg.followBtn"));
                    ThirtSamsungProductItemsID = "p-" + item.GetAttribute("data-productid");
                    item.Click();

                }
            }
            catch (Exception e)
            {

                throw;
            }

            return ThirtSamsungProductItemsID;

        }
    }
}
