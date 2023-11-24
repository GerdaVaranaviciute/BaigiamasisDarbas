namespace Framework.Pages
{
    public class CartPage
    {
        public static string GetTitleOfFirstItem()
        {
            string locator = "//*[contains(@class,'product-title')]";
            return Common.GetElementTextByIndex(locator, 0);
        }
    }
}
