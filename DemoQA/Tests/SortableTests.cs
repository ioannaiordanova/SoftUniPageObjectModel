using Core.Utilities.Extentions;
using DemoQA.Pages.SortablePage;
using NUnit.Framework;
using System;


namespace DemoQA.Tests
{
    class SortableTests : BaseTest
    {
        private SortablePage _sortablePage;
      
        [SetUp]
        public void SetUp() {
            Initialize();
            _sortablePage = new SortablePage(Driver);
            _sortablePage.NavigateToPage();      
        }

        [TearDown]
        public void TearDown() 
        {
            Driver.SaveScreenShot();
            Driver.Quit();
        }


        [Test]
        [Obsolete]
        public void MoveTheFirst_ToLast_CheckTheLast_Test()
        {
           _sortablePage.GridTab.Click();     
            string TextOne = _sortablePage.GetGridElementByIndex(1).Text;

            _sortablePage.GetGridElementByIndex(1).DragAndDropToOffset(2 * _sortablePage.GetGridElementByIndex(1).Width, 2 * _sortablePage.GetGridElementByIndex(1).Height);
         
            Assert.AreEqual(TextOne, _sortablePage.GetGridElementByIndex(9).Text);         
        }


        [Test]
        [Obsolete]
        public void MoveTheFirstDown_CheckTheFirst_Test()
        {
            string TextInTheSecond = _sortablePage.GetListItemText(2);

            _sortablePage.GetListElementByIndex(1).MoveListElementOneBelow();

            Assert.AreEqual(TextInTheSecond, _sortablePage.GetListItemText(1));
        }

    }
}
