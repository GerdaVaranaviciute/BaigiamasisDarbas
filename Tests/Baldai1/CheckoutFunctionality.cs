using Framework.Pages;
using NUnit.Framework;

namespace Tests.Baldai1
{
    internal class CheckoutFunctionality : BaseTests
    {
        [Test]
        public void EmailErrorMessage()
        {
            string expectedErrorMessage = "Prašome įvesti tinkamą el. pašto adresą.";

            CheckoutPage.Open();
            CheckoutPage.ClickButtonDeclineCookies();
            CheckoutPage.EnterSearchText("467169");
            CheckoutPage.RunSearch();
            CheckoutPage.OpenFoundItem();
            CheckoutPage.ClickButtonAddToCart();
            CheckoutPage.ClickButtonGoToChekout();
            CheckoutPage.InputName("TEST");
            CheckoutPage.InputSurname("TEST");
            CheckoutPage.InputPhoneNumber("862222222");
            CheckoutPage.InputEmail("TEST");
            CheckoutPage.InputAddress("TEST");

            Assert.That(CheckoutPage.ActualErrorMessage(), Is.EqualTo(expectedErrorMessage));
        }

        [Test]
        public void ProceedWithThePaymentOnDeliveryMethodAfterEnteringValidCustomerData()
        {
            string expectedOrderConfirmation = "Jūsų užsakymas yra gautas";

            CheckoutPage.Open();
            CheckoutPage.ClickButtonDeclineCookies();
            CheckoutPage.AddItem("467169");
            CheckoutPage.ClickButtonGoToChekout();
            CheckoutPage.InputName("TEST");
            CheckoutPage.InputSurname("TEST");
            CheckoutPage.InputPhoneNumber("862222222");
            CheckoutPage.InputEmail("TEST@gmail.com");
            CheckoutPage.ClickCheckbox();
            CheckoutPage.ClickButtonPlaceOrder();

            Assert.That(CheckoutPage.ActualOrderConfirmation(), Is.EqualTo(expectedOrderConfirmation));
        }

        [Test]
        public void DiscountCodeUsage()
        {
            string expectedSuccesfulDiscount = "Pritaikyta nuolaida";

            CheckoutPage.Open();
            CheckoutPage.ClickButtonDeclineCookies();
            CheckoutPage.AddItem("467169");
            CheckoutPage.ClickButtonGoToChekout();
            CheckoutPage.ClickButtonAddDiscountCode();
            CheckoutPage.EnterDiscountCode("BLACK50");
            CheckoutPage.ClickApplyDiscountCode();

            Assert.That(CheckoutPage.ActualSuccesfulDiscount(), Is.EqualTo(expectedSuccesfulDiscount));
        }
    }
}
