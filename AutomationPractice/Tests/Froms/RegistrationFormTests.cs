using AutoFixture;
using AutomationPractice.Factories;
using AutomationPractice.Models;
using AutomationPractice.Pages.RegistrationForm;
using AutomationPractice.Pages.SignInPage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Tests.Froms
{
    class RegistrationFormTests : BaseTest
    {
        private SignInPage _signInPage;
        private RegistrationFormPage _registrationFormPage;
        private RegistrationFormModel _user;

        [SetUp]
        [Obsolete]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
           
            _signInPage = new SignInPage(Driver);
            PrerequisitesOfTests();
            _registrationFormPage = new RegistrationFormPage(Driver);   
            _user = RegistrationFormModelFactory.Create();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Obsolete]
        protected void PrerequisitesOfTests()
        {
            _signInPage.LoginButton.Click();      
            _signInPage.WaitForLoad();
            _signInPage.SignIn();
          
    }


        [Test]
        public void ErrorMessageDisplayed_When_SkipFirstName()
        {
            _registrationFormPage.WaitForLoad();
            _user.SkipFirstName();

            _registrationFormPage.FillRegistrationInfo(_user);
            
            _registrationFormPage.AlaertContainsMessage(_user.ErrorMessage);
        }

        [Test]
        public void ErrorMessageDisplayed_When_SkipLastName()
        {
            _registrationFormPage.WaitForLoad();
            _user.SkipLastName();
           
            _registrationFormPage.FillRegistrationInfo(_user);
            
            _registrationFormPage.AlaertContainsMessage(_user.ErrorMessage);
        }

        [Test]
        public void ErrorMessageDisplayed_When_SkipEmail()
        {
            _registrationFormPage.WaitForLoad();
            _user.SkipLastEmail();
            
            _registrationFormPage.FillRegistrationInfo(_user);
            
            _registrationFormPage.AlaertContainsMessage(_user.ErrorMessage);
        }


        [Test]
        public void ErrorMessageDisplayed_When_SetInvalidEmail()
        {
            _registrationFormPage.WaitForLoad();
            _user.SetInvalidEmail();
           
            _registrationFormPage.FillRegistrationInfo(_user);
            
            _registrationFormPage.AlaertContainsMessage(_user.ErrorMessage);
        }


        [Test]
        public void ErrorMessageDisplayed_When_SkipPassword()
        {
            _registrationFormPage.WaitForLoad();
            _user.SkipPassword();
            
            _registrationFormPage.FillRegistrationInfo(_user);
            
            _registrationFormPage.AlaertContainsMessage(_user.ErrorMessage);
        }

        [Test]
        public void ErrorMessageDisplayed_When_SetInvalidPassord()
        {
            _registrationFormPage.WaitForLoad();
            _user.SetInvalidPassword();
            
            _registrationFormPage.FillRegistrationInfo(_user);
            
            _registrationFormPage.AlaertContainsMessage(_user.ErrorMessage);
        }


        [Test]
        public void ErrorMessageDisplayed_When_SkipCity()
        {
            _registrationFormPage.WaitForLoad();
            _user.SkipCity();
           
            _registrationFormPage.FillRegistrationInfo(_user);
            
            _registrationFormPage.AlaertContainsMessage(_user.ErrorMessage);
        }

        [Test]
        public void ErrorMessageDisplayed_When_SkipPostCode()
        {
            _registrationFormPage.WaitForLoad();
            _user.SkipPostCode();
           
            _registrationFormPage.FillRegistrationInfo(_user);
            
            _registrationFormPage.AlaertContainsMessage(_user.ErrorMessage);
        }

        [Test]
        public void ErrorMessageDisplayed_When_SkipMobile()
        {
            _registrationFormPage.WaitForLoad();
            _user.SkipMobile();
            
            _registrationFormPage.FillRegistrationInfo(_user);
            
            _registrationFormPage.AlaertContainsMessage(_user.ErrorMessage);
        }

        
    }
}
