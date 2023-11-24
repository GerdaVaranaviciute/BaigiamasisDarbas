namespace Framework.Pages
{
    public class SearchPage
    {
        public static void ClickFirstResultItem()
        {
            string locator = "//*[@class='ty-grid-list__image']";
            Common.ClickElementByIndex(locator, 0);
        }
    }
}
