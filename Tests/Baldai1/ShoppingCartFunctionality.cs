﻿using Framework.Pages;
using NUnit.Framework;
using System.Security.AccessControl;

namespace Tests.Baldai1
{
    internal class ShoppingCartFunctionality : BaseTests
    {
        [Test]

        public void AddItemToShoppingCart() 
        {
            ShoppingCartPage.Open();
            ShoppingCartPage.ClickDeclineCookies();
            ShoppingCartPage.ClickOnItemInHomePage();
            ShoppingCartPage.ClickAddToCart();
            ShoppingCartPage.ClickClosePopup();
            ShoppingCartPage.ClickOpenShoppingCartDropdown();
            ShoppingCartPage.ClickOpenShoppingCart();

        
        }
    }
}