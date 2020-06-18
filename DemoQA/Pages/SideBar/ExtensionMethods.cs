using System;
using System.Reflection;


namespace DemoQA.Pages.SideBar
{
	
		public static class ExtensionMethods
		{
			public static string GetStringValue(this Enum value)
			{
				string stringValue = value.ToString();
				Type type = value.GetType();
				FieldInfo fieldInfo = type.GetField(value.ToString());
			     IdValue[] attrs = fieldInfo.
					GetCustomAttributes(typeof(IdValue), false) as IdValue[];
				if (attrs.Length > 0)
				{
					stringValue = attrs[0].Value;
				}
				return stringValue;
			}
		}
	
}
