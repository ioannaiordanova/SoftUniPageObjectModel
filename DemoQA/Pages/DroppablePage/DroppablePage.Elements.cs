using AutomationPractice.Pages.SideBar;
using OpenQA.Selenium;


namespace AutomationPractice.Pages.Droppable
{
   public partial class DroppablePage : SideBarMenu
    {
        public IWebElement DragMe => Driver.FindElement(By.Id("draggable"));

        public IWebElement DropHere => Driver.FindElement(By.Id("droppable"));
    }
}
