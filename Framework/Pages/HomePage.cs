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
    }
}
