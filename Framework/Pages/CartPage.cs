namespace Framework.Pages
{
    public class CartPage
    {
        public static string GetItemAddedToShoppingCart()
        {
            string locator = "//*[@id=\"cart_items\"]/table/tbody/tr[1]/td[2]/a[1]";
            return Common.GetText(locator);
        }
    }
}
