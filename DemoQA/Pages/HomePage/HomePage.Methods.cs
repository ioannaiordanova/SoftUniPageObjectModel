using OpenQA.Selenium;

namespace DemoQA.Pages
{
    public partial class HomePage:DemoQAPage
    {
        protected override string Url => "http://demoqa.com/";
        public HomePage(WebDriver driver) : base(driver) { 
        
        }

        public void SelectFromMainMenu(string sectionName)
        {
            MainMenu(sectionName).Click();
        }
    }
}
