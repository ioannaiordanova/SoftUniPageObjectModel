using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

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

        public AutomationPractice(IWebDriver driver) : base(driver)
        { 
           
        }

        public void NavigateToMainPage() {
            Driver.Navigate().GoToUrl(_url);
        }

        public string GetAttribute_Value(IWebElement element) {
            return element.GetAttribute("value");
        }
    }
}
