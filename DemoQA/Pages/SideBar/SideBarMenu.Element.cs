
using OpenQA.Selenium;



namespace AutomationPractice.Pages.SideBar
{
    public partial class SideBarMenu : DemoQAPage
    {
        public IWebElement MenuList => Driver.FindElement(By.CssSelector("div.element-list.collapse.show .menu-list"));

    }
}
