using Core;
using OpenQA.Selenium;

namespace SoftUni.Pages.QAAutomationPage
{
    public partial class QAAutomationPage : SoftUniPage
    {
        protected override string Url => "https://softuni.bg/modules/80/quality-assurance-october-2019/1224";
        public QAAutomationPage(WebDriver driver) : base(driver)
        {

        }
    }
}
