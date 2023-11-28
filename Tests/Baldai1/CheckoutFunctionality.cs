using Framework.Pages;
using NUnit.Framework;

namespace Tests.Baldai1
{
    internal class CheckoutFunctionality : BaseTest
    {
        [SetUp]
        public void AddItemToCart()
        {
            HomePage.SearchSection.EnterSearchText("467169");
            HomePage.SearchSection.ClickButtonSearch();
            SearchPage.ClickFirstResultItem();
            ProductPage.ClickButtonAddToCart();
            ProductPage.ClickButtonGoToChekout();
        }

        [Test]
        public void EmailErrorMessage()
        {
            string expectedErrorMessage = "Prašome įvesti tinkamą el. pašto adresą.";

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

            CheckoutPage.EnterName("TEST");
            CheckoutPage.EnterSurname("TEST");
            CheckoutPage.EnterPhoneNumber("862222222");
            CheckoutPage.EnterEmail("TEST@gmail.com");
            CheckoutPage.ClickCheckboxTermsAndConditions();
            CheckoutPage.ClickButtonPlaceOrder();

            Assert.That(CheckoutPage.GetOrderConfirmation(), Is.EqualTo(expectedOrderConfirmation));
        }

        [Test]
        public void DiscountCodeUsage()
        {
            string expectedSuccesfulDiscount = "Pritaikyta nuolaida";

            CheckoutPage.ClickButtonAddDiscountCode();
            CheckoutPage.EnterDiscountCode("BLACK50");
            CheckoutPage.ClickApplyDiscountCode();

            Assert.That(CheckoutPage.GetSuccesfulDiscountMessage(), Is.EqualTo(expectedSuccesfulDiscount));
        }
    }
}
