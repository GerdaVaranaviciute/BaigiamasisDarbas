namespace Framework.Pages
{
    public class ProductPage
    {
        public static void ClickButtonAddToCart()
        {
            string locator = "//*[contains(@id,'button_cart')]";
            Common.ClickElement(locator);
        }

        public static void ClickButtonGoToChekout()
        {
            string locator = "//*[contains(@class,'btn__primary') and contains(@class,'cm-notification-close')]";
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
        }

        public static void ClickCloseOptionToCheckout()
        {
            string locator = "//h1//*[contains(@class,'cm-notification-close')]";
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
        }
    }
}
