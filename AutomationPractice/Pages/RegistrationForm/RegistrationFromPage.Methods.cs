using AutomationPractice.Models;
using Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationPractice.Pages.RegistrationForm
{
    public partial class RegistrationFormPage : AutomationPractice
    {
        public RegistrationFormPage(WebDriver driver)
           : base(driver)
        {
        }


        public void FillRegistrationInfo(RegistrationFormModel clientInfo)
        {
            if (clientInfo.FirstName != null)
                this.FirstName.SetText(clientInfo.FirstName);
            if (clientInfo.LastName != null)
                this.LastName.SetText(clientInfo.LastName);
            if (clientInfo.Email != null)
            {
                this.Email.SetText(clientInfo.Email);
            }
            if (clientInfo.Password != null)
                this.Password.SetText(clientInfo.Password);
            if (clientInfo.Address1 != null)
                this.Address1.SetText(clientInfo.Address1);
            if (clientInfo.City != null)
                this.City.SetText(clientInfo.City);
            if (clientInfo.State != null)
                this.StateDropDown.SelectByText(clientInfo.State);
            if (clientInfo.PostCode != null)
                this.Postcode.SetText(clientInfo.PostCode);
            if (clientInfo.Country != null)
                this.CountryDropDown.SelectByText(clientInfo.Country);
            if (clientInfo.Mobile != null)
                this.Mobile.SetText(clientInfo.Mobile);
            this.SubmitButton.Submit();
        }

        [Obsolete]
        public virtual new void WaitForLoad(int timeoutSec=15) {
            WebDriverWait _wait = new WebDriverWait(Driver.WrappedDriver, new TimeSpan(0, 0, timeoutSec));
            _wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div.required > input#email")));
        }

    }
}
