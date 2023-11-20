
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Framework.Pages
{
    internal class Common
    {
        internal static IWebElement GetElement(string locator) 
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void ClickElement(string locator) 
        {
            GetElement(locator).Click();        
        }

        internal static void SendKeysToElement(string locator, string keys) 
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetText(string locator) 
        {
            return GetElement(locator).Text;
        }

        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(30));
            wait.Until(d => d.FindElement(By.XPath(locator)));
        }

        internal static void AddItem(string locatorSearbox,string locatorRunSearch,string locatorClickOnSearchedElement, string locatorAddToCart, string locatorGoToChekout, string text) 
        {
            SendKeysToElement(locatorSearbox, text);
            ClickElement(locatorRunSearch);
            ClickElement(locatorClickOnSearchedElement);
            ClickElement(locatorAddToCart);
            ClickElement(locatorGoToChekout);
        }
    }
}
