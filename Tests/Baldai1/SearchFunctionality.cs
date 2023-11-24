using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests.Baldai1
{
    internal class SearchFunctionality : BaseTest
    {
        [Test]
        public void SearchInBaldai1() 
        {
            string expectedResult = "Lovos - Greitas ir nemokamas pristatymas | Baldai1.lt";

            HomePage.Open();
            HomePage.ClickButtonDeclineCookies();
            SearchInHomePage.EnterSearchText("LOVA");
            SearchInHomePage.RunSearch();
            string actualResult = Driver.GetSearchTitle();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
