using AutomationPractice.Pages.DraggablePage;
using NUnit.Framework;
using System;

namespace AutomationPractice.Tests
{
    class DraggableTests : BaseTest
    {
        private DraggablePage _draggablePage;

        [SetUp]
        [Obsolete]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/");
            _draggablePage = new DraggablePage(Driver, Builder);
            _draggablePage.NavigateToPage();

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        [Obsolete]
        public void Draggable_MoveByOffsetXY_Test()
        {
            int PositionXBefore = _draggablePage.getDraggablePositionX();
            int PositionYBefore = _draggablePage.getDraggablePositionY();
            int offsetX = 100;
            int offsetY = 50;

            _draggablePage.MoveByOffsetXY(offsetX, offsetY);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(PositionXBefore + offsetX, _draggablePage.getDraggablePositionX(), "Position X before+offsetX==Position X After");
                Assert.AreEqual(PositionYBefore + offsetY, _draggablePage.getDraggablePositionY(), "Position Y Before+offsetY == Position Y After");
            });
        }

        [Test]
        [Obsolete]
        public void Draggable_DragAndDrop_Test()
        {
            _draggablePage.DragAndDropToElement(_draggablePage.Logo);

            Assert.Multiple(() =>
            {
                Assert.GreaterOrEqual(_draggablePage.getDraggablePositionY(), _draggablePage.getLogoLocationY());
                Assert.LessOrEqual(_draggablePage.getDraggablePositionY(), _draggablePage.getLogoLocationY() + _draggablePage.getLogoHeight());
            });
        }


        [Test]
        [Obsolete]
        public void Draggable_MoveToElement_Test()
        {

            _draggablePage.MoveToElement(_draggablePage.Logo);

            Assert.Multiple(() =>
            {
                Assert.GreaterOrEqual(_draggablePage.getDraggablePositionY(), _draggablePage.getLogoLocationY());
                Assert.LessOrEqual(_draggablePage.getDraggablePositionY(), _draggablePage.getLogoLocationY() + _draggablePage.getLogoHeight());
            });

        }
    }
}
