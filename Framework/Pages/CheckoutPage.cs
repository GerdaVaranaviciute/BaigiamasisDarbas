namespace Framework.Pages
{
    public class CheckoutPage
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

        public static void OpenFoundItem()
        {
            string locator = "//*[@id=\"det_img_467169\"]";
            Common.ClickElement(locator);
        }

        public static void ClickButtonAddToCart()
        {
            string locator = "//*[@id=\"button_cart_467169\"]";
            Common.ClickElement(locator);
        }

        public static void ClickButtonGoToChekout()
        {
            string locator = "/html/body/div[5]/div/div[2]/div[2]/a";
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
        }

        public static void InputName(string text)
        {
            string locator = "//*[@id=\"litecheckout_firstname\"]";
            Common.SendKeysToElement(locator, text);
        }

        public static void InputSurname(string text)
        {
            string locator = "//*[@id=\"litecheckout_lastname\"]";
            Common.SendKeysToElement(locator, text);
        }

        public static void InputPhoneNumber(string text)
        {
            string locator = "//*[@id=\"litecheckout_phone\"]";
            Common.SendKeysToElement(locator, text);
        }

        public static void InputEmail(string text)
        {
            string locator = "//*[@id=\"litecheckout_email\"]";
            Common.SendKeysToElement(locator, text);
        }

        public static void AddItem(string text)
        {
            string locatorSearchbox = "//*[@id=\"search_input\"]";
            string locatorRunSearch = "//*[@class=\"ty-search-magnifier\"]";
            string locatorClickOnSearchedElement = "//*[@id=\"det_img_467169\"]";
            string locatorAddToCart = "//*[@id=\"button_cart_467169\"]";

            Common.SendKeysToElement(locatorSearchbox, text);
            Common.ClickElement(locatorRunSearch);
            Common.ClickElement(locatorClickOnSearchedElement);
            Common.ClickElement(locatorAddToCart);
        }

        public static void ClickCheckbox()
        {
            string locator = "//*[@id=\"litecheckout_terms\"]/div/div/label";
            if (!Common.IsElementSelected(locator))
            {
                Common.ClickElement(locator);
            }
        }

        public static void ClickButtonAddDiscountCode()
        {
            string locator = "//*[@id=\"checkout_info_summary_134\"]/table/tbody[1]/tr[4]/td/div[1]/span[1]";
            Common.ClickElement(locator);
        }

        public static void EnterDiscountCode(string text)
        {
            string locator = "//*[@id=\"coupon_field\"]";
            Common.SendKeysToElement(locator, text);
        }

        public static void ClickApplyDiscountCode()
        {
            string locator = "//*[@id=\"promotion_input_field\"]/div/button";
            Common.ClickElement(locator);
        }

        public static void InputAddress(string text)
        {
            string locator = "//*[@id=\"litecheckout_s_address\"]";
            Common.SendKeysToElement(locator, text);
        }

        public static string ActualErrorMessage()
        {
            string locator = "//*[@id=\"litecheckout_email_error_message\"]";
            return Common.GetText(locator);
        }

        public static string ActualOrderConfirmation()
        {
            string locator = "//*[@id=\"breadcrumbs_10\"]/div/span[2]";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetText(locator);
        }

        public static void ClickButtonPlaceOrder()
        {
            string locator = "//*[@id=\"litecheckout_place_order\"]";
            Common.ClickElement(locator);
        }

        public static string ActualSuccesfulDiscount()
        {
            string locator = "//*[@id=\"applied_promotions\"]/span";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetText(locator);
        }
    }
}
