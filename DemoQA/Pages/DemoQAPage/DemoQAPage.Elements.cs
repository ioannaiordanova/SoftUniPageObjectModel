using Core;
using OpenQA.Selenium;

namespace DemoQA.Pages
{
    public partial class DemoQAPage : BasePage
    {
        public WebElement Logo => Driver.FindElement(By.CssSelector("a[href*='demoqa.com']"));
    }
}
