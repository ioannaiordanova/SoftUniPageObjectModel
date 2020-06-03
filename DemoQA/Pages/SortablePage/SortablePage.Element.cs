using AutomationPractice.Pages.SideBar;
using OpenQA.Selenium;
using System.Collections.Generic;


namespace AutomationPractice.Pages.SortablePage
{
   public partial class SortablePage : SideBarMenu
    {
        IList<IWebElement> ListItems => Driver.FindElements(By.CssSelector(".list-group-item.list-group-item-action"));
        public IWebElement GridTab => Driver.FindElement(By.Id("demo-tab-grid"));

        public IWebElement Grid => Driver.FindElement(By.ClassName("create-grid"));
        public IList<IWebElement> GridItems => Grid.FindElements(By.CssSelector("div.list-group-item.list-group-item-action"));

      


    }
}
