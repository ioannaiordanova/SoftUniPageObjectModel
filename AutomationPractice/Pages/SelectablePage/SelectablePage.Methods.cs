using AutomationPractice.Pages.SideBar;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace AutomationPractice.Pages.Selectable
{
    public partial class SelectablePage : SideBarMenu
    {
        public SelectablePage(IWebDriver driver) : base(driver)
        { 
        }

        public bool SelectableIndexExists(int i) {
            if (ListOfSelectables.Count >= i)
                return true;
            else
                return false;
        }

        public IWebElement GetSelectableWithIndex(int i) {
           if (SelectableIndexExists(i))
                return ListOfSelectables[i-1];
            else return null;
        }

        public string GetCssValue(int index) {
            if (SelectableIndexExists(index))
                return ListOfSelectables[index-1].GetCssValue("background");
            else return null;
        }

        public override void ClickOnSideBarMenuItem()
        {
            base.ClickOnSideBarMenuItem(SideBarEnum.Selectable.GetStringValue());

        }
    }
}
