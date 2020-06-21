using NUnit.Framework;
using System;

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
