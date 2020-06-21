using Core;
using OpenQA.Selenium;


namespace SoftUni.Pages
{
    public partial class SoftUniPage : BasePage
    {
        public WebElement MenuItem(int index) => Driver.FindElement(By.CssSelector($".nav-item:nth-of-type({index}) > a"));
        public WebElement SubMenuAutomation => Driver.FindElement(By.CssSelector("ul.category-list li a[href*=Quality-Assurance]"));

        public WebElement ActiveModulesCollapsible => Driver.FindElement(By.CssSelector(".col-md-6.no-padding .my-collapsible-header"));
    }
}
