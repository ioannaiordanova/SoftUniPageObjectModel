using NUnit.Framework;

namespace Google.Pages.MainPage
{
    public partial class MainPage : BasePage
    {
        public void Assert_Found_WebSite() {

            Assert.Multiple(() =>
            {
                Assert.AreEqual(getSeleniumSiteURL(), Driver.Url, "URL");
                Assert.AreEqual(" Selenium - Web Browser Automation", Driver.Title, "WebSite's Title");
            });

        }
    }
}
