using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUni.Pages.QAAutomationPage
{
    public partial class QAAutomationPage : SoftUniPage
    {
        protected override string Url => "https://softuni.bg/modules/80/quality-assurance-october-2019/1224";
        public QAAutomationPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
