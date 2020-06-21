using Core;
using OpenQA.Selenium;

namespace DemoQA.Pages.SideBar
{
    public partial class SideBarMenu : DemoQAPage
    {
        public WebElement MenuList => Driver.FindElement(By.CssSelector("div.element-list.collapse.show .menu-list"));

    }
}
