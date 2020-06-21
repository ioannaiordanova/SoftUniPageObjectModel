using Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace Google.Pages.MainPage
{
    public partial class MainPage : BasePage
    {
        protected override string Url => "https://www.google.com";

      
        public MainPage(WebDriver driver) : base(driver)
        {
        }

        public string getSeleniumSiteURL()
        {
            var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Navigate().GoToUrl("http://www.seleniumhq.org");
            return driver.Url;
        }

    }
}
