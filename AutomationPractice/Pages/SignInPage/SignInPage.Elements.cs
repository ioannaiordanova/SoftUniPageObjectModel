using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Pages.SignInPage
{
    public partial class SignInPage : AutomationPractice
    {
        private IWebElement EmailCreate => Driver.FindElement(By.Name("email_create"));

        private IWebElement SumbitCreateButton => Driver.FindElement(By.Id("SubmitCreate"));
    }
}
