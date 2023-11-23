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

            Assert.That(ChekoutPage.actualErrorMessage(), Is.EqualTo(expectedErrorMessage));
        }

        [Test]
        public void ProceedWithThePaymentOnDeliveryMethodAfterEnteringValidCustomerData()
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

            Assert.That(ChekoutPage.ActualOrderConfirmation(), Is.EqualTo(expectedOrderConfirmation));
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

            Assert.That(ChekoutPage.ActualSuccesfulDiscount(), Is.EqualTo(expectedSuccesfulDiscount));
        }
    }
}
