using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Framework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        private static List<IWebElement> GetElements(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator)).ToList();
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void ClickElementByIndex(string locator, int zeroBasedIndex)
        {
            List<IWebElement> elements = GetElements(locator);
            elements[zeroBasedIndex].Click();
        }

        internal static void SendKeysToElement(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static string GetElementTextByIndex(string locator, int zeroBasedIndex)
        {
            List<IWebElement> elements = GetElements(locator);
            return elements[zeroBasedIndex].Text;
        }

        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.XPath(locator)));
        }

        internal static bool IsElementSelected(string locator)
        {
            return GetElement(locator).Selected;
        }
    }
}
