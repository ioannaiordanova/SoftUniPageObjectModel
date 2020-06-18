using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DemoQA.Pages
{
    public class BasePage
    {
        protected virtual string Url { get; }
        public BasePage(WebDriver driver)
        {
            Driver = driver;
        }

        public WebDriver Driver { get; }

        public WebDriverWait Wait { get; }

        public void NavigateTo() {
            Driver.WrappedDriver.Navigate().GoToUrl(Url);
        }
     

        public void WaitForLoad(int timeoutSec = 15)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.WrappedDriver;
            WebDriverWait wait = new WebDriverWait(Driver.WrappedDriver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }
    }
}
