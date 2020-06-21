using NUnit.Framework;

namespace AutomationPractice.Pages.RegistrationForm
{
    public partial class RegistrationFormPage : AutomationPractice
    {
        public void AlaertContainsMessage(string Message)
        {
          
            Assert.IsTrue(this.AlertDanger.Text.Contains(Message), "The results DIV doesn't contains the specified text.");
        }

        public void EmailFieldIsSameAsEntered(string expectedEmail) {
            Assert.AreEqual(expectedEmail, Email.GetAttribute("value"));
        }
    }
}
