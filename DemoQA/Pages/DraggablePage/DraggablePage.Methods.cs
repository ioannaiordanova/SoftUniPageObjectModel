using DemoQA.Pages.SideBar;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;



namespace DemoQA.Pages.DraggablePage
{
    public partial class DraggablePage : SideBarMenu
    {
        public DraggablePage(WebDriver driver, Actions builder) : base(driver,builder) { 
           
        }

       
        public override void ClickOnSideBarMenuItem()
        {
            base.ClickOnSideBarMenuItem(SideBarEnum.Draggable.GetStringValue());

        }

    }
}
