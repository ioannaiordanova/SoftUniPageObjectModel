using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Pages
{
    public partial class DemoQAPage: BasePage
    {
        public Actions Builder { get; }
        public DemoQAPage(IWebDriver driver, Actions builder=null) :base(driver) {
            Builder = builder;
        }

        public int getLogoLocationY() {
            return Logo.Location.Y;
        }

        public int getLogoHeight() {
            return Logo.Size.Height;
        }
    }
}
