using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Pages.SortablePage
{
    public partial class SortablePage : BasePageDemoQA
    {
        public SortablePage(IWebDriver driver, Actions builder) : base(driver, builder) {

        }

        public bool IndexExists(int i) {
            if (ListItems.Count >= i)
                return true;
            else return false;
           
        }

        public IWebElement GetGridElementByIndex(int i)
        {
            if (IndexExists(i))
            {
                return GridItems[i - 1];
            }
            else return null;
        }

        public IWebElement GetListElementByIndex(int i){
            if (IndexExists(i))
            {
                return ListItems[i-1];
            }
            else return null;
        }

        public string GetListItemText(int i) {
           return GetListElementByIndex(i).Text;
        }

        public int GetListElementHeight(int i) {
            return GetListElementByIndex(i).Size.Height;
        }

        public void MoveListElementOneBelow(int i) {

            Builder
               .DragAndDropToOffset(GetListElementByIndex(i), 0, GetListElementHeight(i) + 10)
               .Release(GetListElementByIndex(i))
               .Perform();
        }
    }
}
