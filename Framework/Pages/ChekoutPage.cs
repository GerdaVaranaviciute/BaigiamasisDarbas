using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Framework.Pages
{
    public class ChekoutPage
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.baldai1.lt/");
        }
        public static void ClickButtonDeclineCookies()
        {
            string locator = "//*[@id=\"CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll\"]";
            Common.ClickElement(locator);
        }

        public static void EnterSearchText(string text)
        {
            string locator = "//*[@id=\"search_input\"]";
            Common.SendKeysToElement(locator, text);
        }

        public static void RunSearch()
        {
            string locator = "//*[@class=\"ty-search-magnifier\"]";
            Common.ClickElement(locator);
        }

        public static void OpenFoundItem()
        {
            string locator = "//*[@id=\"det_img_467169\"]";
            Common.ClickElement(locator);
        }

        public static void ClickButtonAddToCart()
        {
            string locator = "//*[@id=\"button_cart_467169\"]";
            Common.ClickElement(locator);
        }

        public static void ClickButtonGoToChekout()
        {
            string locator = "/html/body/div[6]/div/div[2]/div[2]/a";
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
        }

        public static void InputName(string text)
        {
            string locator = "//*[@id=\"litecheckout_firstname\"]";
            Common.SendKeysToElement(locator, text);
        }

        public static void InputSurname(string text)
        {
            string locator = "//*[@id=\"litecheckout_lastname\"]";
            Common.SendKeysToElement(locator, text);
        }

        public static void InputPhoneNumber(string text)
        {
            string locator = "//*[@id=\"litecheckout_phone\"]";
            Common.SendKeysToElement(locator, text);
        }

        public static void InputEmail(string text)
        {
            string locator = "//*[@id=\"litecheckout_email\"]";
            Common.SendKeysToElement(locator, text);
        }

        public static void AddItem(string text)
        {
            string locatorSearbox = "//*[@id=\"search_input\"]";
            string locatorRunSearch = "//*[@class=\"ty-search-magnifier\"]";
            string locatorClickOnSearchedElement = "//*[@id=\"det_img_467169\"]";
            string locatorAddToCart = "//*[@id=\"button_cart_467169\"]";
            string locatorGoToChekout = "/html/body/div[6]/div/div[2]/div[2]/a";

            Common.SendKeysToElement(locatorSearbox, text);
            Common.ClickElement(locatorRunSearch);
            Common.ClickElement(locatorClickOnSearchedElement);  
            Common.ClickElement(locatorAddToCart);
            Common.ClickElement(locatorGoToChekout);
        }
    }
}
