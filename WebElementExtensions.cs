using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace BesTests
{
    public static class WebElementExtensions
    {
        public static IWebElement ClearAndFill(this IWebElement element,string text)
        {
            element.Clear();
            element.SendKeys(text);
            return element;
        }

        public static string GetValue(this IWebElement element)
        {
            return element.GetAttribute("value");
        }
    }
}
