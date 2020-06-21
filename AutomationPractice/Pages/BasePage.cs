using Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationPractice.Pages
{
    public abstract class BasePage
    {
        protected abstract string Url { get; }
        public BasePage(WebDriver driver)
        {
            Driver = driver;
        }

        public WebDriver Driver { get; }

        public WebDriverWait Wait { get; }

        public void NavigateTo()
        {
            Driver.GoToUrl(Url);
        }

        public WebElement ScrollTo(WebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element.WrappedElement);
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
