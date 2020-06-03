using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Pages.ResizablePage
{
    public partial class ResizablePage : BasePageDemoQA
    {
        public IWebElement ResizableBox => Driver.FindElement(By.Id("resizableBoxWithRestriction"));
        public IWebElement ResizableBoxHandle => Driver.FindElement(By.CssSelector(".react-resizable-handle.react-resizable-handle-se"));
        public IWebElement ConstraintArea => Driver.FindElement(By.ClassName("constraint-area"));
    }
}
