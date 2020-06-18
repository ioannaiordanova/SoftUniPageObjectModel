
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.SideBar
{
   public partial class SideBarMenu : DemoQAPage
    {
        private HomePage _homePage;
        private HomePage HomePage {
            get {
                return _homePage;
            }

           
        }
        public SideBarMenu(WebDriver driver, Actions builder=null) : base(driver, builder)
        {
            this._homePage = new HomePage(driver);
        }

        public virtual void ClickOnSideBarMenuItem()
        {

        }

        public void ClickOnSideBarMenuItem(string Id)
        {
            WebElement menu_item = MenuList.FindElement(By.Id(Id));
            menu_item.ScrollTo();
            menu_item.Click();
        }
      
        public void NavigateToPage() {
            HomePage.NavigateTo();
            HomePage.WaitForLoad();
            HomePage.SelectFromMainMenu("Interactions");
            WaitForLoad();
            ClickOnSideBarMenuItem();
        }
        
    }
}
