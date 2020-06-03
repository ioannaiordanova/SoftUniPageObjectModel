using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Pages.DraggablePage
{
   public partial class DraggablePage : BasePageDemoQA
    {
        public IWebElement DragBox => Driver.FindElement(By.Id("dragBox"));
    }
}
