using Core.Utilities.Extentions;
using NUnit.Framework;
using SoftUni.Pages;
using SoftUni.Pages.QAAutomationPage;
using System;

namespace SoftUni.Tests
{
    class QAAutomationTests : BaseTest
    {
        protected QAAutomationPage _qaAutomationPage;
        protected SoftUniPage _softUniPage;
        [SetUp]
        public void SetUp() {
            Initialize();
            _softUniPage = new SoftUniPage(Driver);
            _qaAutomationPage = new QAAutomationPage(Driver);
            _softUniPage.NavigateTo();
        }

        [TearDown]
        public void TearDown() {
            Driver.SaveScreenShot();
            Driver.Quit();
        }

        [Test]
        [Obsolete]
        public void QA_Automation_H1() {
            _qaAutomationPage.GetMainMenu((int)MainMenu.Education).Click();

            _qaAutomationPage.Select_MenuCourse_QA();

            _qaAutomationPage.Test_H1_Text("МОДУЛ: Quality Assurance - септември 2020");
        }
    }
}
