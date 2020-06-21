using Core;
using DemoQA.Pages.SideBar;
using OpenQA.Selenium;


namespace DemoQA.Pages.Droppable
{
   public partial class DroppablePage : SideBarMenu
    {
        public WebElement DragMe => Driver.FindElement(By.Id("draggable"));

        public WebElement DropHere => Driver.FindElement(By.Id("droppable"));
    }
}
