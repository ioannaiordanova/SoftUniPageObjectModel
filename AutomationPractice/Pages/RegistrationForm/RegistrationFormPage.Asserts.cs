using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Pages.RegistrationForm
{
    public partial class RegistrationFormPage : BasePageAutomationPractice
    {
        public void AlaertContainsMessage(string Message)
        {
          
            Assert.IsTrue(this.AlertDanger.Text.Contains(Message), "The results DIV doesn't contains the specified text.");
        }

        public void EmailFieldIsSameAsEntered(string expectedEmail) {
            Assert.AreEqual(expectedEmail, GetAttribute_Value(Email));
        }
    }
}
