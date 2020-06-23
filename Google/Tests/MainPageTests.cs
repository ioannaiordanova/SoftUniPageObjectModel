using Core.Utilities.Extentions;
using Google.Pages.MainPage;
using NUnit.Framework;


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
            Driver.SaveScreenShot();
            Driver.Quit();
        }

        [Test]
        public void Google_First_Found_Result()
        {
            _mainPage.SearchField.SetText("selenium");
            _mainPage.SearchField.Submit();

            _mainPage.FirstResultLink.Click();
        }


    }
}
