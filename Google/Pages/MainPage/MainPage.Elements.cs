using Core;
using OpenQA.Selenium;

namespace Google.Pages.MainPage
{
    public partial class MainPage : BasePage
    {
        public WebElement SearchField => Driver.FindElement(By.CssSelector("[name = 'q']"));
        public WebElement FirstResultLink => Driver.FindElement(By.CssSelector(".g .r a h3"));
    }
}
