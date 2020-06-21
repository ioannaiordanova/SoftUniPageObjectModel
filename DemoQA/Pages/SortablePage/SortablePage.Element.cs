using Core;
using DemoQA.Pages.SideBar;
using OpenQA.Selenium;
using System.Collections.Generic;


namespace DemoQA.Pages.SortablePage
{
   public partial class SortablePage : SideBarMenu
    {
        IList<WebElement> ListItems => Driver.FindElements(By.CssSelector(".list-group-item.list-group-item-action"));
        public WebElement GridTab => Driver.FindElement(By.Id("demo-tab-grid"));

        public WebElement Grid => Driver.FindElement(By.ClassName("create-grid"));
        public IList<WebElement> GridItems => Grid.FindElements(By.CssSelector("div.list-group-item.list-group-item-action"));

    }
}
