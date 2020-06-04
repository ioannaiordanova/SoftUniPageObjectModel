using NUnit.Framework;
using SoftUni.Pages.QAAutomationPage;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUni.Tests
{
    class QAAutomationTests : BaseTest
    {
        protected QAAutomationPage _qaAutomationPage;
        [SetUp]
        public void SetUp() {
            Initialize();
            Driver.Navigate().GoToUrl("http://www.softuni.bg");
            _qaAutomationPage = new QAAutomationPage(Driver);
        }

        [TearDown]
        public void TearDown() {
            Driver.Quit();
        }

        [Test]
        [Obsolete]
        public void QA_Automation_H1() {
            _qaAutomationPage.GetMainMenu((int)MainMenu.Education).Click();
            
            _qaAutomationPage.SubMenuAutomation.Click();

            _qaAutomationPage.Test_H1_Text("QA Automation - май 2020");
        }
    }
}
