using Core.Utilities.Extentions;
using DemoQA.Pages.DraggablePage;
using NUnit.Framework;
using System;

namespace DemoQA.Tests
{
    class DraggableTests : BaseTest
    {
        private DraggablePage _draggablePage;

        [SetUp]
        [Obsolete]
        public void Setup()
        {
            Initialize();
            _draggablePage = new DraggablePage(Driver);
            _draggablePage.NavigateToPage();

        }

        [TearDown]
        public void TearDown()
        {
            Driver.SaveScreenShot();
            Driver.Quit();
        }

        [Test]
        [Obsolete]
        public void Draggable_MoveByOffsetXY_Test()
        {
            int PositionXBefore = _draggablePage.DragBox.X;
            int PositionYBefore = _draggablePage.DragBox.Y;
            int offsetX = 100;
            int offsetY = 50;

            _draggablePage.DragBox
                        .MoveByOffset(offsetX, offsetY)
                        .Click()
                        .Perform() ;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(PositionXBefore + offsetX, _draggablePage.DragBox.X, "Position X before+offsetX==Position X After");
                Assert.AreEqual(PositionYBefore + offsetY, _draggablePage.DragBox.Y, "Position Y Before+offsetY == Position Y After");
            });
        }

        [Test]
        [Obsolete]
        public void Draggable_DragAndDrop_Test()
        {
            _draggablePage.DragBox.DragAndDrop(_draggablePage.Logo);

            Assert.Multiple(() =>
            {
                Assert.GreaterOrEqual(_draggablePage.DragBox.Y, _draggablePage.Logo.Y);
                Assert.LessOrEqual(_draggablePage.DragBox.Y, _draggablePage.Logo.Y + _draggablePage.Logo.Height);
            });
        }


        [Test]
        [Obsolete]
        public void Draggable_MoveToElement_Test()
        {

            _draggablePage.DragBox.MoveToElement(_draggablePage.Logo);

            Assert.Multiple(() =>
            {
                Assert.GreaterOrEqual(_draggablePage.DragBox.Y, _draggablePage.Logo.Y);
                Assert.LessOrEqual(_draggablePage.DragBox.Y, _draggablePage.Logo.Y + _draggablePage.Logo.Height);
            });

        }
    }
}
