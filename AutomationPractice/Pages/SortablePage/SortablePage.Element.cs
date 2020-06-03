using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Pages.SortablePage
{
   public partial class SortablePage : BasePageDemoQA
    {
        IList<IWebElement> ListItems => Driver.FindElements(By.CssSelector(".list-group-item.list-group-item-action"));
        IList<IWebElement> GridItems => Driver.FindElements(By.CssSelector("div.list-group-item.list-group-item-action"));

       public IWebElement GridTab => Driver.FindElement(By.Id("demo-tab-grid"));


    }
}
