﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Pages
{
    public partial class BasePageDemoQA: BasePage
    {
        public Actions Builder { get; }
        public BasePageDemoQA(IWebDriver driver, Actions builder=null) :base(driver) {
            Builder = builder;
        }

        public int getLogoLocationY() {
            return Logo.Location.Y;
        }

        public int getLogoHeight() {
            return Logo.Size.Height;
        }

        public void SelectFromMainMenu(string sectionName)
        {
            MainMenu(sectionName).Click();
        }
    }
}