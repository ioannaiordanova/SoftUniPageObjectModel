using OpenQA.Selenium;

namespace Google.Pages.MainPage
{
    public partial class MainPage : BasePage
    {
        public IWebElement SearchField => Driver.FindElement(By.CssSelector("[name = 'q']"));
        public IWebElement FirstResultLink => Wait.Until<IWebElement>(d => d.FindElement(By.CssSelector(".g .r a")));
    }
}
