namespace Framework.Pages
{
    public class SearchInHomePage
    {
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
