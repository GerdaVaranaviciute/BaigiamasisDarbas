using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests.Baldai1
{
    internal class SearchFunctionality
    {
        [Test]

        public void SearchInBaldai1() 
        {
            string expectedResult = "Lovos - Greitas ir nemokamas pristatymas | Baldai1.lt";

            Driver.InitializeDriver();
            SearchInHomePage.Open();
            SearchInHomePage.ClickButtonDeclineCookies();
            SearchInHomePage.EnterSearchText("LOVA");
            SearchInHomePage.RunSearch();
            string actualResult = Driver.GetSearchTitle();
            Driver.QuitDriver();

            Assert.AreEqual(expectedResult, actualResult);

        }



    }
}
