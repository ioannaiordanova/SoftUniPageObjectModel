using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Pages.RegistrationForm
{
   public partial class RegistrationFormPage : BasePageAutomationPractice
    {
        public IWebElement TitleMr => Driver.FindElement(By.Id("id_gender1"));
        public IWebElement TitleMrs => Driver.FindElement(By.Id("id_gender2"));

        public IWebElement FirstName => Driver.FindElement(By.Id("customer_firstname"));
        public IWebElement LastName => Driver.FindElement(By.Id("customer_lastname"));
        public IWebElement Email => Driver.FindElement(By.Id("email"));
        public IWebElement Password => Driver.FindElement(By.Id("passwd"));
        public IWebElement Address1 => Driver.FindElement(By.Id("address1"));
        public IWebElement City => Driver.FindElement(By.Id("city"));
        public SelectElement StateDropDown => new SelectElement( Driver.FindElement(By.Id("id_state")));
        public SelectElement CountryDropDown => new SelectElement(Driver.FindElement(By.Id("id_country")));
        public IWebElement Mobile => Driver.FindElement(By.Id("phone_mobile"));
        public IWebElement Postcode => Driver.FindElement(By.Id("postcode"));
        public IWebElement AlertDanger => Driver.FindElement(By.CssSelector(".alert.alert-danger"));
        public IWebElement SubmitButton => Driver.FindElement(By.Name("submitAccount"));

    
    }
}
