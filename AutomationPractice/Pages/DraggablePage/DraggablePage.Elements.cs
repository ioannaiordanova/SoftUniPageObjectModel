using AutomationPractice.Pages.SideBar;
using OpenQA.Selenium;

namespace AutomationPractice.Pages.DraggablePage
{
   public partial class DraggablePage : SideBarMenu
    {
        public IWebElement DragBox => Driver.FindElement(By.Id("dragBox"));
    }
}
