using Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace SoftUni.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected WebDriver Driver { get; set; }



        public void Initialize()
        {
            Driver = new WebDriver();
            Driver.Start(Browser.Chrome);
        }


    }
}
