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
            string locator = "//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']";
            Common.ClickElement(locator);
        }

        public static void ClickOnItemInHomePage()
        {
            string locator = "//*[@id='icons_149000518934']/div[1]/div/div[1]/div/a/img";
            Common.ClickElement(locator);
        }

        public class SearchSection
        {
            public static void EnterSearchText(string text)
            {
                string locator = "//*[@id='search_input']";
                Common.SendKeysToElement(locator, text);
            }

            public static void ClickButtonSearch()
            {
                string locator = "//*[@class='ty-search-magnifier']";
                Common.ClickElement(locator);
            }
        }

        public class UserSection
        {
            public static void ClickOpenShoppingCart()
            {
                string locator = "//*[@id='slide_cart_slide']//a[contains(@class,'btn--view_cart')]";
                Common.ClickElement(locator);
            }

            public static void ClickOpenShoppingCartDropdown()
            {
                string locator = "//*[@class='ty-dropdown-box']//*[@class='ty-minicart__block']";
                Common.ClickElement(locator);
            }
        }
    }
}
