using System;


namespace AutomationPractice.Pages.SideBar
{
    class IdValue : Attribute
    {
        public string Value { get; private set; }

        public IdValue(string value)
        {
            Value = value;
        }
    }
}
