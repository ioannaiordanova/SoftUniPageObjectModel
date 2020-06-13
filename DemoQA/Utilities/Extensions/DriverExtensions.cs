using OpenQA.Selenium;

namespace AutomationPractice.Utilities.Extensions
{
    public static class DriverExtensions
    {
        public static void ScrollTo(this IWebDriver driver, IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public static int YOf(this IWebDriver driver, IWebElement element) {
            return element.Location.Y;
        }

        public static int XOf(this IWebDriver driver, IWebElement element)
        {
            return element.Location.X;
        }
    }
}
