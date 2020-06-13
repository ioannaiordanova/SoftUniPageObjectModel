using AutomationPractice.Pages.SideBar;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;



namespace AutomationPractice.Pages.DraggablePage
{
    public partial class DraggablePage:SideBarMenu
    {
        public DraggablePage(IWebDriver driver, Actions builder) : base(driver,builder) { 
           
        }

       
        public void MoveDragBoxByOffsetXY(int X, int Y) {
                Builder
                   .ClickAndHold(this.DragBox)
                   .MoveByOffset(X, Y)
                   .Perform();
        }

        public void DragBoxDropToElement(IWebElement element) {
           Builder
                  .DragAndDrop(DragBox, element)
                  .Perform();
        }

        public void MoveDragBoxToElement(IWebElement element)
        {
            Builder
                   .DragAndDrop(DragBox, element)
                   .Perform();
        }

        public override void ClickOnSideBarMenuItem()
        {
            base.ClickOnSideBarMenuItem(SideBarEnum.Draggable.GetStringValue());

        }

    }
}
