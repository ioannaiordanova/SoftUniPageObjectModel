using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Pages
{
   public partial class BasePageDemoQA : BasePage
    {
        public IWebElement Logo => Driver.FindElement(By.CssSelector("a[href*='demoqa.com']"));
    }
}
