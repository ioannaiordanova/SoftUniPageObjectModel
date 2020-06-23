using Core;
using DemoQA.Pages.SideBar;
using OpenQA.Selenium.Interactions;

namespace DemoQA.Pages.DraggablePage
{
    public partial class DraggablePage : SideBarMenu
    {
        public DraggablePage(WebDriver driver) : base(driver) 
        { 
           
        }

       
        public override void ClickOnSideBarMenuItem()
        {
            base.ClickOnSideBarMenuItem(SideBarEnum.Draggable);

        }

    }
}
