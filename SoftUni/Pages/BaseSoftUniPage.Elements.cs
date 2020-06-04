using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUni.Pages
{
    public partial class BaseSoftUniPage : BasePage
    {
        public IWebElement MenuItem(int index) => Driver.FindElement(By.CssSelector($".nav-item:nth-of-type({index}) > a"));
        public IWebElement SubMenuAutomation => Driver.FindElement(By.CssSelector("ul.category-list li a[href*=qa-automation]"));
    }
}
