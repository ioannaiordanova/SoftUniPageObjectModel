using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Pages
{
    public partial class BasePageAutomationPractice : BasePage
    {
        public IWebElement LoginButton => Driver.FindElement(By.ClassName("login"));
    }
}
