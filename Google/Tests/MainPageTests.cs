using Google.Pages.MainPage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google.Tests
{
    class MainPageTests : BaseTest
    {
        protected MainPage _mainPage;
        
        [SetUp]
        public void SetUp() {
            Initialize();
            _mainPage = new MainPage(Driver);
            _mainPage.NavigateTo();
        }

        [TearDown]
        public void TearDown() {
            if (TestContext.CurrentContext.Result.Outcome == ResultState.Success) {
                var path = "C:";
                
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile($@"{path}\\{TestContext.CurrentContext.Test.FullName}.png", ScreenshotImageFormat.Png);
            }
            Driver.Quit();
        }

        [Test]
        public void Google_First_Found_Result()
        {
            _mainPage.SearchField.SendKeys("selenium");
            _mainPage.SearchField.Submit();

            _mainPage.FirstResultLink.Click();
        }


    }
}
