using DemoQA.Pages.SideBar;
using OpenQA.Selenium;


namespace DemoQA.Pages.ResizablePage
{
    public partial class ResizablePage : SideBarMenu
    {
        public WebElement ResizableBox => Driver.FindElement(By.Id("resizableBoxWithRestriction"));
        public WebElement ResizableBoxHandle => Driver.FindElement(By.CssSelector(".react-resizable-handle.react-resizable-handle-se"));
        public WebElement ConstraintArea => Driver.FindElement(By.ClassName("constraint-area"));
    }
}
