using Core;
using DemoQA.Pages.SideBar;
using OpenQA.Selenium.Interactions;


namespace DemoQA.Pages.Droppable
{
    public partial class DroppablePage: SideBarMenu
    {

        public DroppablePage(WebDriver driver, Actions builder) : base(driver, builder){ }



        public void DragMeAndDropHere() {
            Builder
                  .DragAndDrop(DragMe.WrappedElement, DropHere.WrappedElement)
                  .Perform();
        }

    

        public override void ClickOnSideBarMenuItem()
        {
            base.ClickOnSideBarMenuItem(SideBarEnum.Droppable.GetStringValue());

        }
    }
}
