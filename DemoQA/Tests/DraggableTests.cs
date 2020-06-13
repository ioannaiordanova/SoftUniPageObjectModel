using AutomationPractice.Pages.DraggablePage;
using AutomationPractice.Utilities.Extensions;
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
            int PositionXBefore = Driver.XOf(_draggablePage.DragBox);
            int PositionYBefore = Driver.YOf(_draggablePage.DragBox);
            int offsetX = 100;
            int offsetY = 50;

            _draggablePage.MoveDragBoxByOffsetXY(offsetX, offsetY);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(PositionXBefore + offsetX, Driver.XOf(_draggablePage.DragBox), "Position X before+offsetX==Position X After");
                Assert.AreEqual(PositionYBefore + offsetY, Driver.YOf(_draggablePage.DragBox), "Position Y Before+offsetY == Position Y After");
            });
        }

        [Test]
        [Obsolete]
        public void Draggable_DragAndDrop_Test()
        {
            _draggablePage.DragBoxDropToElement(_draggablePage.Logo);

            Assert.Multiple(() =>
            {
                Assert.GreaterOrEqual(Driver.YOf(_draggablePage.DragBox), Driver.YOf(_draggablePage.Logo));
                Assert.LessOrEqual(Driver.YOf(_draggablePage.DragBox), Driver.YOf(_draggablePage.Logo) + _draggablePage.GetLogoHeight());
            });
        }


        [Test]
        [Obsolete]
        public void Draggable_MoveToElement_Test()
        {

            _draggablePage.MoveDragBoxToElement(_draggablePage.Logo);

            Assert.Multiple(() =>
            {
                Assert.GreaterOrEqual(Driver.YOf(_draggablePage.DragBox), Driver.YOf(_draggablePage.Logo));
                Assert.LessOrEqual(Driver.YOf(_draggablePage.DragBox), Driver.YOf(_draggablePage.Logo) + _draggablePage.GetLogoHeight());
            });

        }
    }
}
