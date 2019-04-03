using N11PageObjectTests.BaseClass;
using N11PageObjectTests.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace N11PageObjectTests.TestScripts
{
    [TestFixture]
    public class Module1 : WebDriver
    {
        [Test]
        public void TestDemoForKeytorc()
        {
            var loginPage = new LoginPage(driver);
            loginPage.NavigateToHomePage();
            Thread.Sleep(5000);

            var searchPage = new SearchPage(driver);
            searchPage.NavigateToResultPage();
            Thread.Sleep(5000);

            var resultPage = new ResultPage(driver);
            var Id = resultPage.NavigateToProductDetailPage();
            Thread.Sleep(5000);

            var favoritePage = new FavoritePage(driver);
            favoritePage.NavigateToFavoriteList(Id);
            Thread.Sleep(5000);
        }
        
    }
}
