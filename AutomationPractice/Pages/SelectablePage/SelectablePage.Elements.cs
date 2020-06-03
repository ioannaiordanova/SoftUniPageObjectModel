using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Pages.Selectable
{
    public partial class SelectablePage : BasePage
    {
        public IList<IWebElement> ListOfSelectables => Driver.FindElements(By.CssSelector("#verticalListContainer > li"));

    }
}
