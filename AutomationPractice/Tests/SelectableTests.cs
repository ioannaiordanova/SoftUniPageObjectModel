﻿using AutomationPractice.Pages.Selectable;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Tests
{
    class SelectableTests:BaseTest
    {
        private SelectablePage _selectablePage;
        [SetUp]
        public void SetUp() {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/");
            _selectablePage = new SelectablePage(Driver);
            _selectablePage.WaitForLoad();
            _selectablePage.SelectFromMainMenu("Interactions");
            _selectablePage.WaitForLoad();
            _selectablePage.ClickOnSideBarMenuItem();
        }

        [TearDown]
        public void TearDown() {
            Driver.Quit();
        }

        [Test]
        [Obsolete]
        public void Selectable_SelectOne_Test()
        {

            var ColorBefore = _selectablePage.GetCssValue(2);
            _selectablePage.GetSelectableWithIndex(2).Click();
          
            Assert.AreNotEqual(ColorBefore, _selectablePage.GetCssValue(2));
        }

        [Test]
        [Obsolete]
        public void Selectable_SelectMoreThanOne_Test()
        {
           
            var ColorBefore = _selectablePage.GetCssValue(2);
            _selectablePage.GetSelectableWithIndex(2).Click();
            _selectablePage.GetSelectableWithIndex(4).Click();
            Assert.AreNotEqual(ColorBefore, _selectablePage.GetCssValue(2));


        }
    }
}
