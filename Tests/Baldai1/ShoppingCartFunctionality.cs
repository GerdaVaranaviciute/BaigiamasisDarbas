using Framework.Pages;
using NUnit.Framework;

namespace Tests.Baldai1
{
    internal class ShoppingCartFunctionality : BaseTest
    {
        [Test]
        public void AddItemToShoppingCart() 
        {
            string expectedItemAddedToShoppingCart = "Minkštas kampas Delaware 100 (Alova 10 + Alova 04)";

            HomePage.Open();
            HomePage.ClickButtonDeclineCookies();
            ShoppingCartPage.ClickOnItemInHomePage();
            ShoppingCartPage.ClickAddToCart();
            ShoppingCartPage.ClickClosePopup();
            ShoppingCartPage.ClickOpenShoppingCartDropdown();
            ShoppingCartPage.ClickOpenShoppingCart();

            Assert.That(expectedItemAddedToShoppingCart, Is.EqualTo(ShoppingCartPage.GetItemAddedToShoppingCart()));
        
        }
    }
}
