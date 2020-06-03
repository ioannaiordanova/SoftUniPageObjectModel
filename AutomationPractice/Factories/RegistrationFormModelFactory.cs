using AutomationPractice.Models;

namespace AutomationPractice.Factories
{
    public static class RegistrationFormModelFactory
    {
        public static RegistrationFormModel Create() { 
            return new RegistrationFormModel
            {
                FirstName = "FirstName",
                LastName = "LastName",
                Email = "Email",
                Password = "Password",
                Address1 = "Address1",
                City = "City",
                State = "Alabama",
                PostCode = "PostCode",
                Country = "United States",
                Mobile = "Mobile"

            };
        }
    }
}
