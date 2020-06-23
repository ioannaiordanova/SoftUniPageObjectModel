using Core;
using DemoQA.Pages.SideBar;
using OpenQA.Selenium.Interactions;


namespace DemoQA.Pages.Droppable
{
    public partial class DroppablePage: SideBarMenu
    {

        public DroppablePage(WebDriver driver) : base(driver){ }



        public void DragMeAndDropHere() {
            Actions _builder = new Actions(Driver.WrappedDriver);
            _builder
                  .DragAndDrop(DragMe.WrappedElement, DropHere.WrappedElement)
                  .Perform();
        }

    

        public override void ClickOnSideBarMenuItem()
        {
            base.ClickOnSideBarMenuItem(SideBarEnum.Droppable);

        }
    }
}
