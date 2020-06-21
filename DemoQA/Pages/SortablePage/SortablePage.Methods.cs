using Core;
using DemoQA.Pages.SideBar;
using OpenQA.Selenium.Interactions;


namespace DemoQA.Pages.SortablePage
{
    public partial class SortablePage : SideBarMenu
    {
        public SortablePage(WebDriver driver, Actions builder) : base(driver, builder) 
        {

        }

        public bool IndexExists(int i) 
        {
            if (ListItems.Count >= i)
                return true;
            else return false;     
        }

        public WebElement GetGridElementByIndex(int i)
        {
            if (IndexExists(i))
            {
                return GridItems[i-1];
            }
            else return null;
        }

       

        public WebElement GetListElementByIndex(int i)
        {
            if (IndexExists(i))
            {
                return ListItems[i-1];
            }
            else return null;
        }

        public string GetListItemText(int i) 
        {
           return GetListElementByIndex(i).Text;
        }

        public override void ClickOnSideBarMenuItem()
        {
            base.ClickOnSideBarMenuItem(SideBarEnum.Sortable.GetStringValue());

        }
    }
}
