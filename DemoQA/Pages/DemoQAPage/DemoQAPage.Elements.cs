using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages
{
   public partial class DemoQAPage : BasePage
    {
        public WebElement Logo => Driver.FindElement(By.CssSelector("a[href*='demoqa.com']"));
    }
}
