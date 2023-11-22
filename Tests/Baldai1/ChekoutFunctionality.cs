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
            string expectedErrorMessage = "Prašome įvesti tinkamą el. pašto adresą.";

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

            Assert.That(expectedErrorMessage, Is.EqualTo(ChekoutPage.actualErrorMessage()));
        }

        [Test]
        public void ProceedingWithThePaymentWithValidCustomerData()
        {
            string expectedOrderConfirmation = "Jūsų užsakymas yra gautas";

            ChekoutPage.Open();
            ChekoutPage.ClickButtonDeclineCookies();
            ChekoutPage.AddItem("467169");
            ChekoutPage.ClickButtonGoToChekout();
            ChekoutPage.InputName("TEST");
            ChekoutPage.InputSurname("TEST");
            ChekoutPage.InputPhoneNumber("862222222");
            ChekoutPage.InputEmail("TEST@gmail.com");
            ChekoutPage.ClickCheckbox();
            ChekoutPage.ClickButtonPlaceOrder();

            Assert.That(expectedOrderConfirmation, Is.EqualTo(ChekoutPage.ActualOrderConfirmation()));
        }

        [Test]
        public void DiscountCodeUsage()
        {
            string expectedSuccesfulDiscount = "Pritaikyta nuolaida";

            ChekoutPage.Open();
            ChekoutPage.ClickButtonDeclineCookies();
            ChekoutPage.AddItem("467169");
            ChekoutPage.ClickButtonGoToChekout();
            ChekoutPage.ClickButtonAddDiscountCode();
            ChekoutPage.EnterDiscountCode("BLACK50");
            ChekoutPage.ClickApplyDiscountCode();

            Assert.That(expectedSuccesfulDiscount, Is.EqualTo(ChekoutPage.ActualSuccesfulDiscount()));
        }
    }
}
