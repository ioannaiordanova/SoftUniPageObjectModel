using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Pages.SideBar
{
   public partial class SideBarMenu : BasePageDemoQA
    {
        public SideBarMenu(IWebDriver driver, Actions builder=null) : base(driver, builder)
        {
        }

        public virtual void ClickOnSideBarMenuItem()
        {

        }

        public void ClickOnSideBarMenuItem(string Id)
        {
            IWebElement menu_item = MenuList.FindElement(By.Id(Id));
            ScrollTo(menu_item);
            menu_item.Click();
        }

        public void NavigateToPage() {
            WaitForLoad();
            SelectFromMainMenu("Interactions");
            WaitForLoad();
            ClickOnSideBarMenuItem();
        }
    }
}
