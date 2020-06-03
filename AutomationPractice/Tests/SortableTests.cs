﻿using AutomationPractice.Pages.SortablePage;
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
            Driver.Navigate().GoToUrl("http://demoqa.com/");
            _sortablePage = new SortablePage(Driver, Builder);
            _sortablePage.WaitForLoad();
            _sortablePage.SelectFromMainMenu("Interactions");
            _sortablePage.WaitForLoad();
            _sortablePage.ClickOnSideBarMenuItem();
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
            
            string TextOne = _sortablePage.GetGridElementByIndex(1).Text;

             Builder
                  .DragAndDropToOffset(_sortablePage.GetGridElementByIndex(1), 2 * _sortablePage.GetGridElementByIndex(1).Size.Width, 2 * _sortablePage.GetGridElementByIndex(1).Size.Height)
                  .Release(_sortablePage.GetGridElementByIndex(1))
                  .Perform();

            Assert.AreEqual(TextOne, _sortablePage.GetGridElementByIndex(9).Text);         
        }


        [Test]
        [Obsolete]
        public void MoveTheFirstDown_CheckTheFirst_Test()
        {
         
            string TextInTheSecond = _sortablePage.GetListItemText(2);
            _sortablePage.MoveListElementOneBelow(1);
            Assert.AreEqual(TextInTheSecond, _sortablePage.GetListItemText(1));

        }

    }
}
