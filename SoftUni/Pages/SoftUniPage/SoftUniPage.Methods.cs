using OpenQA.Selenium;


namespace SoftUni.Pages
{
   public partial class SoftUniPage:BasePage
    {
        protected override string Url => "http://www.softuni.bg";
        public SoftUniPage(IWebDriver driver) : base(driver) { 
        }

        public IWebElement GetMainMenu(int MenuIndex)
        {
            return MenuItem(MenuIndex);
        }

       

        public void Select_MenuCourse_QA() {
            ActiveModulesCollapsible.Click();
            SubMenuAutomation.Click();
            WaitForLoad();
        }
    }
}
