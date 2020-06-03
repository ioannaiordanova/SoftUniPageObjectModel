using AutomationPractice.Pages.SideBar;
using OpenQA.Selenium;


namespace AutomationPractice.Pages.Droppable
{
   public partial class DroppablePage : SideBarMenu
    {
        public IWebElement Draggable => Driver.FindElement(By.Id("draggable"));

        public IWebElement Droppable => Driver.FindElement(By.Id("droppable"));
    }
}
