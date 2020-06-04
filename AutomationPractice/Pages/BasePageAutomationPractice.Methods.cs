using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Pages
{
   public partial class BasePageAutomationPractice : BasePage
    {
        public BasePageAutomationPractice(IWebDriver driver) : base(driver)
        { 
           
        }

        public string GetAttribute_Value(IWebElement element) {
            return element.GetAttribute("value");
        }
    }
}
