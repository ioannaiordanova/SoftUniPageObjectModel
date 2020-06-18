using DemoQA.Pages.SideBar;
using OpenQA.Selenium;
using System.Collections.Generic;


namespace DemoQA.Pages.Selectable
{
    public partial class SelectablePage : SideBarMenu
    {
        public IList<WebElement> ListOfSelectables => Driver.FindElements(By.CssSelector("#verticalListContainer > li"));

    }
}
