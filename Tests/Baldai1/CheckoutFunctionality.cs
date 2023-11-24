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

            HomePage.Open();
            HomePage.ClickButtonDeclineCookies();
            CheckoutPage.EnterSearchText("467169");
            CheckoutPage.ClickButtonSearch();
            CheckoutPage.OpenFoundItem();
            CheckoutPage.ClickButtonAddToCart();
            CheckoutPage.ClickButtonGoToChekout();
            CheckoutPage.EnterName("TEST");
            CheckoutPage.EnterSurname("TEST");
            CheckoutPage.EnterPhoneNumber("862222222");
            CheckoutPage.EnterEmail("TEST");
            CheckoutPage.EnterAddress("TEST");

            Assert.That(CheckoutPage.GetErrorMessage(), Is.EqualTo(expectedErrorMessage));
        }

        [Test]
        public void ProceedWithThePaymentOnDeliveryMethodAfterEnteringValidCustomerData()
        {
            string expectedOrderConfirmation = "Jūsų užsakymas yra gautas";

            HomePage.Open();
            HomePage.ClickButtonDeclineCookies();
            CheckoutPage.AddItem("467169");
            CheckoutPage.ClickButtonGoToChekout();
            CheckoutPage.EnterName("TEST");
            CheckoutPage.EnterSurname("TEST");
            CheckoutPage.EnterPhoneNumber("862222222");
            CheckoutPage.EnterEmail("TEST@gmail.com");
            CheckoutPage.ClickCheckbox();
            CheckoutPage.ClickButtonPlaceOrder();

            Assert.That(CheckoutPage.GetOrderConfirmation(), Is.EqualTo(expectedOrderConfirmation));
        }

        [Test]
        public void DiscountCodeUsage()
        {
            string expectedSuccesfulDiscount = "Pritaikyta nuolaida";

            HomePage.Open();
            HomePage.ClickButtonDeclineCookies();
            CheckoutPage.AddItem("467169");
            CheckoutPage.ClickButtonGoToChekout();
            CheckoutPage.ClickButtonAddDiscountCode();
            CheckoutPage.EnterDiscountCode("BLACK50");
            CheckoutPage.ClickApplyDiscountCode();

            Assert.That(CheckoutPage.GetSuccesfulDiscountMessage(), Is.EqualTo(expectedSuccesfulDiscount));
        }
    }
}
