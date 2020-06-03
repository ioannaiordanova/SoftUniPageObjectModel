using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Pages
{
    public partial class BasePageDemoQA: BasePage
    {
        public Actions Builder { get; }
        public BasePageDemoQA(IWebDriver driver, Actions builder) :base(driver) {
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
