using Core;
using OpenQA.Selenium.Interactions;

namespace DemoQA.Pages
{
    public partial class DemoQAPage: BasePage
    {
        public Actions Builder { get; }
        public DemoQAPage(WebDriver driver, Actions builder=null) :base(driver) 
        {
            Builder = builder;
        }    
    }
}
