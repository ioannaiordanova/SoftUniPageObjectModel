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
                Email = "Email@abv.bg",
                Password = "Password",
                Address1 = "Address1",
                City = "City",
                State = "Alabama",
                PostCode = "11111",
                Country = "United States",
                Mobile = "Mobile"

            };
        }
    }
}
