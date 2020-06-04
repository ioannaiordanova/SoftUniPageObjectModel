using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUni.Pages.QAAutomationPage
{
    public partial class QAAutomationPage : BaseSoftUniPage
    {
    
        IWebElement H1 => Driver.FindElement(By.XPath("//h1"));
    }
}
