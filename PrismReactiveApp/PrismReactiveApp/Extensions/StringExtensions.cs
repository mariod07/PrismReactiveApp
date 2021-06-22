using System;
using System.Collections.Generic;
using System.Text;

namespace PrismReactiveApp.Extensions
{
    static class StringExtensions
    {
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source != null && toCheck != null && source.IndexOf(toCheck, comp) >= 0;
        }
    }
}
