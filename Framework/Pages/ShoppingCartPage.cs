using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class ShoppingCartPage
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.baldai1.lt/");
        }
        public static void ClickAddToCart()
        {
            string locator = "//*[@id=\"button_cart_518934\"]";
            Common.ClickElement(locator);
        }

        public static void ClickClosePopup()
        {
            string locator = "/html/body/div[6]/h1/span";
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
        }

        public static void ClickOnItemInHomePage()
        {
            string locator = "//*[@id=\"icons_149000518934\"]/div[1]/div/div[1]/div/a/img";
            Common.ClickElement(locator);
        }

        public static void ClickOpenShoppingCart()
        {
            string locator = "//*[@id=\"dropdown_166\"]/div/div[3]/div[1]/a";
            Common.ClickElement(locator);
        }

        public static void ClickDeclineCookies()
        {
            string locator = "//*[@id=\"CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll\"]";
            Common.ClickElement(locator);
        }

        public static void ClickOpenShoppingCartDropdown()
        {
            string locator = "//*[@id=\"sw_dropdown_166\"]/a/div[1]/div/svg";
            Common.ClickElement(locator);
        }
    }
}
