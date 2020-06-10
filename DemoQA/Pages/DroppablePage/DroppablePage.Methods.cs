using AutomationPractice.Pages.SideBar;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace AutomationPractice.Pages.Droppable
{
   public partial class DroppablePage: SideBarMenu
    {

        public DroppablePage(IWebDriver driver, Actions builder) : base(driver, builder){ }


        public void MoveDragMeByOffset(int X, int Y) {
           Builder
                  .ClickAndHold(DragMe)
                  .MoveByOffset(X, Y)
                  .Click()
                  .Perform();
        }

        public void DragMeAndDropHere() {
            Builder
                  .DragAndDrop(DragMe, DropHere)
                  .Perform();
        }

        public void MoveDragMeToElement(IWebElement element)
        {
            Builder
                    .ClickAndHold(DragMe)
                    .MoveToElement(element)
                    .Click()
                    .Perform();
        }


        public string GetDroppableColor()
        {
            return DropHere.GetCssValue("background");
        }

        public string GetDroppableText()
        {
            return DropHere.Text;
        }

        public override void ClickOnSideBarMenuItem()
        {
            base.ClickOnSideBarMenuItem(SideBarEnum.Droppable.GetStringValue());

        }
    }
}
