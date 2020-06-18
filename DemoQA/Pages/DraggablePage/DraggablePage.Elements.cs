
using DemoQA.Pages.SideBar;
using OpenQA.Selenium;

namespace DemoQA.Pages.DraggablePage
{
   public partial class DraggablePage : SideBarMenu
    {
        public WebElement DragBox => Driver.FindElement(By.Id("dragBox"));
    }
}
