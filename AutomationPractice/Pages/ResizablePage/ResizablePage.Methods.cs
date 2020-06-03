﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Pages.ResizablePage
{
    public partial class ResizablePage: BasePageDemoQA
    {
        public ResizablePage(IWebDriver driver, Actions builder) : base(driver, builder)
        { 
        }

        public double ConstraintAreaWidth() { 
            return ConstraintArea.Size.Width; 
        }

        public double ConstraintAreaHeight()
        {
            return ConstraintArea.Size.Height;
        }

        public double GetResizableBoxWidth() {
            return ResizableBox.Size.Width;
         }

        public double GetResizableBoxHeight()
        {
            return ResizableBox.Size.Height;
        }

        public Actions ResizeActionWithoutPerform(int X, int Y) {
            return Builder
                    .MoveToElement(ResizableBoxHandle)
                    .MoveByOffset(1, 1)
                    .ClickAndHold(ResizableBoxHandle)
                    .MoveByOffset(X, Y);
        }
    }
}