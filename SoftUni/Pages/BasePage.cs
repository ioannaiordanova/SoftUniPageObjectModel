using Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SoftUni.Pages
{
    public abstract class BasePage
    {
        protected abstract string Url { get; }
        public BasePage(WebDriver driver)
        {
            Driver = driver;
        }

        public void NavigateTo()
        {
            Driver.GoToUrl(Url);
        }

        public WebDriver Driver { get; }


        public IWebElement ScrollTo(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            return element;
        }

        public void WaitForLoad(int timeoutSec = 15)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.WrappedDriver;
            WebDriverWait wait = new WebDriverWait(Driver.WrappedDriver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }
    }
}
