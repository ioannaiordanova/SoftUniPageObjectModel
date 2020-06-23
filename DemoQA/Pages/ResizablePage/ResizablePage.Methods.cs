using Core;
using DemoQA.Pages.SideBar;
using OpenQA.Selenium.Interactions;


namespace DemoQA.Pages.ResizablePage
{
    public partial class ResizablePage : SideBarMenu
    {
        public ResizablePage(WebDriver driver) : base(driver)
        {
        }


        public override void ClickOnSideBarMenuItem()
        {
            base.ClickOnSideBarMenuItem(SideBarEnum.Resizable);

        }
    }
}
