using OpenQA.Selenium;


namespace DemoQA.Pages
{
   public partial class HomePage : DemoQAPage
    {
        public WebElement MainMenu(string sectionName) =>
           Driver.FindElement((By.XPath($"//div[@class='card mt-4 top-card']//h5[text()='{sectionName}']/ancestor::div[@class='card mt-4 top-card']")));
    }
}
