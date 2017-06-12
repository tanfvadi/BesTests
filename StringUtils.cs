using System;
using System.Text.RegularExpressions;

namespace BesTests
{
    public static class StringUtils
    {
        public static T ParseToEnum<T>(this string s)
        {
            return (T)Enum.Parse(typeof(T), Regex.Replace(s.Trim(), "\\s+", ""), true);
        }

    }
}
