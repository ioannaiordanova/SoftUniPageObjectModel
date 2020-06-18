using DemoQA.Pages.SideBar;
using OpenQA.Selenium;


namespace DemoQA.Pages.Selectable
{
    public partial class SelectablePage : SideBarMenu
    {
        public SelectablePage(WebDriver driver) : base(driver)
        { 
        }

        public bool SelectableIndexExists(int i) {
            if (ListOfSelectables.Count >= i)
                return true;
            else
                return false;
        }

        public WebElement GetSelectableWithIndex(int i) {
           if (SelectableIndexExists(i))
                return ListOfSelectables[i-1];
            else return null;
        }

     

        public override void ClickOnSideBarMenuItem()
        {
            base.ClickOnSideBarMenuItem(SideBarEnum.Selectable.GetStringValue());

        }
    }
}
