using AutomationPractice.Pages.Droppable;
using NUnit.Framework;

namespace AutomationPractice.Tests
{
    class DroppableTests : BaseTest
    {
        private DroppablePage _droppablePage;
        [SetUp]
        public void SetUp() {
            Initialize();
            _droppablePage = new DroppablePage(Driver, Builder);
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

            _droppablePage.MoveDragMeByOffset(offsetX, offsetY);

            Assert.IsTrue(_droppablePage.GetDroppableText().Contains("Dropped!"));
        }

        [Test]
        public void DragMe_DragAndDrop_Test()
        {
            var colorBefore = _droppablePage.GetDroppableColor();

            _droppablePage.DragMeAndDropHere();
           
            Assert.AreNotEqual(colorBefore, _droppablePage.GetDroppableColor());
        }


        [Test]
        public void DragMe_Move_To_DropHere_Test()
        {
            _droppablePage.MoveDragMeToElement(_droppablePage.DropHere);

            Assert.IsTrue(_droppablePage.GetDroppableText().Contains("Dropped!"));

        }


    }
}
