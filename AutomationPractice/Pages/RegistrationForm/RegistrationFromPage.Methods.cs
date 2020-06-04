using AutomationPractice.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Pages.RegistrationForm
{
    public partial class RegistrationFormPage : BasePageAutomationPractice
    {
        public RegistrationFormPage(IWebDriver driver)
           : base(driver)
        {
        }


        public void FillRegistrationInfo(RegistrationFormModel clientInfo)
        {
            if (clientInfo.FirstName != null)
                this.FirstName.SendKeys(clientInfo.FirstName);
            if (clientInfo.LastName != null)
                this.LastName.SendKeys(clientInfo.LastName);
            if (clientInfo.Email != null)
            {
                this.Email.Clear();
                this.Email.SendKeys(clientInfo.Email);
            }
            if (clientInfo.Password != null)
                this.Password.SendKeys(clientInfo.Password);
            if (clientInfo.Address1 != null)
                this.Address1.SendKeys(clientInfo.Address1);
            if (clientInfo.City != null)
                this.City.SendKeys(clientInfo.City);
            if (clientInfo.State != null)
                this.StateDropDown.SelectByText(clientInfo.State);
            if (clientInfo.PostCode != null)
                this.Postcode.SendKeys(clientInfo.PostCode);
            if (clientInfo.Country != null)
                this.CountryDropDown.SelectByText(clientInfo.Country);
            if (clientInfo.Mobile != null)
                this.Mobile.SendKeys(clientInfo.Mobile);
            this.SubmitButton.Submit();
        }

        [Obsolete]
        public virtual new void WaitForLoad(int timeoutSec=5) {
            WebDriverWait _wait = new WebDriverWait(Driver, new TimeSpan(0, 0, timeoutSec));
            _wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div.required > input#email")));
        }

    }
}
