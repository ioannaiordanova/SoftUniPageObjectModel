using Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationPractice.Pages.RegistrationForm
{
    public partial class RegistrationFormPage : AutomationPractice
    {
        public WebElement TitleMr => Driver.FindElement(By.Id("id_gender1"));
        public WebElement TitleMrs => Driver.FindElement(By.Id("id_gender2"));

        public WebElement FirstName => Driver.FindElement(By.Id("customer_firstname"));
        public WebElement LastName => Driver.FindElement(By.Id("customer_lastname"));
        public WebElement Email => Driver.FindElement(By.CssSelector("div.required > input#email"));
        public WebElement Password => Driver.FindElement(By.Id("passwd"));
        public WebElement Address1 => Driver.FindElement(By.Id("address1"));
        public WebElement City => Driver.FindElement(By.Id("city"));
        public SelectElement StateDropDown => new SelectElement( Driver.FindElement(By.Id("id_state")).WrappedElement);
        public SelectElement CountryDropDown => new SelectElement(Driver.FindElement(By.Id("id_country")).WrappedElement);
        public WebElement Mobile => Driver.FindElement(By.Id("phone_mobile"));
        public WebElement Postcode => Driver.FindElement(By.Id("postcode"));
        public WebElement AlertDanger => Driver.FindElement(By.CssSelector(".alert.alert-danger"));
        public WebElement SubmitButton => Driver.FindElement(By.Name("submitAccount"));
  
    }
}
