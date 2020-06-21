using Core;
using OpenQA.Selenium;

namespace AutomationPractice.Pages
{
    public partial class AutomationPractice : BasePage
    {
        public WebElement LoginButton => Driver.FindElement(By.ClassName("login"));
    }
}
