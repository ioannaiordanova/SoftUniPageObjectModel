using AutomationPractice.Pages.SideBar;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;



namespace AutomationPractice.Pages.DraggablePage
{
    public partial class DraggablePage:SideBarMenu
    {
        public DraggablePage(IWebDriver driver, Actions builder) : base(driver,builder) { 
           
        }

        public int getDraggablePositionX() {
            return DragBox.Location.X;
        }

        public int getDraggablePositionY()
        {
            return DragBox.Location.Y;
        }

        public void MoveByOffsetXY(int X, int Y) {
                Builder
                   .ClickAndHold(this.DragBox)
                   .MoveByOffset(X, Y)
                   .Perform();
        }

        public void DragAndDropToElement(IWebElement element) {
           Builder
                  .DragAndDrop(DragBox, element)
                  .Perform();
        }

        public void MoveToElement(IWebElement element)
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
