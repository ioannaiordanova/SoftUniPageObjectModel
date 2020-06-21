using Core;
using OpenQA.Selenium;

namespace AutomationPractice.Pages
{
    public partial class AutomationPractice : BasePage
    {
        private readonly string _url = "http://automationpractice.com/index.php";
        protected override string Url { 
            get
            {
                return _url;
            }
        }

        public AutomationPractice(WebDriver driver) : base(driver)
        { 
           
        }

        public void NavigateToMainPage() {
            Driver.GoToUrl(_url);
        }

    }
}
