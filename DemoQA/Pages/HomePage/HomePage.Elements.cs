using AutomationPractice.Pages;
using OpenQA.Selenium;


namespace DemoQA.Pages.HomePage
{
   public partial class HomePage : DemoQAPage
    {
        public IWebElement MainMenu(string sectionName) =>
           Driver.FindElement((By.XPath($"//div[@class='card mt-4 top-card']//h5[text()='{sectionName}']/ancestor::div[@class='card mt-4 top-card']")));
    }
}
