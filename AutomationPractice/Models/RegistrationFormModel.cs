using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Models
{
   public class RegistrationFormModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string Mobile { get; set; }
        public string ErrorMessage { get; set; }


        public void SkipFirstName()
        {
            this.FirstName = null;
            this.ErrorMessage = "firstname is required.";
        }

        public void SkipLastEmail()
        {
            this.LastName = null;
            this.ErrorMessage = "lastname is required.";
        }

        public void SkipLastName()
        {
            this.LastName = null;
            this.ErrorMessage = "lastname is required.";
        }

        public void SetInvalidEmail()
        {
            this.Email = "InvalidEmail";
            this.ErrorMessage = "email is invalid.";
        }

        public void SkipPassword()
        {
            this.Password = null;
            this.ErrorMessage = "passwd is required.";
        }

        public void SetInvalidPassword()
        {
            this.Password = "ddd";
            this.ErrorMessage = "passwd is invalid.";
        }

        public void SkipAddress()
        {
            this.Address1 = null;
            this.ErrorMessage = "address1 is required";
        }

        public void SkipCity()
        {
            this.City = null;
            this.ErrorMessage = "city is required.";
        }

        public void SkipPostCode()
        {
            this.PostCode = null;
            this.ErrorMessage = "The Zip/Postal code you've entered is invalid. It must follow this format: 00000";
        }

        public void SkipMobile()
        {
            this.Mobile = null;
            this.ErrorMessage = "You must register at least one phone number.";
        }
    }
}
