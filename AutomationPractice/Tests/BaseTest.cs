using Core;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;

namespace AutomationPractice.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected WebDriver Driver { get; set; }

        public void Initialize()
        {
            Driver = new WebDriver();
            Driver.Start(Browser.Chrome);
        }
    }
}
