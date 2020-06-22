using DemoQA.Pages.Droppable;
using NUnit.Framework;

namespace DemoQA.Tests
{
    class DroppableTests : BaseTest
    {
        private DroppablePage _droppablePage;
        [SetUp]
        public void SetUp() {
            Initialize();
            _droppablePage = new DroppablePage(Driver);
            _droppablePage.NavigateToPage();

        }

        [TearDown]
        public void TearDown() {
            Driver.Quit();
        }

        [Test]
        public void Droppable_MoveByOffsetXY_Test()
        {
            int offsetX = 250;
            int offsetY = 50;

            _droppablePage.DragMe.MoveByOffset(offsetX, offsetY)
                                .Perform(); ;

            Assert.IsTrue(_droppablePage.DropHere.Text.Contains("Dropped!"));
        }

        [Test]
        public void DragMe_DragAndDrop_Test()
        {
            var colorBefore = _droppablePage.DropHere.GetCssValue("background");

            _droppablePage.DragMe.DragAndDrop(_droppablePage.DropHere);
           
            Assert.AreNotEqual(colorBefore, _droppablePage.DropHere.GetCssValue("background"));
        }


        [Test]
        public void DragMe_Move_To_DropHere_Test()
        {
            _droppablePage.DragMe.MoveToElement(_droppablePage.DropHere);

            Assert.IsTrue(_droppablePage.DropHere.Text.Contains("Dropped!"));

        }


    }
}
