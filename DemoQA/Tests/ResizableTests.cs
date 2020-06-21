using DemoQA.Pages.ResizablePage;
using NUnit.Framework;
using System;

namespace DemoQA.Tests
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
                                        .MoveByOffset(offsetX, offsetY)
                                        .Perform();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(widthBefore + offsetX, _resizablePage.ResizableBox.Width, 10);
                Assert.AreEqual(heightBefore + offsetY, _resizablePage.ResizableBox.Height, 10);
            });

        }

        [Test]
        [Obsolete]
        public void Resize_MoreThanRestriction_Test()
        {   
          
         _resizablePage.ResizableBoxHandle.MoveToElement()
                                          .MoveByOffset(300, 400);

            Assert.Throws<OpenQA.Selenium.WebDriverException>(delegate {

                Builder.Perform();
            });

        }
    }
}
