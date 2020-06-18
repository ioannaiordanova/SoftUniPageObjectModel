using DemoQA.Pages.ResizablePage;
using DemoQA.Tests;
using NUnit.Framework;
using System;

namespace AutomationPractice.Tests
{
    class ResizableTests :BaseTest
    {
        private ResizablePage _resizablePage;
        [SetUp]
        public void SetUp() {
            Initialize();
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
       
            double widthBefore = _resizablePage.ResizableBox.Width;
            double heightBefore = _resizablePage.ResizableBox.Height;
            int offsetX = 90;
            int offsetY = 50;

            _resizablePage.ResizableBoxHandle.MoveToElement()
                                        .MoveByOffset(1, 1)
                                        .ClickAndHold()
                                        .MoveByOffset(offsetX, offsetY)
                                        .Perform();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(widthBefore + offsetX, _resizablePage.ResizableBox.Width, 20);
                Assert.AreEqual(heightBefore + offsetY, _resizablePage.ResizableBox.Height, 20);
            });

        }

        [Test]
        [Obsolete]
        public void Resize_MoreThanRestriction_Test()
        {   
          
         _resizablePage.ResizableBoxHandle.MoveToElement()
                                          .MoveByOffset(1, 1)
                                          .ClickAndHold()
                                          .MoveByOffset(300, 400);

            Assert.Throws<OpenQA.Selenium.WebDriverException>(delegate {

                Builder.Perform();
            });

        }
    }
}
