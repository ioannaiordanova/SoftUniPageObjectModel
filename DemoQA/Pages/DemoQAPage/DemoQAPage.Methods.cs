using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages
{
    public partial class DemoQAPage: BasePage
    {
        public Actions Builder { get; }
        public DemoQAPage(WebDriver driver, Actions builder=null) :base(driver) {
            Builder = builder;
        }


        
    }
}
