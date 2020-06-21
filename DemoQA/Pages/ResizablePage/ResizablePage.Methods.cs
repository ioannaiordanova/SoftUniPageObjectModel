using Core;
using DemoQA.Pages.SideBar;
using OpenQA.Selenium.Interactions;


namespace DemoQA.Pages.ResizablePage
{
    public partial class ResizablePage : SideBarMenu
    {
        public ResizablePage(WebDriver driver, Actions builder) : base(driver, builder)
        {
        }


        public override void ClickOnSideBarMenuItem()
        {
            base.ClickOnSideBarMenuItem(SideBarEnum.Resizable.GetStringValue());

        }
    }
}
