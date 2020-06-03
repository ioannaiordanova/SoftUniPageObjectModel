using AutomationPractice.Pages.SortablePage;
using NUnit.Framework;
using OpenQA.Selenium;
using System;


namespace AutomationPractice.Tests
{
    class SortableTests : BaseTest
    {
        private SortablePage _sortablePage;
        [SetUp]
        public void SetUp() {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/sortable");
            _sortablePage = new SortablePage(Driver, Builder);
        }

        [TearDown]
        public void TearDown() {
            Driver.Quit();
        }


        [Test]
        [Obsolete]
        public void MoveTheFirst_ToLast_CheckTheLast_Test()
        {
           
           _sortablePage.GridTab.Click();
            IWebElement SortableItemSource = _sortablePage.GetGridElementByIndex(1);
            IWebElement SortableItemTarget = _sortablePage.GetGridElementByIndex(9); 
        
            string text9 = SortableItemTarget.Text;
            string TextOne = SortableItemSource.Text;

         Builder
              .DragAndDropToOffset(SortableItemSource, 2 * SortableItemTarget.Size.Width, 2 * SortableItemTarget.Size.Height)
              .Release(SortableItemSource)
              .Perform();

            Assert.AreEqual(TextOne, SortableItemTarget.Text);
           
        }


        [Test]
        [Obsolete]
        public void MoveTheFirstDown_CheckTheFirst_Test()
        {
         
            string Text_InThe_Second = _sortablePage.GetListItemText(2);
            _sortablePage.MoveListElementOneBelow(1);
            Assert.AreEqual(Text_InThe_Second, _sortablePage.GetListItemText(1));

        }

    }
}
