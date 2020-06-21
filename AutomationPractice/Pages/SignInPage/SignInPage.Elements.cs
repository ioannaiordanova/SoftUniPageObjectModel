using Core;
using OpenQA.Selenium;

namespace AutomationPractice.Pages.SignInPage
{
    public partial class SignInPage : AutomationPractice
    {
        private WebElement EmailCreate => Driver.FindElement(By.Name("email_create"));

        private WebElement SumbitCreateButton => Driver.FindElement(By.Id("SubmitCreate"));
    }
}
