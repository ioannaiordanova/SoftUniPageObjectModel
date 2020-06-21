using Core;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Google
{
    [TestFixture]
    public class BaseTest
    {
        public WebDriver Driver { get; set; }



        public void Initialize()
        {
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");
            //Driver = new RemoteWebDriver(new Uri("http://192.168.1.2:4444/wd/hub"), options);
            Driver = new WebDriver();
            Driver.Start(Browser.Chrome);
        }
    }
}
