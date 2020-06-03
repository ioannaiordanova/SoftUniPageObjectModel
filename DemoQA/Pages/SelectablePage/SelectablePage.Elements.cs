using AutomationPractice.Pages.SideBar;
using OpenQA.Selenium;
using System.Collections.Generic;


namespace AutomationPractice.Pages.Selectable
{
    public partial class SelectablePage : SideBarMenu
    {
        public IList<IWebElement> ListOfSelectables => Driver.FindElements(By.CssSelector("#verticalListContainer > li"));

    }
}
