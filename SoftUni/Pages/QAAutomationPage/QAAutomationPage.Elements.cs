using Core;
using OpenQA.Selenium;

namespace SoftUni.Pages.QAAutomationPage
{
    public partial class QAAutomationPage : SoftUniPage
    {
    
        WebElement H1 => Driver.FindElement(By.XPath("//h1"));
    }
}
