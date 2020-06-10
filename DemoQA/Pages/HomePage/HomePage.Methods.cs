using AutomationPractice.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.HomePage
{
    public partial class HomePage:DemoQAPage
    {
        protected override string Url => "http://demoqa.com/";
        public HomePage(IWebDriver driver) : base(driver) { 
        
        }

        public void SelectFromMainMenu(string sectionName)
        {
            MainMenu(sectionName).Click();
        }
    }
}
