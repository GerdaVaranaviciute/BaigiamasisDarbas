namespace Framework.Pages
{
    public class HomePage
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

        public static void ClickButtonSearch()
        {
            string locator = "//*[@class=\"ty-search-magnifier\"]";
            Common.ClickElement(locator);
        }

        public static void ClickOpenShoppingCart()
        {
            string locator = "//*[@id=\"dropdown_166\"]/div/div[3]/div[1]/a";
            Common.ClickElement(locator);
        }

        public static void ClickOpenShoppingCartDropdown()
        {
            string locator = "//*[@id=\"sw_dropdown_166\"]";
            Common.ClickElement(locator);
        }

        public static void ClickOnItemInHomePage()
        {
            string locator = "//*[@id=\"icons_149000518934\"]/div[1]/div/div[1]/div/a/img";
            Common.ClickElement(locator);
        }
    }
}
