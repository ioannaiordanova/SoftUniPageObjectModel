using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUni.Pages
{
   public partial class BaseSoftUniPage:BasePage
    {
        public BaseSoftUniPage(IWebDriver driver) : base(driver) { 
        }

        public IWebElement GetMainMenu(int MenuIndex)
        {
            return MenuItem(MenuIndex);
        }
    }
}
