using AutomationPractice.Pages.ResizablePage;
using AutomationPractice.Pages.SideBar;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Tests
{
    class ResizableTests :BaseTest
    {
        private ResizablePage _resizablePage;
        [SetUp]
        public void SetUp() {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/");
            _resizablePage = new ResizablePage(Driver,Builder);
            _resizablePage.NavigateToPage();
        }

        [TearDown]
        public void TearDown() {
            Driver.Quit();
        }

        [Test] 
        public void Resize_LessThatRestriction_Test()
        {
       
            double widthBefore = _resizablePage.GetResizableBoxWidth();
            double heightBefore = _resizablePage.GetResizableBoxHeight();
            int offsetX = 90;
            int offsetY = 50;

            _resizablePage.ResizeActionWithoutPerform(offsetX, offsetY)
                    .Perform();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(widthBefore + offsetX, _resizablePage.GetResizableBoxWidth(), 20);
                Assert.AreEqual(heightBefore + offsetY, _resizablePage.GetResizableBoxHeight(), 20);
            });

        }

        [Test]
        [Obsolete]
        public void Resize_MoreThanRestriction_Test()
        {   
          
              _resizablePage.ResizeActionWithoutPerform(300, 400);

              Assert.Throws<OpenQA.Selenium.WebDriverException>(delegate {

              Builder.Perform();
            });

        }
    }
}
