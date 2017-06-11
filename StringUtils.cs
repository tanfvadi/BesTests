using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PageObject3
{
    public static class StringUtils
    {
        public static T ParseToEnum<T>(this string s)
        {
            return (T)Enum.Parse(typeof(T), Regex.Replace(s.Trim(), "\\s+", ""), true);
        }

    }
}
