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
            string locator = "/html/body/div[5]/div/div[2]/div[2]/a";
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
