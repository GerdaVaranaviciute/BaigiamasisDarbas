using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests.Baldai1
{
    internal class SearchFunctionality : BaseTests
    {
        [Test]
        public void SearchInBaldai1() 
        {
            string expectedResult = "Lovos - Greitas ir nemokamas pristatymas | Baldai1.lt";

            HomePage.Open();
            SearchInHomePage.ClickButtonDeclineCookies();
            SearchInHomePage.EnterSearchText("LOVA");
            SearchInHomePage.RunSearch();
            string actualResult = Driver.GetSearchTitle();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
