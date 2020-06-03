using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Pages.Droppable
{
   public partial class DroppablePage : BasePageDemoQA
    {
        public IWebElement Draggable => Driver.FindElement(By.Id("draggable"));

        public IWebElement Droppable => Driver.FindElement(By.Id("droppable"));
    }
}
