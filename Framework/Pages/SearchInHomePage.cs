namespace Framework.Pages
{
    public class SearchInHomePage
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
    }
}
