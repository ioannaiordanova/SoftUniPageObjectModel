using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.UI;

namespace DemoQA
{
    public class WebDriver
    {
        private IWebDriver _webDriver;
        private WebDriverWait _webDriverWait;
        private Actions _builder;

        public IWebDriver WrappedDriver => _webDriver;

        public WebDriverWait WrappedWait => _webDriverWait;

        public Actions WrappedBuilder => _builder;

        public  void Start(Browser browser)
        {
            Debug.WriteLine(Environment.CurrentDirectory);
            switch (browser)
            {
                case Browser.Chrome:
                    _webDriver = new ChromeDriver(Environment.CurrentDirectory);
                    break;
                case Browser.Firefox:
                    _webDriver = new FirefoxDriver(Environment.CurrentDirectory);
                    break;
                case Browser.Edge:
                    _webDriver = new EdgeDriver(Environment.CurrentDirectory);
                    break;
                case Browser.Opera:
                    _webDriver = new OperaDriver(Environment.CurrentDirectory);
                    break;
                case Browser.Safari:
                    _webDriver = new SafariDriver(Environment.CurrentDirectory);
                    break;
                case Browser.InternetExplorer:
                    _webDriver = new InternetExplorerDriver(Environment.CurrentDirectory);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(browser), browser, null);
            }

            _webDriverWait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(30));
            _webDriver.Manage().Window.Maximize();
            _builder = new Actions(_webDriver);
        }

        public  void Quit()
        {
            _webDriver.Quit();
        }

        public  void GoToUrl(string url)
        {
            _webDriver.Navigate().GoToUrl(url);
        }

        public WebElement FindElement(By locator)
        {
            IWebElement nativeWebElement = 
                _webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
            WebElement element = new WebElement(_webDriver, nativeWebElement, locator,_builder); 

            return element;
        }

        public  List<WebElement> FindElements(By locator)
        {
            ReadOnlyCollection<IWebElement> nativeWebElements = 
                _webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));
            var elements = new List<WebElement>();
            foreach (var nativeWebElement in nativeWebElements)
            {
                WebElement element = new WebElement(_webDriver, nativeWebElement, locator,_builder);
                elements.Add(element);
            }

            return elements;
        }

        public void Navigate(string url)
        {
            WrappedDriver.Navigate().GoToUrl(url);
        }
    }
}
