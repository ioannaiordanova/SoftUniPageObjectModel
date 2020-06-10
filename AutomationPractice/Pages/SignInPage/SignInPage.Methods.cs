using OpenQA.Selenium;
using AutoFixture;

namespace AutomationPractice.Pages.SignInPage
{
    public partial class SignInPage : AutomationPractice
    {
        protected override string Url => "http://automationpractice.com/index.php?controller=authentication&back=my-account";
        public string SignInEmail;
        public SignInPage(IWebDriver driver)
            : base(driver) { 
        }

        private string GetRandomEmail() {
            var fixture = new Fixture();
            var mail = fixture.Create<string>();
            return $"{mail}@abv.bg";
        }

        public void SignIn() {
            SignInEmail = GetRandomEmail();
            this.EmailCreate.SendKeys(SignInEmail);
            this.SumbitCreateButton.Click();
        }
    }
}
