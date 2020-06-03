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
            Driver.Navigate().GoToUrl("http://demoqa.com/");
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

            _droppablePage.MoveDraggableByOffset(offsetX, offsetY);

            Assert.IsTrue(_droppablePage.GetDroppableText().Contains("Dropped!"));
        }

        [Test]
        public void Droppable_DragAndDrop_Test()
        {
            var colorBefore = _droppablePage.GetDroppableColor();

            _droppablePage.DragAndDrop();
           
            Assert.AreNotEqual(colorBefore, _droppablePage.GetDroppableColor());
        }


        [Test]
        public void Droppable_MoveToElement_Test()
        {
            _droppablePage.MoveDraggableToElement(_droppablePage.Droppable);

            Assert.IsTrue(_droppablePage.GetDroppableText().Contains("Dropped!"));

        }


    }
}
