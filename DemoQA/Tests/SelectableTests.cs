using DemoQA.Pages.Selectable;
using NUnit.Framework;
using System;

namespace DemoQA.Tests
{
    class SelectableTests:BaseTest
    {
        private SelectablePage _selectablePage;
        [SetUp]
        public void SetUp()
        {
            Initialize();
            _selectablePage = new SelectablePage(Driver);
            _selectablePage.NavigateToPage();
        }


        [TearDown]
        public void TearDown() 
        {
            Driver.Quit();
        }

        [Test]
        [Obsolete]
        public void Selectable_SelectOne_Test()
        {
            var ColorBefore = _selectablePage.GetSelectableWithIndex(2).GetCssValue("background-color");

            _selectablePage.GetSelectableWithIndex(2).Click();
               
            Assert.AreNotEqual(ColorBefore, _selectablePage.GetSelectableWithIndex(2).GetCssValue("background-color"));
        }

        [Test]
        [Obsolete]
        public void Selectable_SelectMoreThanOne_Test()
        {
           
            var ColorBefore = _selectablePage.GetSelectableWithIndex(2).GetCssValue("background-color");

            _selectablePage.GetSelectableWithIndex(2).Click();
            _selectablePage.GetSelectableWithIndex(4).Click();

           
            Assert.AreNotEqual(ColorBefore, _selectablePage.GetSelectableWithIndex(2).GetCssValue("background-color"));
        }
    }
}
