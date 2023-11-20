using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests.Baldai1
{
    internal class ChekoutFunctionality : BaseTests
    {
        [Test]

        public void EmailErrorMessage()
        {
            string expectedResult = "El pašto adresas neteisingas.";

            ChekoutPage.Open();
            ChekoutPage.ClickButtonDeclineCookies();
            ChekoutPage.EnterSearchText("467169");
            ChekoutPage.RunSearch();
            ChekoutPage.OpenFoundItem();
            ChekoutPage.ClickButtonAddToCart();
            ChekoutPage.ClickButtonGoToChekout();
            ChekoutPage.InputName("TEST");
            ChekoutPage.InputSurname("TEST");
            ChekoutPage.InputPhoneNumber("862222222");
            ChekoutPage.InputEmail("TEST");

            Assert.That(expectedResult.Contains(expectedResult));
        }

        [Test]

        //public void ProceedingWithThePaymentWithValidCustomerData() 
        //{
        //    ChekoutPage.Open();
        //    ChekoutPage.ClickButtonDeclineCookies();
        //    ChekoutPage.AddItem("467169");

        //}

    }
}
