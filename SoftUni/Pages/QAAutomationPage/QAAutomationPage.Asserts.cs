using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUni.Pages.QAAutomationPage
{
    public partial class QAAutomationPage : SoftUniPage
    {
        [Obsolete]
        public void Test_H1_Text(string Text) {
            Assert.AreEqual(H1.Text, Text);
        }
    }
}
