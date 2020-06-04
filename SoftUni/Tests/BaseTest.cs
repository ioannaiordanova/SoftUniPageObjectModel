using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace SoftUni.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver Driver { get; set; }

        

        public void Initialize()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Driver.Manage().Window.Maximize();
        }


    }
}
