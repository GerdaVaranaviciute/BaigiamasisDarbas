using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests.Baldai1
{
    internal class SearchFunctionality : BaseTests
    {
        [SetUp]
        public void SetUp()
        {
            SearchInHomePage.Open();
        }

        [Test]
        public void SearchInBaldai1() 
        {
            string expectedResult = "Lovos - Greitas ir nemokamas pristatymas | Baldai1.lt";

            SearchInHomePage.ClickButtonDeclineCookies();
            SearchInHomePage.EnterSearchText("LOVA");
            SearchInHomePage.RunSearch();
            string actualResult = Driver.GetSearchTitle();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
