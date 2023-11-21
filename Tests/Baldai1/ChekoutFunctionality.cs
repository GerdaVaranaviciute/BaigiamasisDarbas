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
            string expectedErrorMessage = "El pašto adresas neteisingas.";

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
            ChekoutPage.InputAddress("TEST");
            //ChekoutPage.ErrorMessage();
            //string actualErrorMessage = ChekoutPage.ErrorMessage();

            //Assert.That(actualErrorMessage, Is.EqualTo(expectedErrorMessage));
        }

        [Test]

        public void ProceedingWithThePaymentWithValidCustomerData()
        {
            //string expectedResult = "Jūsų užsakymas yra gautas";

            ChekoutPage.Open();
            ChekoutPage.ClickButtonDeclineCookies();
            ChekoutPage.AddItem("467169");
            ChekoutPage.ClickButtonGoToChekout();
            ChekoutPage.InputName("TEST");
            ChekoutPage.InputSurname("TEST");
            ChekoutPage.InputPhoneNumber("862222222");
            ChekoutPage.InputEmail("TEST@gmail.com");
            ChekoutPage.ClickCheckbox();
        }
        public void DiscountCodeUsage()
        {
            string expextedResult = "Pritaikyta nuolaida";

            ChekoutPage.Open();
            ChekoutPage.ClickButtonDeclineCookies();
            ChekoutPage.AddItem("467169");
            ChekoutPage.ClickButtonGoToChekout();
            ChekoutPage.ClickButtonAddDiscountCode();
            ChekoutPage.EnterDiscountCode("BLACK50");
            ChekoutPage.ClickApplyDiscountCode();
        }
    }
}
