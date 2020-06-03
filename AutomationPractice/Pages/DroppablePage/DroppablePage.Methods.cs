using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Pages.Droppable
{
   public partial class DroppablePage: BasePageDemoQA
    {

        public DroppablePage(IWebDriver driver, Actions builder) : base(driver, builder){ }


        public void MoveDraggableByOffset(int X, int Y) {
           Builder
                  .ClickAndHold(Draggable)
                  .MoveByOffset(X, Y)
                  .Click()
                  .Perform();
        }

        public void DragAndDrop() {
            Builder
                  .DragAndDrop(Draggable, Droppable)
                  .Perform();
        }

        public void MoveDraggableToElement(IWebElement element)
        {
            Builder
                    .ClickAndHold(Draggable)
                    .MoveToElement(element)
                    .Click()
                    .Perform();
        }


        public string GetDroppableColor()
        {
            return Droppable.GetCssValue("background");
        }

        public string GetDroppableText()
        {
            return Droppable.Text;
        }
    }
}
