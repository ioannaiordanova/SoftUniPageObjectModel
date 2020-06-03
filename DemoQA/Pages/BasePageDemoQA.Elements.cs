using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Pages
{
   public partial class BasePageDemoQA : BasePage
    {
        public IWebElement Logo => Driver.FindElement(By.CssSelector("a[href*='demoqa.com']"));

        public IWebElement MainMenu(string sectionName) =>
            Driver.FindElement((By.XPath($"//div[@class='card mt-4 top-card']//h5[text()='{sectionName}']/ancestor::div[@class='card mt-4 top-card']")));
    }
}
